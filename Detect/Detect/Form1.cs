using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;

namespace Detect
{
    public partial class Form1 : Form
    {
        Process console; //呼叫 cmd
        bool console_Start = false; //確認呼叫

        FolderBrowserDialog Path_load_file_darknet; //資料夾路徑(darknet.exe)
        FolderBrowserDialog Path_load_file_detect; //資料夾路徑(detect)

        StreamWriter sw; //Save
        StreamWriter sa; //Save

        public Form1()
        {
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //軟體關閉時事件(主要釋放記憶體)!
        {
            if (console_Start == true)
            {
                //console.StandardInput.WriteLine("exit");
                //console.StandardOutput.ReadToEnd();
                console.StandardInput.Close(); //中斷
                console.WaitForExit();  //等待程式執行完退出程序
                console.Close();
                console.Dispose(); //!

                console_Start = false;
            }
        }

        void Call_Cmd() //呼叫 Cmd
        {
            console = new Process();
            console.StartInfo.FileName = "cmd.exe";
            console.StartInfo.UseShellExecute = false;
            console.StartInfo.RedirectStandardInput = true;
            console.StartInfo.RedirectStandardOutput = true;
            console.StartInfo.RedirectStandardError = true;
            console.StartInfo.CreateNoWindow = true; //隱藏 cmd 視窗
            console.Start();

        }

        private void label_darknet_MouseClick(object sender, MouseEventArgs e) //darknet.exe 目錄
        {
            // Path load file darknet.exe 
            Path_load_file_darknet = new FolderBrowserDialog();
            Path_load_file_darknet.ShowDialog();

            if (Path_load_file_darknet.SelectedPath != "")
            {
                listBox_ReadIO.Items.Add("File darknet.exe : ok");
                label_darknet.Text = Path_load_file_darknet.SelectedPath;

                label_detect.Enabled = true;
                //label_darknet.Enabled = false;
            }
            else { MessageBox.Show("Path load file darknet.exe"); }

            Path_load_file_darknet.Dispose();
        }

        private void label_detect_MouseClick(object sender, MouseEventArgs e) //選擇檢測路徑
        {
            // Path load file detect
            Path_load_file_detect = new FolderBrowserDialog();
            Path_load_file_detect.ShowDialog();

            if (Path_load_file_detect.SelectedPath != "")
            {
                //Path.GetFileName(Path) -> 檔名與副檔名
                //Path.GetFileNameWithoutExtension(Path) -> 檔名
                //Path.GetExtension(Path) -> 副檔名
                //Path.GetDirectoryName(Path) -> 路徑不含檔名副檔名
                string str = Path.GetFileNameWithoutExtension(Path_load_file_detect.SelectedPath); //只保留資料夾名稱
                listBox_ReadIO.Items.Add(str + " : ok");
                listBox_ReadIO.Items.Add("Deputy File Name !");
                label_detect.Text = Path_load_file_detect.SelectedPath;

                button_Connect.Enabled = true;
                //label_detect.Enabled = false;
            }
            else { MessageBox.Show("Path load file detect"); }

            Path_load_file_detect.Dispose();
        }

        private void comboBox_weights_MouseClick(object sender, MouseEventArgs e) //載入權重
        {
            //Model 載入 Admin 使用
            DirectoryInfo ModelPath = new DirectoryInfo(label_darknet.Text.ToString() + "/backup_G5");
            foreach (var fi in ModelPath.GetFiles("*.weights"))
            {
                comboBox_weights.Items.Add(fi.Name);
            }
        }

        private void button_Reset_Click(object sender, EventArgs e) //初始化
        {
            if (console_Start == true)
            {
                //console.StandardInput.WriteLine("exit");
                //console.StandardOutput.ReadToEnd();
                console.StandardInput.Close(); //中斷
                console.WaitForExit();  //等待程式執行完退出程序
                console.Close();
                console.Dispose(); //!

                console_Start = false;
                button_Connect.Enabled = false;

                ////預設
                //label_darknet.Text = "No path load file darknet.exe";
                //label_detect.Text = "No path load file detect";
                //comboBox_DeputyName.Text = "Select";
                //comboBox_weights.Text = "yolov3-coco_final.weights";

                //listBox_ReadIO.Items.Clear();
                //listBox_Result.Items.Clear();
            }
            Application.Restart();
        }

        private void button_Connect_Click(object sender, EventArgs e) //開啟連結 Yolo v3
        {
            Call_Cmd();

            console.StandardInput.WriteLine("cd " + label_darknet.Text.ToString());
            console.StandardInput.WriteLine("darknet.exe detector test data/coco_G5.data cfg/yolov3-coco_G5.cfg_test backup_G5/" + comboBox_weights.Text); // + " -thresh 0.3"); + " -thresh 0.8"
            listBox_ReadIO.Items.Add("Mode : " + comboBox_weights.Text);
            listBox_ReadIO.Items.Add("");

            int countTime = 0;
            string str = console.StandardOutput.ReadLine(); //讀到 Path 就可開始檢測
            while (str != "Path")
            {
                str = console.StandardOutput.ReadLine();
                countTime++;
                if (countTime == 50000) { break; }//超過時間
            }
            
            if (countTime != 50000)
            {
                listBox_ReadIO.Items.Add("-------------------------------------------------------------------------------------------------------------------------------( Connect : ok )");
                listBox_ReadIO.Items.Add("");

                console_Start = true;
                button_Connect.Enabled = false;
            }
            else
            {
                listBox_ReadIO.Items.Add("Connect : Error !");
                listBox_ReadIO.Items.Add("");

                console.StandardInput.Close(); //中斷
                console.WaitForExit();  //等待程式執行完退出程序
                console.Close();
                console.Dispose(); //!

                console_Start = false;
                button_Connect.Enabled = true;
            }
        }

        private void button_Detect_Click(object sender, EventArgs e) //檢測
        {
            Task.Run(() => All_Classification());
            Directory.CreateDirectory(comboBox_weights.Text);
            sa = new StreamWriter(comboBox_weights.Text + @"\" + "Accurate.csv", false);
        }

        void All_Classification()
        {
            if (console_Start == true)
            {
                if (comboBox_DeputyName.Text != "Select")
                {
                    try
                    {
                        button_Detect.Enabled = false;

                        //要檢測的資料夾路徑
                        string All_Path = label_detect.Text; //路徑
                        DirectoryInfo Path_Class = new DirectoryInfo(All_Path);

                        //檢測資料夾類別數量 START
                        int quantityClass = Path_Class.GetDirectories("*").Length; //數量
                        listBox_Result.Items.Add("Classes : " + quantityClass.ToString());
                        listBox_Result.Items.Add("");            

                        //檢測類別 START
                        string[] Classes = new string[quantityClass];
                        int n = 0;
                        foreach (var fi in Path_Class.GetDirectories("*"))
                        {
                            Classes[n] = fi.Name;
                            listBox_Result.Items.Add((n + 1).ToString() + ". " + Classes[n]);
                            n++;
                        }
                        listBox_Result.Items.Add("");
                        

                        //正式檢測
                        int No = 0; //無法分類
                        for (int i = 0; i < quantityClass; i++)
                        {
                            try
                            {
                                string Class_FileName = Classes[i]; //檢測類別
                                listBox_Result.Items.Add((i + 1).ToString() + " ---------------------------");
                                listBox_Result.Items.Add("Class : " + Class_FileName);

                                //檢測資料夾圖片數量 START
                                string DParth = All_Path + @"\" + Class_FileName;
                                DirectoryInfo Path_Images = new DirectoryInfo(DParth);
                                int quantity = Path_Images.GetFiles("*." + comboBox_DeputyName.Text).Length; //圖片數量
                                listBox_Result.Items.Add("Quantity : " + quantity.ToString());
                                //檢測資料夾圖片數量 END

                                //*.csv
                                
                                sw = new StreamWriter(comboBox_weights.Text+@"\" + Class_FileName + "_detect.csv", false);

                                //統計分類
                                int[] CountN = new int[quantityClass + 1];

                                //START
                                int Count_OK = 0, Sum = 0; //分對數量, 檢測數量
                                foreach (var fi in Path_Images.GetFiles("*." + comboBox_DeputyName.Text))
                                {
                                    console.StandardInput.WriteLine(DParth + @"\" + fi.Name); //每個圖片路徑
                                    string str = console.StandardOutput.ReadLine(); //讀取 cmd 回傳值
                                    while (str == null || str == "Path")
                                    {
                                        str = console.StandardOutput.ReadLine();
                                    }
                                    Sum++; //檢測數量
                                    listBox_ReadIO.Items.Add("Image[" + Sum + "] : " + str); //檢測圖片的路徑

                                    string Dectet_Result = console.StandardOutput.ReadLine(); //讀取 Yolo v3 分類結果
                                    listBox_ReadIO.Items.Add("Result : " + Dectet_Result);

                                    sw.WriteLine(str + "," + Dectet_Result); //寫入*.csv

                                    //無法分類 START
                                    string ncs = "";
                                    for (int cs = 0; cs < quantityClass; cs++) 
                                    {
                                        if (Classes[cs] == Dectet_Result) { CountN[cs]++; }
                                    }
                                    if (Dectet_Result == "No") { CountN[quantityClass]++; } // 無法分類
                                    //無法分類 END

                                    listBox_ReadIO.Items.Add("");
                                    listBox_ReadIO.SelectedIndex = listBox_ReadIO.Items.Count - 2;
                                    
                                    if (Class_FileName == Dectet_Result) { Count_OK++; } //分對數量(後算準確度)
                                }
                                //檢測開始 END

                                

                                //準確度 START
                                float accurate = ((float)Count_OK / (float)quantity) * 100;
                                listBox_Result.Items.Add("Accurate : " + accurate + " %"); //統計
                                listBox_Result.Items.Add("");

                                sa.WriteLine(Class_FileName + "," + quantity.ToString() + "," + "Accurate: " + accurate.ToString() + " %");
                                //準確度 END

                                listBox_Result.Items.Add("");
                                listBox_Result.SelectedIndex = listBox_Result.Items.Count - 2;

                                No = No + CountN[quantityClass]; //統計沒有分出Class數量

                                //寫入*.csv
                                sw.WriteLine("" + "\n");

                                sw.WriteLine(Class_FileName + "," + quantity.ToString() + "," + "Accurate: " + accurate.ToString() + " %");
                                string CsNe = "", CsCount = "";
                                for (int rl = 0; rl < quantityClass; rl++)
                                {
                                    CsNe = CsNe + (Classes[rl] + ",");
                                    CsCount = CsCount + (CountN[rl].ToString() + ",");
                                }
                                CsNe = CsNe + "No";
                                CsCount = CsCount + CountN[quantityClass].ToString();
                                sw.WriteLine(CsNe);
                                sw.WriteLine(CsCount);
                                sw.Close();
                                sw.Dispose();
                                //sa.Close();
                                //sa.Dispose();
                            }
                            catch (Exception er) { sw.Close(); sw.Dispose(); MessageBox.Show("Detect error ! Please Click reset !"); }
                        }
                        listBox_Result.Items.Add("No classes : " + No.ToString()); //無法分類
                        sa.Close();
                        sa.Dispose();
                        MessageBox.Show("All Save. Please Click reset !");
                    }
                    catch (Exception Cai) { MessageBox.Show("Error ! Please Click reset !"); }
                }
                else { MessageBox.Show("No deputy file name !"); }
            }
            else { MessageBox.Show("No connect !"); }
        }

        private void comboBox_weights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

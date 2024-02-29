namespace Detect
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Detect = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.listBox_ReadIO = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_weights = new System.Windows.Forms.ComboBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.comboBox_DeputyName = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_detect = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_darknet = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox_Result = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Detect);
            this.groupBox1.Controls.Add(this.button_Reset);
            this.groupBox1.Controls.Add(this.listBox_ReadIO);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 534);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Darknet-53 Cai ";
            // 
            // button_Detect
            // 
            this.button_Detect.BackColor = System.Drawing.Color.Black;
            this.button_Detect.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Detect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Detect.Location = new System.Drawing.Point(518, 490);
            this.button_Detect.Name = "button_Detect";
            this.button_Detect.Size = new System.Drawing.Size(73, 33);
            this.button_Detect.TabIndex = 11;
            this.button_Detect.Text = "Detect";
            this.button_Detect.UseVisualStyleBackColor = false;
            this.button_Detect.Click += new System.EventHandler(this.button_Detect_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.Black;
            this.button_Reset.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Reset.Location = new System.Drawing.Point(591, 490);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(73, 33);
            this.button_Reset.TabIndex = 10;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // listBox_ReadIO
            // 
            this.listBox_ReadIO.BackColor = System.Drawing.Color.Black;
            this.listBox_ReadIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_ReadIO.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_ReadIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBox_ReadIO.FormattingEnabled = true;
            this.listBox_ReadIO.Location = new System.Drawing.Point(6, 183);
            this.listBox_ReadIO.Name = "listBox_ReadIO";
            this.listBox_ReadIO.Size = new System.Drawing.Size(658, 327);
            this.listBox_ReadIO.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox_weights);
            this.groupBox4.Controls.Add(this.button_Connect);
            this.groupBox4.Controls.Add(this.comboBox_DeputyName);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(6, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(658, 54);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deputy File Name";
            // 
            // comboBox_weights
            // 
            this.comboBox_weights.BackColor = System.Drawing.Color.Black;
            this.comboBox_weights.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_weights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox_weights.FormattingEnabled = true;
            this.comboBox_weights.Location = new System.Drawing.Point(169, 23);
            this.comboBox_weights.Name = "comboBox_weights";
            this.comboBox_weights.Size = new System.Drawing.Size(274, 21);
            this.comboBox_weights.TabIndex = 9;
            this.comboBox_weights.Text = "yolov3-coco_final.weights";
            this.comboBox_weights.SelectedIndexChanged += new System.EventHandler(this.comboBox_weights_SelectedIndexChanged);
            this.comboBox_weights.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_weights_MouseClick);
            // 
            // button_Connect
            // 
            this.button_Connect.BackColor = System.Drawing.Color.Black;
            this.button_Connect.Enabled = false;
            this.button_Connect.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Connect.Location = new System.Drawing.Point(449, 15);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(203, 33);
            this.button_Connect.TabIndex = 8;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = false;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // comboBox_DeputyName
            // 
            this.comboBox_DeputyName.BackColor = System.Drawing.Color.Black;
            this.comboBox_DeputyName.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_DeputyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox_DeputyName.FormattingEnabled = true;
            this.comboBox_DeputyName.Items.AddRange(new object[] {
            "bmp",
            "png",
            "jpg",
            "gif"});
            this.comboBox_DeputyName.Location = new System.Drawing.Point(11, 23);
            this.comboBox_DeputyName.Name = "comboBox_DeputyName";
            this.comboBox_DeputyName.Size = new System.Drawing.Size(152, 21);
            this.comboBox_DeputyName.TabIndex = 1;
            this.comboBox_DeputyName.Text = "Select";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_detect);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 45);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Path load file detect";
            // 
            // label_detect
            // 
            this.label_detect.AutoSize = true;
            this.label_detect.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_detect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label_detect.Location = new System.Drawing.Point(8, 22);
            this.label_detect.Name = "label_detect";
            this.label_detect.Size = new System.Drawing.Size(116, 13);
            this.label_detect.TabIndex = 0;
            this.label_detect.Text = "No path load file detect";
            this.label_detect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_detect_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_darknet);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 45);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path load file darknet.exe ";
            // 
            // label_darknet
            // 
            this.label_darknet.AutoSize = true;
            this.label_darknet.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_darknet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label_darknet.Location = new System.Drawing.Point(8, 22);
            this.label_darknet.Name = "label_darknet";
            this.label_darknet.Size = new System.Drawing.Size(143, 13);
            this.label_darknet.TabIndex = 0;
            this.label_darknet.Text = "No path load file darknet.exe";
            this.label_darknet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_darknet_MouseClick);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Black;
            this.groupBox5.Controls.Add(this.listBox_Result);
            this.groupBox5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox5.Location = new System.Drawing.Point(688, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(256, 534);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Result ";
            // 
            // listBox_Result
            // 
            this.listBox_Result.BackColor = System.Drawing.Color.Black;
            this.listBox_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Result.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox_Result.FormattingEnabled = true;
            this.listBox_Result.Location = new System.Drawing.Point(6, 14);
            this.listBox_Result.Name = "listBox_Result";
            this.listBox_Result.Size = new System.Drawing.Size(244, 509);
            this.listBox_Result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(956, 558);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_detect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_darknet;
        private System.Windows.Forms.ListBox listBox_ReadIO;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox_DeputyName;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBox_Result;
        private System.Windows.Forms.ComboBox comboBox_weights;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Detect;
    }
}


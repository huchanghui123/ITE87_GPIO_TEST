namespace GPIO_TEST
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gpio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gp_data = new System.Windows.Forms.TextBox();
            this.lab_mode = new System.Windows.Forms.Label();
            this.lab_val = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gp_mode = new System.Windows.Forms.TextBox();
            this.btn_mode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "GP80-87分别对应bit位0-7；例如：0F，GP80-87分别是00001111";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "IO属性设置：0输入，1输出；IO为输出时：0为低，1为高";
            // 
            // btn_gpio
            // 
            this.btn_gpio.Location = new System.Drawing.Point(258, 236);
            this.btn_gpio.Name = "btn_gpio";
            this.btn_gpio.Size = new System.Drawing.Size(75, 25);
            this.btn_gpio.TabIndex = 3;
            this.btn_gpio.Text = "SET GPIO";
            this.btn_gpio.UseVisualStyleBackColor = true;
            this.btn_gpio.Click += new System.EventHandler(this.btn_gpio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "拉高/拉低(Hex)";
            // 
            // gp_data
            // 
            this.gp_data.Location = new System.Drawing.Point(132, 240);
            this.gp_data.Name = "gp_data";
            this.gp_data.Size = new System.Drawing.Size(100, 21);
            this.gp_data.TabIndex = 8;
            // 
            // lab_mode
            // 
            this.lab_mode.AutoSize = true;
            this.lab_mode.Location = new System.Drawing.Point(31, 272);
            this.lab_mode.Name = "lab_mode";
            this.lab_mode.Size = new System.Drawing.Size(71, 12);
            this.lab_mode.TabIndex = 9;
            this.lab_mode.Text = "GPIO MODE：";
            // 
            // lab_val
            // 
            this.lab_val.AutoSize = true;
            this.lab_val.Location = new System.Drawing.Point(143, 272);
            this.lab_val.Name = "lab_val";
            this.lab_val.Size = new System.Drawing.Size(77, 12);
            this.lab_val.TabIndex = 10;
            this.lab_val.Text = "GPIO VALUE：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GPIO_TEST.Properties.Resources.gpio2;
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 104);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "In/Out(Hex)";
            // 
            // gp_mode
            // 
            this.gp_mode.Location = new System.Drawing.Point(132, 208);
            this.gp_mode.Name = "gp_mode";
            this.gp_mode.Size = new System.Drawing.Size(100, 21);
            this.gp_mode.TabIndex = 14;
            // 
            // btn_mode
            // 
            this.btn_mode.Location = new System.Drawing.Point(258, 205);
            this.btn_mode.Name = "btn_mode";
            this.btn_mode.Size = new System.Drawing.Size(75, 25);
            this.btn_mode.TabIndex = 15;
            this.btn_mode.Text = "SET MODE";
            this.btn_mode.UseVisualStyleBackColor = true;
            this.btn_mode.Click += new System.EventHandler(this.btn_mode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(578, 331);
            this.Controls.Add(this.btn_mode);
            this.Controls.Add(this.gp_mode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_val);
            this.Controls.Add(this.lab_mode);
            this.Controls.Add(this.gp_data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_gpio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GPIO TEST";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_gpio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gp_data;
        private System.Windows.Forms.Label lab_mode;
        private System.Windows.Forms.Label lab_val;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gp_mode;
        private System.Windows.Forms.Button btn_mode;
    }
}


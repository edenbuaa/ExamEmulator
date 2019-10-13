namespace ExamEmulator
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel_menu1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_menu_select = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_menu1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu1
            // 
            this.panel_menu1.Controls.Add(this.button4);
            this.panel_menu1.Location = new System.Drawing.Point(13, 97);
            this.panel_menu1.Name = "panel_menu1";
            this.panel_menu1.Size = new System.Drawing.Size(1145, 365);
            this.panel_menu1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::ExamEmulator.Properties.Resources.m1_select;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(87, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 203);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackgroundImage = global::ExamEmulator.Properties.Resources.backiee_127424_landscape;
            this.flowLayoutPanel1.Controls.Add(this.btn_menu_select);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1157, 90);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_menu_select
            // 
            this.btn_menu_select.BackgroundImage = global::ExamEmulator.Properties.Resources.menu1;
            this.btn_menu_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_select.Location = new System.Drawing.Point(3, 3);
            this.btn_menu_select.Name = "btn_menu_select";
            this.btn_menu_select.Size = new System.Drawing.Size(90, 80);
            this.btn_menu_select.TabIndex = 0;
            this.btn_menu_select.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ExamEmulator.Properties.Resources.menu2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(99, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 80);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ExamEmulator.Properties.Resources.menu3;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(195, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 80);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ExamEmulator.Properties.Resources.menu4;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(291, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 80);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 464);
            this.Controls.Add(this.panel_menu1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "全国计算机等级考试模拟软件";
            this.panel_menu1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_menu_select;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel_menu1;
        private System.Windows.Forms.Button button4;
    }
}


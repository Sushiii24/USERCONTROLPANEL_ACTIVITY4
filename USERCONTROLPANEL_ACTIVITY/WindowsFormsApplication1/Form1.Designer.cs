namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_btn = new System.Windows.Forms.Button();
            this.panel2_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.InputData2_text = new System.Windows.Forms.TextBox();
            this.InputData_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2UserControl1 = new WindowsFormsApplication1.Panel2UserControl();
            this.homePanelControl1 = new WindowsFormsApplication1.HomePanelControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel_btn);
            this.panel1.Controls.Add(this.panel2_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 525);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER CONTROL PANEL APPLICATION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.InputData2_text);
            this.panel2.Controls.Add(this.InputData_text);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(583, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 525);
            this.panel2.TabIndex = 0;
            // 
            // panel_btn
            // 
            this.panel_btn.Location = new System.Drawing.Point(30, 168);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(126, 23);
            this.panel_btn.TabIndex = 1;
            this.panel_btn.Text = "Panel One";
            this.panel_btn.UseVisualStyleBackColor = true;
            this.panel_btn.Click += new System.EventHandler(this.panel_btn_Click);
            // 
            // panel2_btn
            // 
            this.panel2_btn.Location = new System.Drawing.Point(30, 243);
            this.panel2_btn.Name = "panel2_btn";
            this.panel2_btn.Size = new System.Drawing.Size(126, 23);
            this.panel2_btn.TabIndex = 2;
            this.panel2_btn.Text = "Panel Two";
            this.panel2_btn.UseVisualStyleBackColor = true;
            this.panel2_btn.Click += new System.EventHandler(this.panel2_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "DATA:";
            // 
            // InputData2_text
            // 
            this.InputData2_text.Location = new System.Drawing.Point(21, 276);
            this.InputData2_text.Name = "InputData2_text";
            this.InputData2_text.Size = new System.Drawing.Size(158, 20);
            this.InputData2_text.TabIndex = 8;
            // 
            // InputData_text
            // 
            this.InputData_text.Location = new System.Drawing.Point(21, 168);
            this.InputData_text.Name = "InputData_text";
            this.InputData_text.Size = new System.Drawing.Size(158, 20);
            this.InputData_text.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input Two:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Input One:";
            // 
            // panel2UserControl1
            // 
            this.panel2UserControl1.BackColor = System.Drawing.Color.Moccasin;
            this.panel2UserControl1.Location = new System.Drawing.Point(206, 55);
            this.panel2UserControl1.Name = "panel2UserControl1";
            this.panel2UserControl1.Size = new System.Drawing.Size(371, 487);
            this.panel2UserControl1.TabIndex = 2;
            // 
            // homePanelControl1
            // 
            this.homePanelControl1.BackColor = System.Drawing.Color.Wheat;
            this.homePanelControl1.Location = new System.Drawing.Point(206, 55);
            this.homePanelControl1.Name = "homePanelControl1";
            this.homePanelControl1.Size = new System.Drawing.Size(371, 470);
            this.homePanelControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 525);
            this.Controls.Add(this.panel2UserControl1);
            this.Controls.Add(this.homePanelControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button panel_btn;
        private System.Windows.Forms.Button panel2_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private HomePanelControl homePanelControl1;
        private Panel2UserControl panel2UserControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputData2_text;
        private System.Windows.Forms.TextBox InputData_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


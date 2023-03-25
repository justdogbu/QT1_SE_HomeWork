namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.GroupBox();
            this.bTransport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Window;
            this.menu.Controls.Add(this.button3);
            this.menu.Controls.Add(this.button2);
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.bTransport);
            this.menu.Location = new System.Drawing.Point(233, 12);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(349, 426);
            this.menu.TabIndex = 0;
            this.menu.TabStop = false;
            this.menu.Text = "Menu";
            // 
            // bTransport
            // 
            this.bTransport.BackColor = System.Drawing.Color.Indigo;
            this.bTransport.ForeColor = System.Drawing.Color.White;
            this.bTransport.Location = new System.Drawing.Point(107, 26);
            this.bTransport.Name = "bTransport";
            this.bTransport.Size = new System.Drawing.Size(149, 85);
            this.bTransport.TabIndex = 0;
            this.bTransport.Text = "Choose Transport";
            this.bTransport.UseVisualStyleBackColor = false;
            this.bTransport.Click += new System.EventHandler(this.bTransport_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(107, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose Destination";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(107, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 85);
            this.button2.TabIndex = 2;
            this.button2.Text = "Choose Payment";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Indigo;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(107, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 85);
            this.button3.TabIndex = 3;
            this.button3.Text = "Select Language";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "Ticket Vending Machine";
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox menu;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button bTransport;
    }
}

namespace Storage_Master_sec_stage
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
            this.welcomeSign = new System.Windows.Forms.Label();
            this.panelLable = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.TextBox();
            this.CommandHistory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeSign
            // 
            this.welcomeSign.AutoSize = true;
            this.welcomeSign.Location = new System.Drawing.Point(282, 9);
            this.welcomeSign.Name = "welcomeSign";
            this.welcomeSign.Size = new System.Drawing.Size(153, 15);
            this.welcomeSign.TabIndex = 0;
            this.welcomeSign.Text = "Welcome to Storage Master";
            // 
            // panelLable
            // 
            this.panelLable.AutoSize = true;
            this.panelLable.BackColor = System.Drawing.SystemColors.Info;
            this.panelLable.Location = new System.Drawing.Point(610, 9);
            this.panelLable.Name = "panelLable";
            this.panelLable.Size = new System.Drawing.Size(79, 15);
            this.panelLable.TabIndex = 2;
            this.panelLable.Text = "Control Panel\r\n";
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(12, 53);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(94, 43);
            this.addProductBtn.TabIndex = 3;
            this.addProductBtn.Text = "AddProduct";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-537, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "AddProduct";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Commands";
            // 
            // ControlPanel
            // 
            this.ControlPanel.Location = new System.Drawing.Point(478, 65);
            this.ControlPanel.Multiline = true;
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(114, 319);
            this.ControlPanel.TabIndex = 6;
            // 
            // CommandHistory
            // 
            this.CommandHistory.FormattingEnabled = true;
            this.CommandHistory.ItemHeight = 15;
            this.CommandHistory.Location = new System.Drawing.Point(617, 65);
            this.CommandHistory.Name = "CommandHistory";
            this.CommandHistory.Size = new System.Drawing.Size(154, 319);
            this.CommandHistory.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(478, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current command:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(617, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Command panel:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CommandHistory);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.panelLable);
            this.Controls.Add(this.welcomeSign);
            this.Name = "Form1";
            this.Text = "Storage Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeSign;
        private System.Windows.Forms.Label panelLable;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ControlPanel;
        public System.Windows.Forms.ListBox CommandHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


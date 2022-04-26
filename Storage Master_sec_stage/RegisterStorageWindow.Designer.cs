
namespace Storage_Master_sec_stage
{
    partial class RegisterStorageWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StoragesAv = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name:";
            // 
            // typeText
            // 
            this.typeText.Location = new System.Drawing.Point(182, 42);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(133, 23);
            this.typeText.TabIndex = 2;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(198, 86);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 23);
            this.nameText.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Legend with\r\navailable storages:\r\n";
            // 
            // StoragesAv
            // 
            this.StoragesAv.BackColor = System.Drawing.SystemColors.Control;
            this.StoragesAv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StoragesAv.FormattingEnabled = true;
            this.StoragesAv.ItemHeight = 15;
            this.StoragesAv.Location = new System.Drawing.Point(12, 51);
            this.StoragesAv.Name = "StoragesAv";
            this.StoragesAv.Size = new System.Drawing.Size(144, 90);
            this.StoragesAv.TabIndex = 6;
            this.StoragesAv.SelectedIndexChanged += new System.EventHandler(this.StoragesAv_SelectedIndexChanged);
            // 
            // RegisterStorageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 236);
            this.Controls.Add(this.StoragesAv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "RegisterStorageWindow";
            this.Text = "RedisterStorageWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox typeText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox StoragesAv;
    }
}
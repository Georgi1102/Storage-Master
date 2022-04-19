
namespace Storage_Master_sec_stage
{
    partial class AddProductWindow
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
            this.priceText = new System.Windows.Forms.TextBox();
            this.typeText = new System.Windows.Forms.TextBox();
            this.priceLable = new System.Windows.Forms.Label();
            this.typeLable = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(197, 105);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(110, 23);
            this.priceText.TabIndex = 0;
            // 
            // typeText
            // 
            this.typeText.Location = new System.Drawing.Point(197, 55);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(110, 23);
            this.typeText.TabIndex = 0;
            // 
            // priceLable
            // 
            this.priceLable.AutoSize = true;
            this.priceLable.Location = new System.Drawing.Point(155, 108);
            this.priceLable.Name = "priceLable";
            this.priceLable.Size = new System.Drawing.Size(36, 15);
            this.priceLable.TabIndex = 1;
            this.priceLable.Text = "Price:";
            // 
            // typeLable
            // 
            this.typeLable.AutoSize = true;
            this.typeLable.Location = new System.Drawing.Point(153, 58);
            this.typeLable.Name = "typeLable";
            this.typeLable.Size = new System.Drawing.Size(34, 15);
            this.typeLable.TabIndex = 1;
            this.typeLable.Text = "Type:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(197, 173);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 329);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.typeLable);
            this.Controls.Add(this.priceLable);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.priceText);
            this.Name = "AddProductWindow";
            this.Text = "AddProductWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox typeText;
        private System.Windows.Forms.Label priceLable;
        private System.Windows.Forms.Label typeLable;
        private System.Windows.Forms.Button addButton;
    }
}
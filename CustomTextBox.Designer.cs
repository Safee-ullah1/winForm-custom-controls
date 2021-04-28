
namespace BasicUserControls
{
    partial class CustomTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxImage = new System.Windows.Forms.PictureBox();
            this.textUnderlinePanel = new System.Windows.Forms.Panel();
            this.myTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxImage
            // 
            this.textBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxImage.Location = new System.Drawing.Point(0, 1);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(37, 36);
            this.textBoxImage.TabIndex = 1;
            this.textBoxImage.TabStop = false;
            // 
            // textUnderlinePanel
            // 
            this.textUnderlinePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUnderlinePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textUnderlinePanel.Location = new System.Drawing.Point(47, 36);
            this.textUnderlinePanel.Name = "textUnderlinePanel";
            this.textUnderlinePanel.Size = new System.Drawing.Size(205, 1);
            this.textUnderlinePanel.TabIndex = 2;
            // 
            // myTextBox
            // 
            this.myTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox.Location = new System.Drawing.Point(47, 13);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(193, 18);
            this.myTextBox.TabIndex = 3;
            this.myTextBox.Enter += new System.EventHandler(this.clearField);
            this.myTextBox.Leave += new System.EventHandler(this.resetField);
            // 
            // CustomTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.myTextBox);
            this.Controls.Add(this.textUnderlinePanel);
            this.Controls.Add(this.textBoxImage);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CustomTextBox";
            this.Size = new System.Drawing.Size(262, 51);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox textBoxImage;
        private System.Windows.Forms.Panel textUnderlinePanel;
        private System.Windows.Forms.TextBox myTextBox;
    }
}

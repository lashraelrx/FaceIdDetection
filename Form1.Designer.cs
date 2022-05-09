
namespace FaceDetection
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
            this.idButton = new System.Windows.Forms.Button();
            this.faceButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.folderBox = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // idButton
            // 
            this.idButton.Location = new System.Drawing.Point(12, 7);
            this.idButton.Name = "idButton";
            this.idButton.Size = new System.Drawing.Size(162, 186);
            this.idButton.TabIndex = 0;
            this.idButton.Text = "ID Detection Mode";
            this.idButton.UseVisualStyleBackColor = true;
            this.idButton.Click += new System.EventHandler(this.idButton_Click);
            // 
            // faceButton
            // 
            this.faceButton.Location = new System.Drawing.Point(12, 205);
            this.faceButton.Name = "faceButton";
            this.faceButton.Size = new System.Drawing.Size(162, 186);
            this.faceButton.TabIndex = 1;
            this.faceButton.Text = "Face Detection Mode";
            this.faceButton.UseVisualStyleBackColor = true;
            this.faceButton.Click += new System.EventHandler(this.faceButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(12, 415);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(110, 23);
            this.folderButton.TabIndex = 2;
            this.folderButton.Text = "Select Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // folderBox
            // 
            this.folderBox.Enabled = false;
            this.folderBox.Location = new System.Drawing.Point(128, 418);
            this.folderBox.Name = "folderBox";
            this.folderBox.Size = new System.Drawing.Size(498, 20);
            this.folderBox.TabIndex = 3;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(180, 12);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(446, 379);
            this.logBox.TabIndex = 4;
            this.logBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.folderBox);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.faceButton);
            this.Controls.Add(this.idButton);
            this.Name = "Form1";
            this.Text = "Jarvis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button idButton;
        private System.Windows.Forms.Button faceButton;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.TextBox folderBox;
        private System.Windows.Forms.RichTextBox logBox;
    }
}


namespace MultithreadingEducationalApp
{
    partial class MainWindow
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
            this.leftCopyButton = new System.Windows.Forms.Button();
            this.leftMoveButton = new System.Windows.Forms.Button();
            this.leftDeleteButton = new System.Windows.Forms.Button();
            this.leftFolderLabel = new System.Windows.Forms.Label();
            this.leftFileBrowserButton = new System.Windows.Forms.Button();
            this.leftFolderName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // leftCopyButton
            // 
            this.leftCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftCopyButton.Location = new System.Drawing.Point(15, 13);
            this.leftCopyButton.Name = "leftCopyButton";
            this.leftCopyButton.Size = new System.Drawing.Size(87, 23);
            this.leftCopyButton.TabIndex = 0;
            this.leftCopyButton.Text = "COPY";
            this.leftCopyButton.UseVisualStyleBackColor = true;
            // 
            // leftMoveButton
            // 
            this.leftMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMoveButton.Location = new System.Drawing.Point(108, 13);
            this.leftMoveButton.Name = "leftMoveButton";
            this.leftMoveButton.Size = new System.Drawing.Size(87, 23);
            this.leftMoveButton.TabIndex = 1;
            this.leftMoveButton.Text = "MOVE";
            this.leftMoveButton.UseVisualStyleBackColor = true;
            // 
            // leftDeleteButton
            // 
            this.leftDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftDeleteButton.Location = new System.Drawing.Point(204, 13);
            this.leftDeleteButton.Name = "leftDeleteButton";
            this.leftDeleteButton.Size = new System.Drawing.Size(87, 23);
            this.leftDeleteButton.TabIndex = 2;
            this.leftDeleteButton.Text = "DELETE";
            this.leftDeleteButton.UseVisualStyleBackColor = true;
            // 
            // leftFolderLabel
            // 
            this.leftFolderLabel.AutoSize = true;
            this.leftFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftFolderLabel.Location = new System.Drawing.Point(12, 39);
            this.leftFolderLabel.Name = "leftFolderLabel";
            this.leftFolderLabel.Size = new System.Drawing.Size(99, 16);
            this.leftFolderLabel.TabIndex = 3;
            this.leftFolderLabel.Text = "Folder name:";
            // 
            // leftFileBrowserButton
            // 
            this.leftFileBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftFileBrowserButton.Location = new System.Drawing.Point(262, 36);
            this.leftFileBrowserButton.Name = "leftFileBrowserButton";
            this.leftFileBrowserButton.Size = new System.Drawing.Size(29, 23);
            this.leftFileBrowserButton.TabIndex = 4;
            this.leftFileBrowserButton.Text = "...";
            this.leftFileBrowserButton.UseVisualStyleBackColor = true;
            this.leftFileBrowserButton.Click += new System.EventHandler(this.leftFileBrowserButton_Click);
            // 
            // leftFolderName
            // 
            this.leftFolderName.AutoSize = true;
            this.leftFolderName.Location = new System.Drawing.Point(117, 41);
            this.leftFolderName.Name = "leftFolderName";
            this.leftFolderName.Size = new System.Drawing.Size(41, 13);
            this.leftFolderName.TabIndex = 5;
            this.leftFolderName.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 277);
            this.listBox1.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 394);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.leftFolderName);
            this.Controls.Add(this.leftFileBrowserButton);
            this.Controls.Add(this.leftFolderLabel);
            this.Controls.Add(this.leftDeleteButton);
            this.Controls.Add(this.leftMoveButton);
            this.Controls.Add(this.leftCopyButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leftCopyButton;
        private System.Windows.Forms.Button leftMoveButton;
        private System.Windows.Forms.Button leftDeleteButton;
        private System.Windows.Forms.Label leftFolderLabel;
        private System.Windows.Forms.Button leftFileBrowserButton;
        private System.Windows.Forms.Label leftFolderName;
        private System.Windows.Forms.ListBox listBox1;
    }
}
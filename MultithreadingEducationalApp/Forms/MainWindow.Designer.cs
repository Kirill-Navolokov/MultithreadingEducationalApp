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
            this.LeftCopyButton = new System.Windows.Forms.Button();
            this.LeftMoveButton = new System.Windows.Forms.Button();
            this.LeftDeleteButton = new System.Windows.Forms.Button();
            this.LeftFolderLabel = new System.Windows.Forms.Label();
            this.LeftFolderBrowserButton = new System.Windows.Forms.Button();
            this.LeftFilesList = new System.Windows.Forms.ListBox();
            this.RightFilesList = new System.Windows.Forms.ListBox();
            this.RightCopyButton = new System.Windows.Forms.Button();
            this.RightMoveButton = new System.Windows.Forms.Button();
            this.RightDeleteButton = new System.Windows.Forms.Button();
            this.RightFolderLabel = new System.Windows.Forms.Label();
            this.RightFolderBrowserButton = new System.Windows.Forms.Button();
            this.LeftFolderName = new System.Windows.Forms.TextBox();
            this.RightFolderName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LeftCopyButton
            // 
            this.LeftCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftCopyButton.Location = new System.Drawing.Point(15, 13);
            this.LeftCopyButton.Name = "LeftCopyButton";
            this.LeftCopyButton.Size = new System.Drawing.Size(87, 23);
            this.LeftCopyButton.TabIndex = 0;
            this.LeftCopyButton.Text = "COPY";
            this.LeftCopyButton.UseVisualStyleBackColor = true;
            this.LeftCopyButton.Click += new System.EventHandler(this.LeftCopyButton_Click);
            // 
            // LeftMoveButton
            // 
            this.LeftMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftMoveButton.Location = new System.Drawing.Point(108, 13);
            this.LeftMoveButton.Name = "LeftMoveButton";
            this.LeftMoveButton.Size = new System.Drawing.Size(87, 23);
            this.LeftMoveButton.TabIndex = 1;
            this.LeftMoveButton.Text = "MOVE";
            this.LeftMoveButton.UseVisualStyleBackColor = true;
            // 
            // LeftDeleteButton
            // 
            this.LeftDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftDeleteButton.Location = new System.Drawing.Point(204, 13);
            this.LeftDeleteButton.Name = "LeftDeleteButton";
            this.LeftDeleteButton.Size = new System.Drawing.Size(87, 23);
            this.LeftDeleteButton.TabIndex = 2;
            this.LeftDeleteButton.Text = "DELETE";
            this.LeftDeleteButton.UseVisualStyleBackColor = true;
            // 
            // LeftFolderLabel
            // 
            this.LeftFolderLabel.AutoSize = true;
            this.LeftFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftFolderLabel.Location = new System.Drawing.Point(12, 39);
            this.LeftFolderLabel.Name = "LeftFolderLabel";
            this.LeftFolderLabel.Size = new System.Drawing.Size(99, 16);
            this.LeftFolderLabel.TabIndex = 3;
            this.LeftFolderLabel.Text = "Folder name:";
            // 
            // LeftFolderBrowserButton
            // 
            this.LeftFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftFolderBrowserButton.Location = new System.Drawing.Point(262, 58);
            this.LeftFolderBrowserButton.Name = "LeftFolderBrowserButton";
            this.LeftFolderBrowserButton.Size = new System.Drawing.Size(29, 23);
            this.LeftFolderBrowserButton.TabIndex = 4;
            this.LeftFolderBrowserButton.Text = "...";
            this.LeftFolderBrowserButton.UseVisualStyleBackColor = true;
            this.LeftFolderBrowserButton.Click += new System.EventHandler(this.LeftFileBrowserButton_Click);
            // 
            // LeftFilesList
            // 
            this.LeftFilesList.FormattingEnabled = true;
            this.LeftFilesList.Location = new System.Drawing.Point(15, 87);
            this.LeftFilesList.Name = "LeftFilesList";
            this.LeftFilesList.Size = new System.Drawing.Size(276, 277);
            this.LeftFilesList.TabIndex = 6;
            // 
            // RightFilesList
            // 
            this.RightFilesList.FormattingEnabled = true;
            this.RightFilesList.Location = new System.Drawing.Point(749, 87);
            this.RightFilesList.Name = "RightFilesList";
            this.RightFilesList.Size = new System.Drawing.Size(276, 277);
            this.RightFilesList.TabIndex = 7;
            // 
            // RightCopyButton
            // 
            this.RightCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightCopyButton.Location = new System.Drawing.Point(749, 13);
            this.RightCopyButton.Name = "RightCopyButton";
            this.RightCopyButton.Size = new System.Drawing.Size(87, 23);
            this.RightCopyButton.TabIndex = 8;
            this.RightCopyButton.Text = "COPY";
            this.RightCopyButton.UseVisualStyleBackColor = true;
            this.RightCopyButton.Click += new System.EventHandler(this.RightCopyButton_Click);
            // 
            // RightMoveButton
            // 
            this.RightMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightMoveButton.Location = new System.Drawing.Point(842, 13);
            this.RightMoveButton.Name = "RightMoveButton";
            this.RightMoveButton.Size = new System.Drawing.Size(87, 23);
            this.RightMoveButton.TabIndex = 9;
            this.RightMoveButton.Text = "MOVE";
            this.RightMoveButton.UseVisualStyleBackColor = true;
            // 
            // RightDeleteButton
            // 
            this.RightDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightDeleteButton.Location = new System.Drawing.Point(935, 13);
            this.RightDeleteButton.Name = "RightDeleteButton";
            this.RightDeleteButton.Size = new System.Drawing.Size(87, 23);
            this.RightDeleteButton.TabIndex = 10;
            this.RightDeleteButton.Text = "DELETE";
            this.RightDeleteButton.UseVisualStyleBackColor = true;
            this.RightDeleteButton.Click += new System.EventHandler(this.RightDeleteButton_Click);
            // 
            // RightFolderLabel
            // 
            this.RightFolderLabel.AutoSize = true;
            this.RightFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightFolderLabel.Location = new System.Drawing.Point(746, 43);
            this.RightFolderLabel.Name = "RightFolderLabel";
            this.RightFolderLabel.Size = new System.Drawing.Size(99, 16);
            this.RightFolderLabel.TabIndex = 11;
            this.RightFolderLabel.Text = "Folder name:";
            // 
            // RightFolderBrowserButton
            // 
            this.RightFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightFolderBrowserButton.Location = new System.Drawing.Point(993, 58);
            this.RightFolderBrowserButton.Name = "RightFolderBrowserButton";
            this.RightFolderBrowserButton.Size = new System.Drawing.Size(29, 23);
            this.RightFolderBrowserButton.TabIndex = 13;
            this.RightFolderBrowserButton.Text = "...";
            this.RightFolderBrowserButton.UseVisualStyleBackColor = true;
            this.RightFolderBrowserButton.Click += new System.EventHandler(this.RightFolderBrowserButton_Click);
            // 
            // LeftFolderName
            // 
            this.LeftFolderName.Location = new System.Drawing.Point(117, 38);
            this.LeftFolderName.Name = "LeftFolderName";
            this.LeftFolderName.ReadOnly = true;
            this.LeftFolderName.Size = new System.Drawing.Size(174, 20);
            this.LeftFolderName.TabIndex = 14;
            // 
            // RightFolderName
            // 
            this.RightFolderName.Location = new System.Drawing.Point(851, 38);
            this.RightFolderName.Name = "RightFolderName";
            this.RightFolderName.ReadOnly = true;
            this.RightFolderName.Size = new System.Drawing.Size(171, 20);
            this.RightFolderName.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 394);
            this.Controls.Add(this.RightFolderName);
            this.Controls.Add(this.LeftFolderName);
            this.Controls.Add(this.RightFolderBrowserButton);
            this.Controls.Add(this.RightFolderLabel);
            this.Controls.Add(this.RightDeleteButton);
            this.Controls.Add(this.RightMoveButton);
            this.Controls.Add(this.RightCopyButton);
            this.Controls.Add(this.RightFilesList);
            this.Controls.Add(this.LeftFilesList);
            this.Controls.Add(this.LeftFolderBrowserButton);
            this.Controls.Add(this.LeftFolderLabel);
            this.Controls.Add(this.LeftDeleteButton);
            this.Controls.Add(this.LeftMoveButton);
            this.Controls.Add(this.LeftCopyButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LeftCopyButton;
        private System.Windows.Forms.Button LeftMoveButton;
        private System.Windows.Forms.Button LeftDeleteButton;
        private System.Windows.Forms.Label LeftFolderLabel;
        private System.Windows.Forms.Button LeftFolderBrowserButton;
        private System.Windows.Forms.ListBox LeftFilesList;
        private System.Windows.Forms.ListBox RightFilesList;
        private System.Windows.Forms.Button RightCopyButton;
        private System.Windows.Forms.Button RightMoveButton;
        private System.Windows.Forms.Button RightDeleteButton;
        private System.Windows.Forms.Label RightFolderLabel;
        private System.Windows.Forms.Button RightFolderBrowserButton;
        private System.Windows.Forms.TextBox LeftFolderName;
        private System.Windows.Forms.TextBox RightFolderName;
    }
}
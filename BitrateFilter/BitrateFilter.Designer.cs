namespace BitrateFilter
{
    partial class BitrateFilter
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
            this.musicDirButton = new System.Windows.Forms.Button();
            this.musicDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.filteredFilesTreeView = new System.Windows.Forms.TreeView();
            this.musicDirLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lessThanRadioButton = new System.Windows.Forms.RadioButton();
            this.greaterThanRadioButton = new System.Windows.Forms.RadioButton();
            this.processButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.filetypeComboBox = new System.Windows.Forms.ComboBox();
            this.filetypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // musicDirButton
            // 
            this.musicDirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicDirButton.Location = new System.Drawing.Point(22, 12);
            this.musicDirButton.Name = "musicDirButton";
            this.musicDirButton.Size = new System.Drawing.Size(110, 30);
            this.musicDirButton.TabIndex = 0;
            this.musicDirButton.Text = "Choose Directory";
            this.musicDirButton.UseVisualStyleBackColor = true;
            this.musicDirButton.Click += new System.EventHandler(this.musicDirButton_Click);
            // 
            // filteredFilesTreeView
            // 
            this.filteredFilesTreeView.Location = new System.Drawing.Point(197, 12);
            this.filteredFilesTreeView.Name = "filteredFilesTreeView";
            this.filteredFilesTreeView.Size = new System.Drawing.Size(529, 346);
            this.filteredFilesTreeView.TabIndex = 1;
            // 
            // musicDirLabel
            // 
            this.musicDirLabel.AutoSize = true;
            this.musicDirLabel.Location = new System.Drawing.Point(19, 45);
            this.musicDirLabel.Name = "musicDirLabel";
            this.musicDirLabel.Size = new System.Drawing.Size(33, 13);
            this.musicDirLabel.TabIndex = 2;
            this.musicDirLabel.Text = "None";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "192";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bitrate";
            // 
            // lessThanRadioButton
            // 
            this.lessThanRadioButton.AutoSize = true;
            this.lessThanRadioButton.Checked = true;
            this.lessThanRadioButton.Location = new System.Drawing.Point(22, 122);
            this.lessThanRadioButton.Name = "lessThanRadioButton";
            this.lessThanRadioButton.Size = new System.Drawing.Size(75, 17);
            this.lessThanRadioButton.TabIndex = 5;
            this.lessThanRadioButton.TabStop = true;
            this.lessThanRadioButton.Text = "Less Than";
            this.lessThanRadioButton.UseVisualStyleBackColor = true;
            // 
            // greaterThanRadioButton
            // 
            this.greaterThanRadioButton.AutoSize = true;
            this.greaterThanRadioButton.Location = new System.Drawing.Point(103, 122);
            this.greaterThanRadioButton.Name = "greaterThanRadioButton";
            this.greaterThanRadioButton.Size = new System.Drawing.Size(88, 17);
            this.greaterThanRadioButton.TabIndex = 6;
            this.greaterThanRadioButton.TabStop = true;
            this.greaterThanRadioButton.Text = "Greater Than";
            this.greaterThanRadioButton.UseVisualStyleBackColor = true;
            // 
            // processButton
            // 
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.Location = new System.Drawing.Point(22, 299);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 30);
            this.processButton.TabIndex = 7;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 335);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(169, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // filetypeComboBox
            // 
            this.filetypeComboBox.FormattingEnabled = true;
            this.filetypeComboBox.Items.AddRange(new object[] {
            "mp3"});
            this.filetypeComboBox.Location = new System.Drawing.Point(22, 180);
            this.filetypeComboBox.Name = "filetypeComboBox";
            this.filetypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.filetypeComboBox.TabIndex = 9;
            // 
            // filetypeLabel
            // 
            this.filetypeLabel.AutoSize = true;
            this.filetypeLabel.Location = new System.Drawing.Point(19, 164);
            this.filetypeLabel.Name = "filetypeLabel";
            this.filetypeLabel.Size = new System.Drawing.Size(43, 13);
            this.filetypeLabel.TabIndex = 10;
            this.filetypeLabel.Text = "Filetype";
            // 
            // BitrateFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 370);
            this.Controls.Add(this.filetypeLabel);
            this.Controls.Add(this.filetypeComboBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.greaterThanRadioButton);
            this.Controls.Add(this.lessThanRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.musicDirLabel);
            this.Controls.Add(this.filteredFilesTreeView);
            this.Controls.Add(this.musicDirButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BitrateFilter";
            this.Text = "Bitrate Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button musicDirButton;
        private System.Windows.Forms.FolderBrowserDialog musicDirDialog;
        private System.Windows.Forms.TreeView filteredFilesTreeView;
        private System.Windows.Forms.Label musicDirLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton lessThanRadioButton;
        private System.Windows.Forms.RadioButton greaterThanRadioButton;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox filetypeComboBox;
        private System.Windows.Forms.Label filetypeLabel;

    }
}


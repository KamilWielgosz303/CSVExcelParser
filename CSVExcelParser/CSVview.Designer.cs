namespace CSVExcelParser
{
    partial class CSVExcelParser
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
            this.Fade = new System.Windows.Forms.Label();
            this.Clearity = new System.Windows.Forms.Label();
            this.FadeInput = new System.Windows.Forms.TextBox();
            this.ClearityInput = new System.Windows.Forms.TextBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.revertXCheckBox = new System.Windows.Forms.CheckBox();
            this.changeCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxRange = new System.Windows.Forms.TextBox();
            this.revertYCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SortedXRadioBox = new System.Windows.Forms.RadioButton();
            this.SortedYRadioBox = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fade
            // 
            this.Fade.AutoSize = true;
            this.Fade.Location = new System.Drawing.Point(13, 13);
            this.Fade.Name = "Fade";
            this.Fade.Size = new System.Drawing.Size(32, 15);
            this.Fade.TabIndex = 0;
            this.Fade.Text = "Fade";
            // 
            // Clearity
            // 
            this.Clearity.AutoSize = true;
            this.Clearity.Location = new System.Drawing.Point(124, 14);
            this.Clearity.Name = "Clearity";
            this.Clearity.Size = new System.Drawing.Size(59, 15);
            this.Clearity.TabIndex = 1;
            this.Clearity.Text = "Clearance";
            // 
            // FadeInput
            // 
            this.FadeInput.Enabled = false;
            this.FadeInput.Location = new System.Drawing.Point(13, 32);
            this.FadeInput.Name = "FadeInput";
            this.FadeInput.Size = new System.Drawing.Size(105, 23);
            this.FadeInput.TabIndex = 2;
            this.FadeInput.Text = "N";
            // 
            // ClearityInput
            // 
            this.ClearityInput.Enabled = false;
            this.ClearityInput.Location = new System.Drawing.Point(124, 32);
            this.ClearityInput.Name = "ClearityInput";
            this.ClearityInput.Size = new System.Drawing.Size(102, 23);
            this.ClearityInput.TabIndex = 3;
            this.ClearityInput.Text = "60";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(41, 202);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 4;
            this.BtnLoad.Text = "Wczytaj";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(13, 170);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(103, 15);
            this.FileNameLabel.TabIndex = 6;
            this.FileNameLabel.Text = "Plik: Nie wczytano";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(124, 202);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 23);
            this.ProgressBar.TabIndex = 7;
            this.ProgressBar.Visible = false;
            // 
            // revertXCheckBox
            // 
            this.revertXCheckBox.AutoSize = true;
            this.revertXCheckBox.Location = new System.Drawing.Point(13, 72);
            this.revertXCheckBox.Name = "revertXCheckBox";
            this.revertXCheckBox.Size = new System.Drawing.Size(93, 19);
            this.revertXCheckBox.TabIndex = 10;
            this.revertXCheckBox.Text = "Odwróć oś X";
            this.revertXCheckBox.UseVisualStyleBackColor = true;
            // 
            // changeCheckBox
            // 
            this.changeCheckBox.AutoSize = true;
            this.changeCheckBox.Location = new System.Drawing.Point(232, 72);
            this.changeCheckBox.Name = "changeCheckBox";
            this.changeCheckBox.Size = new System.Drawing.Size(112, 19);
            this.changeCheckBox.TabIndex = 11;
            this.changeCheckBox.Text = "Zamień osie X/Y";
            this.changeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Długośc stołu:";
            // 
            // maxRange
            // 
            this.maxRange.Enabled = false;
            this.maxRange.Location = new System.Drawing.Point(232, 32);
            this.maxRange.Name = "maxRange";
            this.maxRange.Size = new System.Drawing.Size(100, 23);
            this.maxRange.TabIndex = 13;
            this.maxRange.Text = "0";
            // 
            // revertYCheckBox
            // 
            this.revertYCheckBox.AutoSize = true;
            this.revertYCheckBox.Location = new System.Drawing.Point(124, 72);
            this.revertYCheckBox.Name = "revertYCheckBox";
            this.revertYCheckBox.Size = new System.Drawing.Size(93, 19);
            this.revertYCheckBox.TabIndex = 14;
            this.revertYCheckBox.Text = "Odwróć oś Y";
            this.revertYCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kolumna uporządkowana:";
            // 
            // SortedXRadioBox
            // 
            this.SortedXRadioBox.AutoSize = true;
            this.SortedXRadioBox.Checked = true;
            this.SortedXRadioBox.Location = new System.Drawing.Point(13, 136);
            this.SortedXRadioBox.Name = "SortedXRadioBox";
            this.SortedXRadioBox.Size = new System.Drawing.Size(49, 19);
            this.SortedXRadioBox.TabIndex = 16;
            this.SortedXRadioBox.TabStop = true;
            this.SortedXRadioBox.Text = "Oś X";
            this.SortedXRadioBox.UseVisualStyleBackColor = true;
            // 
            // SortedYRadioBox
            // 
            this.SortedYRadioBox.AutoSize = true;
            this.SortedYRadioBox.Location = new System.Drawing.Point(124, 136);
            this.SortedYRadioBox.Name = "SortedYRadioBox";
            this.SortedYRadioBox.Size = new System.Drawing.Size(49, 19);
            this.SortedYRadioBox.TabIndex = 17;
            this.SortedYRadioBox.Text = "Oś Y";
            this.SortedYRadioBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Parsuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnParser_Click);
            // 
            // CSVExcelParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(346, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SortedYRadioBox);
            this.Controls.Add(this.SortedXRadioBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.revertYCheckBox);
            this.Controls.Add(this.maxRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeCheckBox);
            this.Controls.Add(this.revertXCheckBox);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.ClearityInput);
            this.Controls.Add(this.FadeInput);
            this.Controls.Add(this.Clearity);
            this.Controls.Add(this.Fade);
            this.Name = "CSVExcelParser";
            this.Text = "CSV/CNC Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fade;
        private System.Windows.Forms.Label Clearity;
        private System.Windows.Forms.TextBox FadeInput;
        private System.Windows.Forms.TextBox ClearityInput;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.CheckBox revertXCheckBox;
        private System.Windows.Forms.CheckBox changeCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxRange;
        private System.Windows.Forms.CheckBox revertYCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton SortedXRadioBox;
        private System.Windows.Forms.RadioButton SortedYRadioBox;
        private System.Windows.Forms.Button button1;
    }
}


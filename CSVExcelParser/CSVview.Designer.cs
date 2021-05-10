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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSVExcelParser));
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
            resources.ApplyResources(this.Fade, "Fade");
            this.Fade.Name = "Fade";
            // 
            // Clearity
            // 
            resources.ApplyResources(this.Clearity, "Clearity");
            this.Clearity.Name = "Clearity";
            // 
            // FadeInput
            // 
            resources.ApplyResources(this.FadeInput, "FadeInput");
            this.FadeInput.Name = "FadeInput";
            // 
            // ClearityInput
            // 
            resources.ApplyResources(this.ClearityInput, "ClearityInput");
            this.ClearityInput.Name = "ClearityInput";
            // 
            // BtnLoad
            // 
            resources.ApplyResources(this.BtnLoad, "BtnLoad");
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // FileNameLabel
            // 
            resources.ApplyResources(this.FileNameLabel, "FileNameLabel");
            this.FileNameLabel.Name = "FileNameLabel";
            // 
            // ProgressBar
            // 
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.Name = "ProgressBar";
            // 
            // revertXCheckBox
            // 
            resources.ApplyResources(this.revertXCheckBox, "revertXCheckBox");
            this.revertXCheckBox.Name = "revertXCheckBox";
            this.revertXCheckBox.UseVisualStyleBackColor = true;
            // 
            // changeCheckBox
            // 
            resources.ApplyResources(this.changeCheckBox, "changeCheckBox");
            this.changeCheckBox.Name = "changeCheckBox";
            this.changeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // maxRange
            // 
            resources.ApplyResources(this.maxRange, "maxRange");
            this.maxRange.Name = "maxRange";
            // 
            // revertYCheckBox
            // 
            resources.ApplyResources(this.revertYCheckBox, "revertYCheckBox");
            this.revertYCheckBox.Name = "revertYCheckBox";
            this.revertYCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // SortedXRadioBox
            // 
            resources.ApplyResources(this.SortedXRadioBox, "SortedXRadioBox");
            this.SortedXRadioBox.Checked = true;
            this.SortedXRadioBox.Name = "SortedXRadioBox";
            this.SortedXRadioBox.TabStop = true;
            this.SortedXRadioBox.UseVisualStyleBackColor = true;
            // 
            // SortedYRadioBox
            // 
            resources.ApplyResources(this.SortedYRadioBox, "SortedYRadioBox");
            this.SortedYRadioBox.Name = "SortedYRadioBox";
            this.SortedYRadioBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnParser_Click);
            // 
            // CSVExcelParser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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


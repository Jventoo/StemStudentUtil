namespace StemStudentUtil
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.unitConverterPage = new System.Windows.Forms.TabPage();
            this.baseConverterPage = new System.Windows.Forms.TabPage();
            this.formulasPage = new System.Windows.Forms.TabPage();
            this.baseInputLabel = new System.Windows.Forms.Label();
            this.baseInputTextbox = new System.Windows.Forms.TextBox();
            this.baseOutputLabel = new System.Windows.Forms.Label();
            this.baseOutputTextbox = new System.Windows.Forms.TextBox();
            this.baseDropdownLabel = new System.Windows.Forms.Label();
            this.baseDropdownLabel_Out = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.baseInputDropdown = new System.Windows.Forms.ComboBox();
            this.outputBaseDropdown = new System.Windows.Forms.ComboBox();
            this.baseInputCheckBox = new System.Windows.Forms.CheckBox();
            this.customInputBase = new System.Windows.Forms.TextBox();
            this.customOutputBase = new System.Windows.Forms.TextBox();
            this.baseOutputCheckBox = new System.Windows.Forms.CheckBox();
            this.baseConvertButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.baseConverterPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.unitConverterPage);
            this.tabControl.Controls.Add(this.baseConverterPage);
            this.tabControl.Controls.Add(this.formulasPage);
            this.tabControl.ItemSize = new System.Drawing.Size(81, 30);
            this.tabControl.Location = new System.Drawing.Point(6, 23);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 509);
            this.tabControl.TabIndex = 0;
            // 
            // unitConverterPage
            // 
            this.unitConverterPage.Location = new System.Drawing.Point(4, 34);
            this.unitConverterPage.Name = "unitConverterPage";
            this.unitConverterPage.Padding = new System.Windows.Forms.Padding(3);
            this.unitConverterPage.Size = new System.Drawing.Size(752, 471);
            this.unitConverterPage.TabIndex = 0;
            this.unitConverterPage.Text = "Unit Converter";
            this.unitConverterPage.UseVisualStyleBackColor = true;
            // 
            // baseConverterPage
            // 
            this.baseConverterPage.Controls.Add(this.baseConvertButton);
            this.baseConverterPage.Controls.Add(this.customOutputBase);
            this.baseConverterPage.Controls.Add(this.baseOutputCheckBox);
            this.baseConverterPage.Controls.Add(this.customInputBase);
            this.baseConverterPage.Controls.Add(this.baseInputCheckBox);
            this.baseConverterPage.Controls.Add(this.outputBaseDropdown);
            this.baseConverterPage.Controls.Add(this.baseInputDropdown);
            this.baseConverterPage.Controls.Add(this.baseDropdownLabel_Out);
            this.baseConverterPage.Controls.Add(this.baseDropdownLabel);
            this.baseConverterPage.Controls.Add(this.baseOutputTextbox);
            this.baseConverterPage.Controls.Add(this.baseOutputLabel);
            this.baseConverterPage.Controls.Add(this.baseInputTextbox);
            this.baseConverterPage.Controls.Add(this.baseInputLabel);
            this.baseConverterPage.Location = new System.Drawing.Point(4, 34);
            this.baseConverterPage.Name = "baseConverterPage";
            this.baseConverterPage.Padding = new System.Windows.Forms.Padding(3);
            this.baseConverterPage.Size = new System.Drawing.Size(752, 471);
            this.baseConverterPage.TabIndex = 1;
            this.baseConverterPage.Text = "Base Converter";
            this.baseConverterPage.UseVisualStyleBackColor = true;
            // 
            // formulasPage
            // 
            this.formulasPage.Location = new System.Drawing.Point(4, 34);
            this.formulasPage.Name = "formulasPage";
            this.formulasPage.Padding = new System.Windows.Forms.Padding(3);
            this.formulasPage.Size = new System.Drawing.Size(752, 471);
            this.formulasPage.TabIndex = 2;
            this.formulasPage.Text = "Formulas Calculator";
            this.formulasPage.UseVisualStyleBackColor = true;
            // 
            // baseInputLabel
            // 
            this.baseInputLabel.AutoSize = true;
            this.baseInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseInputLabel.Location = new System.Drawing.Point(27, 55);
            this.baseInputLabel.Name = "baseInputLabel";
            this.baseInputLabel.Size = new System.Drawing.Size(71, 29);
            this.baseInputLabel.TabIndex = 0;
            this.baseInputLabel.Text = "Input:";
            // 
            // baseInputTextbox
            // 
            this.baseInputTextbox.Location = new System.Drawing.Point(116, 53);
            this.baseInputTextbox.Name = "baseInputTextbox";
            this.baseInputTextbox.Size = new System.Drawing.Size(173, 26);
            this.baseInputTextbox.TabIndex = 1;
            this.baseInputTextbox.TextChanged += new System.EventHandler(this.baseInput_TextChanged);
            // 
            // baseOutputLabel
            // 
            this.baseOutputLabel.AutoSize = true;
            this.baseOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseOutputLabel.Location = new System.Drawing.Point(15, 192);
            this.baseOutputLabel.Name = "baseOutputLabel";
            this.baseOutputLabel.Size = new System.Drawing.Size(90, 29);
            this.baseOutputLabel.TabIndex = 2;
            this.baseOutputLabel.Text = "Output:";
            // 
            // baseOutputTextbox
            // 
            this.baseOutputTextbox.Location = new System.Drawing.Point(116, 195);
            this.baseOutputTextbox.Multiline = true;
            this.baseOutputTextbox.Name = "baseOutputTextbox";
            this.baseOutputTextbox.ReadOnly = true;
            this.baseOutputTextbox.Size = new System.Drawing.Size(173, 26);
            this.baseOutputTextbox.TabIndex = 3;
            // 
            // baseDropdownLabel
            // 
            this.baseDropdownLabel.AutoSize = true;
            this.baseDropdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDropdownLabel.Location = new System.Drawing.Point(420, 55);
            this.baseDropdownLabel.Name = "baseDropdownLabel";
            this.baseDropdownLabel.Size = new System.Drawing.Size(132, 29);
            this.baseDropdownLabel.TabIndex = 4;
            this.baseDropdownLabel.Text = "Input Base:";
            // 
            // baseDropdownLabel_Out
            // 
            this.baseDropdownLabel_Out.AutoSize = true;
            this.baseDropdownLabel_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDropdownLabel_Out.Location = new System.Drawing.Point(408, 192);
            this.baseDropdownLabel_Out.Name = "baseDropdownLabel_Out";
            this.baseDropdownLabel_Out.Size = new System.Drawing.Size(151, 29);
            this.baseDropdownLabel_Out.TabIndex = 5;
            this.baseDropdownLabel_Out.Text = "Output Base:";
            // 
            // baseInputDropdown
            // 
            this.baseInputDropdown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.baseInputDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baseInputDropdown.FormattingEnabled = true;
            this.baseInputDropdown.Items.AddRange(new object[] {
            "Decimal",
            "Binary",
            "Hexadecimal",
            "Octal"});
            this.baseInputDropdown.Location = new System.Drawing.Point(573, 53);
            this.baseInputDropdown.Name = "baseInputDropdown";
            this.baseInputDropdown.Size = new System.Drawing.Size(152, 28);
            this.baseInputDropdown.TabIndex = 6;
            this.baseInputDropdown.SelectedIndexChanged += new System.EventHandler(this.baseInputDropdown_SelectedIndexChanged);
            // 
            // outputBaseDropdown
            // 
            this.outputBaseDropdown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outputBaseDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputBaseDropdown.FormattingEnabled = true;
            this.outputBaseDropdown.Items.AddRange(new object[] {
            "Decimal",
            "Binary",
            "Hexadecimal",
            "Octal"});
            this.outputBaseDropdown.Location = new System.Drawing.Point(573, 193);
            this.outputBaseDropdown.Name = "outputBaseDropdown";
            this.outputBaseDropdown.Size = new System.Drawing.Size(152, 28);
            this.outputBaseDropdown.TabIndex = 7;
            this.outputBaseDropdown.SelectedIndexChanged += new System.EventHandler(this.baseOutputDropdown_SelectedIndexChanged);
            // 
            // baseInputCheckBox
            // 
            this.baseInputCheckBox.AutoSize = true;
            this.baseInputCheckBox.Location = new System.Drawing.Point(484, 101);
            this.baseInputCheckBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.baseInputCheckBox.Name = "baseInputCheckBox";
            this.baseInputCheckBox.Size = new System.Drawing.Size(135, 24);
            this.baseInputCheckBox.TabIndex = 8;
            this.baseInputCheckBox.Text = "Custom Base:";
            this.baseInputCheckBox.UseVisualStyleBackColor = true;
            this.baseInputCheckBox.CheckedChanged += new System.EventHandler(this.baseCustomInput_CheckedChanged);
            // 
            // customInputBase
            // 
            this.customInputBase.Enabled = false;
            this.customInputBase.Location = new System.Drawing.Point(625, 98);
            this.customInputBase.Name = "customInputBase";
            this.customInputBase.Size = new System.Drawing.Size(28, 26);
            this.customInputBase.TabIndex = 9;
            this.customInputBase.TextChanged += new System.EventHandler(this.baseCustomInput_TextChanged);
            // 
            // customOutputBase
            // 
            this.customOutputBase.Enabled = false;
            this.customOutputBase.Location = new System.Drawing.Point(625, 237);
            this.customOutputBase.Name = "customOutputBase";
            this.customOutputBase.Size = new System.Drawing.Size(28, 26);
            this.customOutputBase.TabIndex = 11;
            this.customOutputBase.TextChanged += new System.EventHandler(this.baseCustomOutput_TextChanged);
            // 
            // baseOutputCheckBox
            // 
            this.baseOutputCheckBox.AutoSize = true;
            this.baseOutputCheckBox.Location = new System.Drawing.Point(484, 240);
            this.baseOutputCheckBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.baseOutputCheckBox.Name = "baseOutputCheckBox";
            this.baseOutputCheckBox.Size = new System.Drawing.Size(135, 24);
            this.baseOutputCheckBox.TabIndex = 10;
            this.baseOutputCheckBox.Text = "Custom Base:";
            this.baseOutputCheckBox.UseVisualStyleBackColor = true;
            this.baseOutputCheckBox.CheckedChanged += new System.EventHandler(this.baseCustomOutput_CheckedChanged);
            // 
            // baseConvertButton
            // 
            this.baseConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseConvertButton.Location = new System.Drawing.Point(307, 319);
            this.baseConvertButton.Name = "baseConvertButton";
            this.baseConvertButton.Size = new System.Drawing.Size(136, 47);
            this.baseConvertButton.TabIndex = 12;
            this.baseConvertButton.Text = "CONVERT";
            this.baseConvertButton.UseVisualStyleBackColor = true;
            this.baseConvertButton.Click += new System.EventHandler(this.baseConvertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "STEM Student Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.baseConverterPage.ResumeLayout(false);
            this.baseConverterPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage unitConverterPage;
        private System.Windows.Forms.TabPage baseConverterPage;
        private System.Windows.Forms.TabPage formulasPage;
        private System.Windows.Forms.Label baseOutputLabel;
        private System.Windows.Forms.TextBox baseInputTextbox;
        private System.Windows.Forms.Label baseInputLabel;
        private System.Windows.Forms.TextBox baseOutputTextbox;
        private System.Windows.Forms.Label baseDropdownLabel_Out;
        private System.Windows.Forms.Label baseDropdownLabel;
        private System.Windows.Forms.ComboBox outputBaseDropdown;
        private System.Windows.Forms.ComboBox baseInputDropdown;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox customInputBase;
        private System.Windows.Forms.CheckBox baseInputCheckBox;
        private System.Windows.Forms.TextBox customOutputBase;
        private System.Windows.Forms.CheckBox baseOutputCheckBox;
        private System.Windows.Forms.Button baseConvertButton;
    }
}


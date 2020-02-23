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
            this.unitPowerDropdown_output = new System.Windows.Forms.ComboBox();
            this.unitPowerDropdown_input = new System.Windows.Forms.ComboBox();
            this.unitInput = new System.Windows.Forms.TextBox();
            this.unitOutput = new System.Windows.Forms.TextBox();
            this.unit_eq_label = new System.Windows.Forms.Label();
            this.unitChoiceDropdown = new System.Windows.Forms.ComboBox();
            this.unitOutputDropdown = new System.Windows.Forms.ComboBox();
            this.unitInputDropdown = new System.Windows.Forms.ComboBox();
            this.baseConverterPage = new System.Windows.Forms.TabPage();
            this.baseConvertButton = new System.Windows.Forms.Button();
            this.customOutputBase = new System.Windows.Forms.TextBox();
            this.baseOutputCheckBox = new System.Windows.Forms.CheckBox();
            this.customInputBase = new System.Windows.Forms.TextBox();
            this.baseInputCheckBox = new System.Windows.Forms.CheckBox();
            this.outputBaseDropdown = new System.Windows.Forms.ComboBox();
            this.baseInputDropdown = new System.Windows.Forms.ComboBox();
            this.baseDropdownLabel_Out = new System.Windows.Forms.Label();
            this.baseDropdownLabel = new System.Windows.Forms.Label();
            this.baseOutputTextbox = new System.Windows.Forms.TextBox();
            this.baseOutputLabel = new System.Windows.Forms.Label();
            this.baseInputTextbox = new System.Windows.Forms.TextBox();
            this.baseInputLabel = new System.Windows.Forms.Label();
            this.formulasPage = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.unitConverterPage.SuspendLayout();
            this.baseConverterPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.unitConverterPage);
            this.tabControl.Controls.Add(this.baseConverterPage);
            this.tabControl.Controls.Add(this.formulasPage);
            this.tabControl.ItemSize = new System.Drawing.Size(81, 30);
            this.tabControl.Location = new System.Drawing.Point(4, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(507, 331);
            this.tabControl.TabIndex = 0;
            // 
            // unitConverterPage
            // 
            this.unitConverterPage.Controls.Add(this.unitPowerDropdown_output);
            this.unitConverterPage.Controls.Add(this.unitPowerDropdown_input);
            this.unitConverterPage.Controls.Add(this.unitInput);
            this.unitConverterPage.Controls.Add(this.unitOutput);
            this.unitConverterPage.Controls.Add(this.unit_eq_label);
            this.unitConverterPage.Controls.Add(this.unitChoiceDropdown);
            this.unitConverterPage.Controls.Add(this.unitOutputDropdown);
            this.unitConverterPage.Controls.Add(this.unitInputDropdown);
            this.unitConverterPage.Location = new System.Drawing.Point(4, 34);
            this.unitConverterPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitConverterPage.Name = "unitConverterPage";
            this.unitConverterPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitConverterPage.Size = new System.Drawing.Size(499, 293);
            this.unitConverterPage.TabIndex = 0;
            this.unitConverterPage.Text = "Unit Converter";
            this.unitConverterPage.UseVisualStyleBackColor = true;
            // 
            // unitPowerDropdown_output
            // 
            this.unitPowerDropdown_output.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitPowerDropdown_output.FormattingEnabled = true;
            this.unitPowerDropdown_output.Location = new System.Drawing.Point(366, 100);
            this.unitPowerDropdown_output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitPowerDropdown_output.Name = "unitPowerDropdown_output";
            this.unitPowerDropdown_output.Size = new System.Drawing.Size(73, 21);
            this.unitPowerDropdown_output.TabIndex = 6;
            // 
            // unitPowerDropdown_input
            // 
            this.unitPowerDropdown_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitPowerDropdown_input.FormattingEnabled = true;
            this.unitPowerDropdown_input.Location = new System.Drawing.Point(150, 100);
            this.unitPowerDropdown_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitPowerDropdown_input.Name = "unitPowerDropdown_input";
            this.unitPowerDropdown_input.Size = new System.Drawing.Size(73, 21);
            this.unitPowerDropdown_input.TabIndex = 4;
            // 
            // unitInput
            // 
            this.unitInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitInput.Location = new System.Drawing.Point(48, 64);
            this.unitInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitInput.Name = "unitInput";
            this.unitInput.Size = new System.Drawing.Size(175, 38);
            this.unitInput.TabIndex = 1;
            this.unitInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unitOutput
            // 
            this.unitOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitOutput.Location = new System.Drawing.Point(264, 64);
            this.unitOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitOutput.Name = "unitOutput";
            this.unitOutput.Size = new System.Drawing.Size(175, 38);
            this.unitOutput.TabIndex = 2;
            this.unitOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unit_eq_label
            // 
            this.unit_eq_label.AutoSize = true;
            this.unit_eq_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_eq_label.Location = new System.Drawing.Point(233, 71);
            this.unit_eq_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unit_eq_label.Name = "unit_eq_label";
            this.unit_eq_label.Size = new System.Drawing.Size(24, 25);
            this.unit_eq_label.TabIndex = 7;
            this.unit_eq_label.Text = "=";
            // 
            // unitChoiceDropdown
            // 
            this.unitChoiceDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitChoiceDropdown.FormattingEnabled = true;
            this.unitChoiceDropdown.Items.AddRange(new object[] {
            "Data",
            "Energy",
            "Length",
            "Mass",
            "Temperature",
            "Time",
            "Other"});
            this.unitChoiceDropdown.Location = new System.Drawing.Point(48, 21);
            this.unitChoiceDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitChoiceDropdown.Name = "unitChoiceDropdown";
            this.unitChoiceDropdown.Size = new System.Drawing.Size(391, 21);
            this.unitChoiceDropdown.TabIndex = 0;
            this.unitChoiceDropdown.SelectedIndexChanged += new System.EventHandler(this.unitChoiceDropdown_SelectedIndexChanged);
            // 
            // unitOutputDropdown
            // 
            this.unitOutputDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitOutputDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitOutputDropdown.FormattingEnabled = true;
            this.unitOutputDropdown.Location = new System.Drawing.Point(264, 100);
            this.unitOutputDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitOutputDropdown.Name = "unitOutputDropdown";
            this.unitOutputDropdown.Size = new System.Drawing.Size(102, 24);
            this.unitOutputDropdown.TabIndex = 5;
            // 
            // unitInputDropdown
            // 
            this.unitInputDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitInputDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitInputDropdown.FormattingEnabled = true;
            this.unitInputDropdown.Location = new System.Drawing.Point(48, 100);
            this.unitInputDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitInputDropdown.Name = "unitInputDropdown";
            this.unitInputDropdown.Size = new System.Drawing.Size(102, 24);
            this.unitInputDropdown.TabIndex = 3;
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
            this.baseConverterPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baseConverterPage.Name = "baseConverterPage";
            this.baseConverterPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baseConverterPage.Size = new System.Drawing.Size(499, 293);
            this.baseConverterPage.TabIndex = 1;
            this.baseConverterPage.Text = "Base Converter";
            this.baseConverterPage.UseVisualStyleBackColor = true;
            // 
            // baseConvertButton
            // 
            this.baseConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseConvertButton.Location = new System.Drawing.Point(205, 207);
            this.baseConvertButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baseConvertButton.Name = "baseConvertButton";
            this.baseConvertButton.Size = new System.Drawing.Size(91, 31);
            this.baseConvertButton.TabIndex = 12;
            this.baseConvertButton.Text = "CONVERT";
            this.baseConvertButton.UseVisualStyleBackColor = true;
            this.baseConvertButton.Click += new System.EventHandler(this.baseConvertButton_Click);
            // 
            // customOutputBase
            // 
            this.customOutputBase.Enabled = false;
            this.customOutputBase.Location = new System.Drawing.Point(417, 154);
            this.customOutputBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customOutputBase.Name = "customOutputBase";
            this.customOutputBase.Size = new System.Drawing.Size(20, 20);
            this.customOutputBase.TabIndex = 11;
            this.customOutputBase.TextChanged += new System.EventHandler(this.baseCustomOutput_TextChanged);
            // 
            // baseOutputCheckBox
            // 
            this.baseOutputCheckBox.AutoSize = true;
            this.baseOutputCheckBox.Location = new System.Drawing.Point(323, 156);
            this.baseOutputCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.baseOutputCheckBox.Name = "baseOutputCheckBox";
            this.baseOutputCheckBox.Size = new System.Drawing.Size(91, 17);
            this.baseOutputCheckBox.TabIndex = 10;
            this.baseOutputCheckBox.Text = "Custom Base:";
            this.baseOutputCheckBox.UseVisualStyleBackColor = true;
            this.baseOutputCheckBox.CheckedChanged += new System.EventHandler(this.baseCustomOutput_CheckedChanged);
            // 
            // customInputBase
            // 
            this.customInputBase.Enabled = false;
            this.customInputBase.Location = new System.Drawing.Point(417, 64);
            this.customInputBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customInputBase.Name = "customInputBase";
            this.customInputBase.Size = new System.Drawing.Size(20, 20);
            this.customInputBase.TabIndex = 7;
            this.customInputBase.TextChanged += new System.EventHandler(this.baseCustomInput_TextChanged);
            // 
            // baseInputCheckBox
            // 
            this.baseInputCheckBox.AutoSize = true;
            this.baseInputCheckBox.Location = new System.Drawing.Point(323, 66);
            this.baseInputCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.baseInputCheckBox.Name = "baseInputCheckBox";
            this.baseInputCheckBox.Size = new System.Drawing.Size(91, 17);
            this.baseInputCheckBox.TabIndex = 6;
            this.baseInputCheckBox.Text = "Custom Base:";
            this.baseInputCheckBox.UseVisualStyleBackColor = true;
            this.baseInputCheckBox.CheckedChanged += new System.EventHandler(this.baseCustomInput_CheckedChanged);
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
            this.outputBaseDropdown.Location = new System.Drawing.Point(382, 125);
            this.outputBaseDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputBaseDropdown.Name = "outputBaseDropdown";
            this.outputBaseDropdown.Size = new System.Drawing.Size(103, 21);
            this.outputBaseDropdown.TabIndex = 9;
            this.outputBaseDropdown.SelectedIndexChanged += new System.EventHandler(this.baseOutputDropdown_SelectedIndexChanged);
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
            this.baseInputDropdown.Location = new System.Drawing.Point(382, 34);
            this.baseInputDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baseInputDropdown.Name = "baseInputDropdown";
            this.baseInputDropdown.Size = new System.Drawing.Size(103, 21);
            this.baseInputDropdown.TabIndex = 5;
            this.baseInputDropdown.SelectedIndexChanged += new System.EventHandler(this.baseInputDropdown_SelectedIndexChanged);
            // 
            // baseDropdownLabel_Out
            // 
            this.baseDropdownLabel_Out.AutoSize = true;
            this.baseDropdownLabel_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDropdownLabel_Out.Location = new System.Drawing.Point(272, 125);
            this.baseDropdownLabel_Out.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseDropdownLabel_Out.Name = "baseDropdownLabel_Out";
            this.baseDropdownLabel_Out.Size = new System.Drawing.Size(103, 20);
            this.baseDropdownLabel_Out.TabIndex = 8;
            this.baseDropdownLabel_Out.Text = "Output Base:";
            // 
            // baseDropdownLabel
            // 
            this.baseDropdownLabel.AutoSize = true;
            this.baseDropdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDropdownLabel.Location = new System.Drawing.Point(280, 36);
            this.baseDropdownLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseDropdownLabel.Name = "baseDropdownLabel";
            this.baseDropdownLabel.Size = new System.Drawing.Size(91, 20);
            this.baseDropdownLabel.TabIndex = 4;
            this.baseDropdownLabel.Text = "Input Base:";
            // 
            // baseOutputTextbox
            // 
            this.baseOutputTextbox.Location = new System.Drawing.Point(77, 127);
            this.baseOutputTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baseOutputTextbox.Multiline = true;
            this.baseOutputTextbox.Name = "baseOutputTextbox";
            this.baseOutputTextbox.ReadOnly = true;
            this.baseOutputTextbox.Size = new System.Drawing.Size(117, 18);
            this.baseOutputTextbox.TabIndex = 3;
            // 
            // baseOutputLabel
            // 
            this.baseOutputLabel.AutoSize = true;
            this.baseOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseOutputLabel.Location = new System.Drawing.Point(10, 125);
            this.baseOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseOutputLabel.Name = "baseOutputLabel";
            this.baseOutputLabel.Size = new System.Drawing.Size(62, 20);
            this.baseOutputLabel.TabIndex = 2;
            this.baseOutputLabel.Text = "Output:";
            // 
            // baseInputTextbox
            // 
            this.baseInputTextbox.Location = new System.Drawing.Point(77, 34);
            this.baseInputTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baseInputTextbox.Name = "baseInputTextbox";
            this.baseInputTextbox.Size = new System.Drawing.Size(117, 20);
            this.baseInputTextbox.TabIndex = 1;
            this.baseInputTextbox.TextChanged += new System.EventHandler(this.baseInput_TextChanged);
            // 
            // baseInputLabel
            // 
            this.baseInputLabel.AutoSize = true;
            this.baseInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseInputLabel.Location = new System.Drawing.Point(18, 36);
            this.baseInputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseInputLabel.Name = "baseInputLabel";
            this.baseInputLabel.Size = new System.Drawing.Size(50, 20);
            this.baseInputLabel.TabIndex = 0;
            this.baseInputLabel.Text = "Input:";
            // 
            // formulasPage
            // 
            this.formulasPage.Location = new System.Drawing.Point(4, 34);
            this.formulasPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formulasPage.Name = "formulasPage";
            this.formulasPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formulasPage.Size = new System.Drawing.Size(499, 293);
            this.formulasPage.TabIndex = 2;
            this.formulasPage.Text = "Formulas Calculator";
            this.formulasPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "STEM Student Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.unitConverterPage.ResumeLayout(false);
            this.unitConverterPage.PerformLayout();
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
        private System.Windows.Forms.TextBox unitOutput;
        private System.Windows.Forms.Label unit_eq_label;
        private System.Windows.Forms.ComboBox unitChoiceDropdown;
        private System.Windows.Forms.ComboBox unitOutputDropdown;
        private System.Windows.Forms.ComboBox unitInputDropdown;
        private System.Windows.Forms.TextBox unitInput;
        private System.Windows.Forms.ComboBox unitPowerDropdown_output;
        private System.Windows.Forms.ComboBox unitPowerDropdown_input;
    }
}


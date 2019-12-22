using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StemStudentUtil.BaseConverter;

namespace StemStudentUtil
{
    public partial class Form1 : Form
    {
        BaseExceptionHandler exceptionHandler_Base;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exceptionHandler_Base = new BaseExceptionHandler();
        }

        ///////////////////////////////////
        ////////////// BASE CONVERTER

        string outputStr, inputBaseStr, outputBaseStr;
        int inputNum, inputBaseVal, customInputBaseVal, 
            outputBaseVal, customOutputBaseVal;
        bool useCustomInput, useCustomOutput;

        //////// Checkboxes
        private void baseCustomInput_CheckedChanged(object sender, EventArgs e)
        {
            useCustomInput = baseInputCheckBox.Checked;

            // Change enabled status of input dropdown and custom input textbox
            baseInputDropdown.Enabled = !baseInputCheckBox.Checked;
            customInputBase.Enabled = baseInputCheckBox.Checked;
        }

        private void baseCustomOutput_CheckedChanged(object sender, EventArgs e)
        {
            useCustomOutput = baseOutputCheckBox.Checked;

            // Change enabled status of output dropdown and custom output textbox
            outputBaseDropdown.Enabled = !baseOutputCheckBox.Checked;
            customOutputBase.Enabled = baseOutputCheckBox.Checked;
        }

        //////// Textboxes
        private void baseInput_TextChanged(object sender, EventArgs e)
        {
            bool parse = exceptionHandler_Base.checkInput(baseInputTextbox.Text, out inputNum);

            if (!parse)
                MessageBox.Show("Error! Invalid input!");
        }

        private void baseCustomInput_TextChanged(object sender, EventArgs e)
        {
            bool parse = exceptionHandler_Base.checkCustomBaseInput(
                customInputBase.Text, out customInputBaseVal);

            if (!parse)
                MessageBox.Show("Error! Base must be a numeral 1 - 20.");
        }

        private void baseCustomOutput_TextChanged(object sender, EventArgs e)
        {
            bool parse = exceptionHandler_Base.checkCustomBaseInput(
                customOutputBase.Text, out customOutputBaseVal);

            if (!parse)
                MessageBox.Show("Error! Base must be a numeral 1 - 20.");
        }

        //////// Dropdowns

        private void baseInputDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputBaseStr = baseInputDropdown.SelectedItem.ToString();
            inputBaseVal = BaseUtilities.convertBaseType(inputBaseStr);
        }

        private void baseOutputDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputBaseStr = outputBaseDropdown.SelectedItem.ToString();
            outputBaseVal = BaseUtilities.convertBaseType(outputBaseStr);
        }

        //////// Buttons

        private void baseConvertButton_Click(object sender, EventArgs e)
        {
            int inputBaseParam = 0, outputBaseParam = 0;

            if (useCustomInput)
                inputBaseParam = customInputBaseVal;
            else
                inputBaseParam = inputBaseVal;

            if (useCustomOutput)
                outputBaseParam = customOutputBaseVal;
            else
                outputBaseParam = outputBaseVal;


            outputStr = BaseUtilities.convertInput(inputNum, inputBaseParam, outputBaseParam);
            baseOutputTextbox.Text = outputStr;
        }
    }
}

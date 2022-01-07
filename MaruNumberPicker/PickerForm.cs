using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaruNumberPicker
{
    public partial class PickerForm : Form
    {
        bool IsInitialized { get; set; } = false;
        public PickerForm()
        {
            InitializeComponent();
            this.IsInitialized = true;
        }

        private void PickerForm_Load(object sender, EventArgs e)
        {
            this.maruNumberRadioButton.Checked = true;
            this.SetTo50();
        }

        private void SetComboBoxes(int maxNum)
        {
            ComboBox[] cmbs = {this.fromComboBox, this.toComboBox };
            foreach (var cmb in cmbs)
            {
                cmb.Items.Clear();
            }
            for (int i = 0; i < maxNum; i++)
            {
                var num = i + 1;
                foreach (var cmb in cmbs)
                {
                    cmb.Items.Add(num.ToString());
                }
            }
            foreach (var cmb in cmbs)
            {
                cmb.SelectedIndex = 0;
            }
        }

        private void SetTo50()
        {
            this.SetComboBoxes(50);
        }

        private void SetTo100()
        {
            this.SetComboBoxes(100);
        }

        private void SetTo26()
        {
            this.SetComboBoxes(26);
        }

        private void maruNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.IsInitialized)
            {
                return;
            }

            this.SetTo50();
        }

        private void kakkoNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.IsInitialized)
            {
                return;
            }

            this.SetTo100();
        }

        private void zenkakuKakkoNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.IsInitialized)
            {
                return;
            }

            this.SetTo100();
        }

        private void smallAlphabetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.IsInitialized)
            {
                return;
            }

            this.SetTo26();
        }

        private void largeAlphabetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.IsInitialized)
            {
                return;
            }

            this.SetTo26();
        }

        private void numberOnlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.IsInitialized)
            {
                return;
            }

            this.SetTo100();
        }

        private void clipboardButton_Click(object sender, EventArgs e)
        {
            var fromNum = int.Parse(fromComboBox.Text);
            var toNum = int.Parse(toComboBox.Text);

            if (toNum < fromNum)
            {
                var temp = fromNum;
                fromNum = toNum;
                toNum = temp;
            }

            var res = new System.Text.StringBuilder();
            for (int i = fromNum; i < toNum + 1; i++)
            {
                if (this.maruNumberRadioButton.Checked)
                {
                    res.AppendLine(NumberConverter.GetMaruNumber(i));
                }
                else if (this.kakkoNumberRadioButton.Checked)
                {
                    res.AppendLine(NumberConverter.GetKakkoNumber(i));
                }
                else if (this.zenkakuKakkoNumberRadioButton.Checked)
                {
                    res.AppendLine(NumberConverter.GetZenkakuKakkoNumber(i));
                }
                else if (this.smallAlphabetRadioButton.Checked)
                {
                    res.AppendLine(NumberConverter.GetSmallAlphabet(i));
                }
                else if (this.largeAlphabetRadioButton.Checked)
                {
                    res.AppendLine(NumberConverter.GetLargeAlphabet(i));
                }
                else if (this.numberOnlyRadioButton.Checked)
                {
                    res.AppendLine(i.ToString() + ". ");
                }
            }

            try
            {
                Clipboard.Clear();
            }
            catch (Exception)
            {
            }

            Clipboard.SetText(res.ToString());
        }

    }
}

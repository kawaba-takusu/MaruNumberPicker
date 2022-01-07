namespace MaruNumberPicker
{
    partial class PickerForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.distGroupBox = new System.Windows.Forms.GroupBox();
            this.maruNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.kakkoNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.largeAlphabetRadioButton = new System.Windows.Forms.RadioButton();
            this.smallAlphabetRadioButton = new System.Windows.Forms.RadioButton();
            this.zenkakuKakkoNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clipboardButton = new System.Windows.Forms.Button();
            this.numberOnlyRadioButton = new System.Windows.Forms.RadioButton();
            this.distGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // distGroupBox
            // 
            this.distGroupBox.Controls.Add(this.numberOnlyRadioButton);
            this.distGroupBox.Controls.Add(this.zenkakuKakkoNumberRadioButton);
            this.distGroupBox.Controls.Add(this.smallAlphabetRadioButton);
            this.distGroupBox.Controls.Add(this.largeAlphabetRadioButton);
            this.distGroupBox.Controls.Add(this.kakkoNumberRadioButton);
            this.distGroupBox.Controls.Add(this.maruNumberRadioButton);
            this.distGroupBox.Location = new System.Drawing.Point(17, 14);
            this.distGroupBox.Name = "distGroupBox";
            this.distGroupBox.Size = new System.Drawing.Size(60, 160);
            this.distGroupBox.TabIndex = 0;
            this.distGroupBox.TabStop = false;
            this.distGroupBox.Text = "種別";
            // 
            // maruNumberRadioButton
            // 
            this.maruNumberRadioButton.AutoSize = true;
            this.maruNumberRadioButton.Checked = true;
            this.maruNumberRadioButton.Location = new System.Drawing.Point(6, 18);
            this.maruNumberRadioButton.Name = "maruNumberRadioButton";
            this.maruNumberRadioButton.Size = new System.Drawing.Size(35, 16);
            this.maruNumberRadioButton.TabIndex = 0;
            this.maruNumberRadioButton.TabStop = true;
            this.maruNumberRadioButton.Text = "①";
            this.maruNumberRadioButton.UseVisualStyleBackColor = true;
            this.maruNumberRadioButton.CheckedChanged += new System.EventHandler(this.maruNumberRadioButton_CheckedChanged);
            // 
            // kakkoNumberRadioButton
            // 
            this.kakkoNumberRadioButton.AutoSize = true;
            this.kakkoNumberRadioButton.Location = new System.Drawing.Point(6, 40);
            this.kakkoNumberRadioButton.Name = "kakkoNumberRadioButton";
            this.kakkoNumberRadioButton.Size = new System.Drawing.Size(37, 16);
            this.kakkoNumberRadioButton.TabIndex = 1;
            this.kakkoNumberRadioButton.Text = "(1)";
            this.kakkoNumberRadioButton.UseVisualStyleBackColor = true;
            this.kakkoNumberRadioButton.CheckedChanged += new System.EventHandler(this.kakkoNumberRadioButton_CheckedChanged);
            // 
            // largeAlphabetRadioButton
            // 
            this.largeAlphabetRadioButton.AutoSize = true;
            this.largeAlphabetRadioButton.Location = new System.Drawing.Point(6, 106);
            this.largeAlphabetRadioButton.Name = "largeAlphabetRadioButton";
            this.largeAlphabetRadioButton.Size = new System.Drawing.Size(33, 16);
            this.largeAlphabetRadioButton.TabIndex = 4;
            this.largeAlphabetRadioButton.Text = "A.";
            this.largeAlphabetRadioButton.UseVisualStyleBackColor = true;
            this.largeAlphabetRadioButton.CheckedChanged += new System.EventHandler(this.largeAlphabetRadioButton_CheckedChanged);
            // 
            // smallAlphabetRadioButton
            // 
            this.smallAlphabetRadioButton.AutoSize = true;
            this.smallAlphabetRadioButton.Location = new System.Drawing.Point(6, 84);
            this.smallAlphabetRadioButton.Name = "smallAlphabetRadioButton";
            this.smallAlphabetRadioButton.Size = new System.Drawing.Size(31, 16);
            this.smallAlphabetRadioButton.TabIndex = 3;
            this.smallAlphabetRadioButton.Text = "a.";
            this.smallAlphabetRadioButton.UseVisualStyleBackColor = true;
            this.smallAlphabetRadioButton.CheckedChanged += new System.EventHandler(this.smallAlphabetRadioButton_CheckedChanged);
            // 
            // zenkakuKakkoNumberRadioButton
            // 
            this.zenkakuKakkoNumberRadioButton.AutoSize = true;
            this.zenkakuKakkoNumberRadioButton.Location = new System.Drawing.Point(6, 62);
            this.zenkakuKakkoNumberRadioButton.Name = "zenkakuKakkoNumberRadioButton";
            this.zenkakuKakkoNumberRadioButton.Size = new System.Drawing.Size(43, 16);
            this.zenkakuKakkoNumberRadioButton.TabIndex = 2;
            this.zenkakuKakkoNumberRadioButton.Text = "（１）";
            this.zenkakuKakkoNumberRadioButton.UseVisualStyleBackColor = true;
            this.zenkakuKakkoNumberRadioButton.CheckedChanged += new System.EventHandler(this.zenkakuKakkoNumberRadioButton_CheckedChanged);
            // 
            // fromComboBox
            // 
            this.fromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(83, 28);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(60, 20);
            this.fromComboBox.TabIndex = 1;
            // 
            // toComboBox
            // 
            this.toComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(176, 28);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(60, 20);
            this.toComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "～";
            // 
            // clipboardButton
            // 
            this.clipboardButton.Location = new System.Drawing.Point(83, 59);
            this.clipboardButton.Name = "clipboardButton";
            this.clipboardButton.Size = new System.Drawing.Size(152, 115);
            this.clipboardButton.TabIndex = 4;
            this.clipboardButton.Text = "クリップボード";
            this.clipboardButton.UseVisualStyleBackColor = true;
            this.clipboardButton.Click += new System.EventHandler(this.clipboardButton_Click);
            // 
            // numberOnlyRadioButton
            // 
            this.numberOnlyRadioButton.AutoSize = true;
            this.numberOnlyRadioButton.Location = new System.Drawing.Point(6, 128);
            this.numberOnlyRadioButton.Name = "numberOnlyRadioButton";
            this.numberOnlyRadioButton.Size = new System.Drawing.Size(31, 16);
            this.numberOnlyRadioButton.TabIndex = 5;
            this.numberOnlyRadioButton.Text = "1.";
            this.numberOnlyRadioButton.UseVisualStyleBackColor = true;
            this.numberOnlyRadioButton.CheckedChanged += new System.EventHandler(this.numberOnlyRadioButton_CheckedChanged);
            // 
            // PickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 185);
            this.Controls.Add(this.clipboardButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.distGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PickerForm";
            this.Text = "丸数字列挙くん";
            this.Load += new System.EventHandler(this.PickerForm_Load);
            this.distGroupBox.ResumeLayout(false);
            this.distGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox distGroupBox;
        private System.Windows.Forms.RadioButton zenkakuKakkoNumberRadioButton;
        private System.Windows.Forms.RadioButton smallAlphabetRadioButton;
        private System.Windows.Forms.RadioButton largeAlphabetRadioButton;
        private System.Windows.Forms.RadioButton kakkoNumberRadioButton;
        private System.Windows.Forms.RadioButton maruNumberRadioButton;
        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clipboardButton;
        private System.Windows.Forms.RadioButton numberOnlyRadioButton;
    }
}


using System;
using System.Windows.Forms;

namespace TIP3
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox alphabetTextBox;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.NumericUpDown keyNumericUpDown;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label alphabetLabel;
        private System.Windows.Forms.Label operationLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label outputLabel;

        /// <summary>
        /// Освобождение всех используемых ресурсов.
        /// </summary>
        /// <param name="disposing">True, если управляемые ресурсы нужно освободить; иначе False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Метод для инициализации компонентов.
        /// </summary>
        private void InitializeComponent()
        {
            this.alphabetLabel = new System.Windows.Forms.Label();
            this.alphabetTextBox = new System.Windows.Forms.TextBox();
            this.operationLabel = new System.Windows.Forms.Label();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.keyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // alphabetLabel
            // 
            this.alphabetLabel.AutoSize = true;
            this.alphabetLabel.Location = new System.Drawing.Point(20, 20);
            this.alphabetLabel.Name = "alphabetLabel";
            this.alphabetLabel.Size = new System.Drawing.Size(53, 13);
            this.alphabetLabel.TabIndex = 0;
            this.alphabetLabel.Text = "Alphabet:";
            // 
            // alphabetTextBox
            // 
            this.alphabetTextBox.Location = new System.Drawing.Point(120, 20);
            this.alphabetTextBox.Name = "alphabetTextBox";
            this.alphabetTextBox.Size = new System.Drawing.Size(300, 20);
            this.alphabetTextBox.TabIndex = 1;
            this.alphabetTextBox.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Location = new System.Drawing.Point(20, 60);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(56, 13);
            this.operationLabel.TabIndex = 2;
            this.operationLabel.Text = "Operation:";
            // 
            // operationComboBox
            // 
            this.operationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] { "Encrypt", "Decrypt" });
            this.operationComboBox.Location = new System.Drawing.Point(120, 60);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(150, 21);
            this.operationComboBox.TabIndex = 3;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(20, 100);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(58, 13);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Input Text:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(120, 100);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(300, 60);
            this.inputTextBox.TabIndex = 5;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(20, 180);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(28, 13);
            this.keyLabel.TabIndex = 6;
            this.keyLabel.Text = "Key:";
            // 
            // keyNumericUpDown
            // 
            this.keyNumericUpDown.Location = new System.Drawing.Point(120, 180);
            this.keyNumericUpDown.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.keyNumericUpDown.Name = "keyNumericUpDown";
            this.keyNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.keyNumericUpDown.TabIndex = 7;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(20, 220);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(67, 13);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Text = "Output Text:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(120, 220);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(300, 60);
            this.outputTextBox.TabIndex = 9;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(120, 300);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(100, 23);
            this.processButton.TabIndex = 10;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.keyNumericUpDown);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.alphabetTextBox);
            this.Controls.Add(this.alphabetLabel);
            this.Name = "MainForm";
            this.Text = "Caesar Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.keyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

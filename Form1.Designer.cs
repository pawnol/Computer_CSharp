namespace Computer
{
    partial class ComputerForm
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
            this.modelGroupBox = new System.Windows.Forms.GroupBox();
            this.deluxeRadioButton = new System.Windows.Forms.RadioButton();
            this.superRadioButton = new System.Windows.Forms.RadioButton();
            this.videoCheckBox = new System.Windows.Forms.CheckBox();
            this.modemCheckBox = new System.Windows.Forms.CheckBox();
            this.memoryCheckBox = new System.Windows.Forms.CheckBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.modelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelGroupBox
            // 
            this.modelGroupBox.Controls.Add(this.superRadioButton);
            this.modelGroupBox.Controls.Add(this.deluxeRadioButton);
            this.modelGroupBox.Location = new System.Drawing.Point(40, 15);
            this.modelGroupBox.Name = "modelGroupBox";
            this.modelGroupBox.Size = new System.Drawing.Size(210, 76);
            this.modelGroupBox.TabIndex = 0;
            this.modelGroupBox.TabStop = false;
            this.modelGroupBox.Text = "Model";
            // 
            // deluxeRadioButton
            // 
            this.deluxeRadioButton.AutoSize = true;
            this.deluxeRadioButton.Checked = true;
            this.deluxeRadioButton.Location = new System.Drawing.Point(29, 31);
            this.deluxeRadioButton.Name = "deluxeRadioButton";
            this.deluxeRadioButton.Size = new System.Drawing.Size(76, 24);
            this.deluxeRadioButton.TabIndex = 0;
            this.deluxeRadioButton.TabStop = true;
            this.deluxeRadioButton.Text = "Deluxe";
            this.deluxeRadioButton.UseVisualStyleBackColor = true;
            // 
            // superRadioButton
            // 
            this.superRadioButton.AutoSize = true;
            this.superRadioButton.Location = new System.Drawing.Point(111, 31);
            this.superRadioButton.Name = "superRadioButton";
            this.superRadioButton.Size = new System.Drawing.Size(70, 24);
            this.superRadioButton.TabIndex = 1;
            this.superRadioButton.Text = "Super";
            this.superRadioButton.UseVisualStyleBackColor = true;
            // 
            // videoCheckBox
            // 
            this.videoCheckBox.AutoSize = true;
            this.videoCheckBox.Location = new System.Drawing.Point(46, 97);
            this.videoCheckBox.Name = "videoCheckBox";
            this.videoCheckBox.Size = new System.Drawing.Size(182, 24);
            this.videoCheckBox.TabIndex = 1;
            this.videoCheckBox.Text = "Upgraded Video Card";
            this.videoCheckBox.UseVisualStyleBackColor = true;
            // 
            // modemCheckBox
            // 
            this.modemCheckBox.AutoSize = true;
            this.modemCheckBox.Location = new System.Drawing.Point(46, 127);
            this.modemCheckBox.Name = "modemCheckBox";
            this.modemCheckBox.Size = new System.Drawing.Size(183, 24);
            this.modemCheckBox.TabIndex = 2;
            this.modemCheckBox.Text = "Interal Modem + Wi-Fi";
            this.modemCheckBox.UseVisualStyleBackColor = true;
            // 
            // memoryCheckBox
            // 
            this.memoryCheckBox.AutoSize = true;
            this.memoryCheckBox.Location = new System.Drawing.Point(46, 157);
            this.memoryCheckBox.Name = "memoryCheckBox";
            this.memoryCheckBox.Size = new System.Drawing.Size(199, 24);
            this.memoryCheckBox.TabIndex = 3;
            this.memoryCheckBox.Text = "1 GB Additional Memory";
            this.memoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(50, 253);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(85, 20);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total Cost:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Location = new System.Drawing.Point(141, 250);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 26);
            this.totalTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(58, 198);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(175, 35);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Total Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 289);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.memoryCheckBox);
            this.Controls.Add(this.modemCheckBox);
            this.Controls.Add(this.videoCheckBox);
            this.Controls.Add(this.modelGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ComputerForm";
            this.Text = "Computer";
            this.modelGroupBox.ResumeLayout(false);
            this.modelGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox modelGroupBox;
        private System.Windows.Forms.RadioButton superRadioButton;
        private System.Windows.Forms.RadioButton deluxeRadioButton;
        private System.Windows.Forms.CheckBox videoCheckBox;
        private System.Windows.Forms.CheckBox modemCheckBox;
        private System.Windows.Forms.CheckBox memoryCheckBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}


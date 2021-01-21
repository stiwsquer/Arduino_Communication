
namespace ArduinoCommunication
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
            this.serialConnectionGroupBox = new System.Windows.Forms.GroupBox();
            this.lcdControlGroupBox = new System.Windows.Forms.GroupBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialConnectionGroupBox.SuspendLayout();
            this.lcdControlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialConnectionGroupBox
            // 
            this.serialConnectionGroupBox.Controls.Add(this.comboBox1);
            this.serialConnectionGroupBox.Controls.Add(this.connectButton);
            this.serialConnectionGroupBox.Location = new System.Drawing.Point(36, 272);
            this.serialConnectionGroupBox.Name = "serialConnectionGroupBox";
            this.serialConnectionGroupBox.Size = new System.Drawing.Size(369, 112);
            this.serialConnectionGroupBox.TabIndex = 0;
            this.serialConnectionGroupBox.TabStop = false;
            this.serialConnectionGroupBox.Text = "Serial Connection";
            // 
            // lcdControlGroupBox
            // 
            this.lcdControlGroupBox.Controls.Add(this.textBox1);
            this.lcdControlGroupBox.Controls.Add(this.writeButton);
            this.lcdControlGroupBox.Location = new System.Drawing.Point(36, 53);
            this.lcdControlGroupBox.Name = "lcdControlGroupBox";
            this.lcdControlGroupBox.Size = new System.Drawing.Size(369, 141);
            this.lcdControlGroupBox.TabIndex = 1;
            this.lcdControlGroupBox.TabStop = false;
            this.lcdControlGroupBox.Text = "LCD Control";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(26, 52);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(132, 33);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(99, 75);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(132, 35);
            this.writeButton.TabIndex = 2;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.lcdControlGroupBox);
            this.Controls.Add(this.serialConnectionGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.serialConnectionGroupBox.ResumeLayout(false);
            this.lcdControlGroupBox.ResumeLayout(false);
            this.lcdControlGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox serialConnectionGroupBox;
        private System.Windows.Forms.GroupBox lcdControlGroupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button writeButton;
    }
}


﻿
namespace CryptMe.ctrls
{
    partial class EncryptionPanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.encryptGroup = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.encryptGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // encryptGroup
            // 
            this.encryptGroup.Controls.Add(this.button2);
            this.encryptGroup.Controls.Add(this.label3);
            this.encryptGroup.Controls.Add(this.textBox3);
            this.encryptGroup.Controls.Add(this.checkBox1);
            this.encryptGroup.Controls.Add(this.label2);
            this.encryptGroup.Controls.Add(this.label1);
            this.encryptGroup.Controls.Add(this.textBox2);
            this.encryptGroup.Controls.Add(this.textBox1);
            this.encryptGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptGroup.Enabled = false;
            this.encryptGroup.Location = new System.Drawing.Point(0, 0);
            this.encryptGroup.Name = "encryptGroup";
            this.encryptGroup.Size = new System.Drawing.Size(963, 619);
            this.encryptGroup.TabIndex = 4;
            this.encryptGroup.TabStop = false;
            this.encryptGroup.Text = "Datei Verschlüsseln";
            this.encryptGroup.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Datei";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dateiname (Verschlüsselt):";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(613, 20);
            this.textBox3.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(144, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Datei soll Base64 kodiert werden";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dateiname (Verschlüsselt):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dateiname:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(613, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 20);
            this.textBox1.TabIndex = 0;
            // 
            // EncryptionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.encryptGroup);
            this.Name = "EncryptionPanel";
            this.Size = new System.Drawing.Size(963, 619);
            this.encryptGroup.ResumeLayout(false);
            this.encryptGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox encryptGroup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
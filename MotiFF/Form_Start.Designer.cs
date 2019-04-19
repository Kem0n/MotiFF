using System;
using System.Windows.Forms;

namespace MotiFF
{
    partial class Form_Start
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
            this.textBox_Start = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Start
            // 
            this.textBox_Start.Location = new System.Drawing.Point(218, 36);
            this.textBox_Start.Name = "textBox_Start";
            this.textBox_Start.Size = new System.Drawing.Size(93, 20);
            this.textBox_Start.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите год вашего рождения";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(134, 85);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Ок";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new EventHandler(this.forms);
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // Form_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 120);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Start);
            this.Name = "Form_Start";
            this.Text = "Form_Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Start;
    }
}
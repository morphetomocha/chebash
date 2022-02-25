
namespace chebash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.yasosBiba = new System.Windows.Forms.RichTextBox();
            this.textN = new System.Windows.Forms.TextBox();
            this.textM = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bilo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Я банан";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yasosBiba
            // 
            this.yasosBiba.Location = new System.Drawing.Point(230, 173);
            this.yasosBiba.Name = "yasosBiba";
            this.yasosBiba.Size = new System.Drawing.Size(212, 175);
            this.yasosBiba.TabIndex = 1;
            this.yasosBiba.Text = "";
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(106, 23);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(118, 23);
            this.textN.TabIndex = 2;
            // 
            // textM
            // 
            this.textM.Location = new System.Drawing.Point(106, 52);
            this.textM.Name = "textM";
            this.textM.Size = new System.Drawing.Size(118, 23);
            this.textM.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "А я арбуз";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Было";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bilo
            // 
            this.bilo.Location = new System.Drawing.Point(3, 173);
            this.bilo.Name = "bilo";
            this.bilo.Size = new System.Drawing.Size(221, 185);
            this.bilo.TabIndex = 6;
            this.bilo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Стало";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bilo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textM);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.yasosBiba);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox yasosBiba;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.TextBox textM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox bilo;
        private System.Windows.Forms.Label label2;
    }
}


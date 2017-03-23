namespace Gruppeopgave_2
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
            this.blodsukker = new System.Windows.Forms.Button();
            this.blodtryk = new System.Windows.Forms.Button();
            this.BMI = new System.Windows.Forms.Button();
            this.sendoplysninger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // blodsukker
            // 
            this.blodsukker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.blodsukker.Location = new System.Drawing.Point(67, 75);
            this.blodsukker.Name = "blodsukker";
            this.blodsukker.Size = new System.Drawing.Size(152, 81);
            this.blodsukker.TabIndex = 0;
            this.blodsukker.Text = "vis mit blodsukker";
            this.blodsukker.UseVisualStyleBackColor = false;
            this.blodsukker.Click += new System.EventHandler(this.blodsukker_Click);
            // 
            // blodtryk
            // 
            this.blodtryk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.blodtryk.Location = new System.Drawing.Point(67, 207);
            this.blodtryk.Name = "blodtryk";
            this.blodtryk.Size = new System.Drawing.Size(152, 81);
            this.blodtryk.TabIndex = 1;
            this.blodtryk.Text = "vis mit blodtryk";
            this.blodtryk.UseVisualStyleBackColor = false;
            this.blodtryk.Click += new System.EventHandler(this.blodtryk_Click);
            // 
            // BMI
            // 
            this.BMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BMI.Location = new System.Drawing.Point(67, 343);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(152, 81);
            this.BMI.TabIndex = 2;
            this.BMI.Text = "Vis min vægt og BMI";
            this.BMI.UseVisualStyleBackColor = false;
            this.BMI.Click += new System.EventHandler(this.BMI_Click);
            // 
            // sendoplysninger
            // 
            this.sendoplysninger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sendoplysninger.Location = new System.Drawing.Point(492, 289);
            this.sendoplysninger.Name = "sendoplysninger";
            this.sendoplysninger.Size = new System.Drawing.Size(152, 81);
            this.sendoplysninger.TabIndex = 3;
            this.sendoplysninger.Text = "Send mine oplysninger til lægen";
            this.sendoplysninger.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hvor lang tid er dine oplysninger tilgængelig for lægen";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(469, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "5 dage";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(469, 145);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 21);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "10 dage";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(469, 185);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(85, 21);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "1 måned";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(708, 489);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendoplysninger);
            this.Controls.Add(this.BMI);
            this.Controls.Add(this.blodtryk);
            this.Controls.Add(this.blodsukker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button blodsukker;
        private System.Windows.Forms.Button blodtryk;
        private System.Windows.Forms.Button BMI;
        private System.Windows.Forms.Button sendoplysninger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}


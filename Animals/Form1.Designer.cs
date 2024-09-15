namespace Animals
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
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCow = new System.Windows.Forms.TextBox();
            this.TxtSheep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtGoat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSound = new System.Windows.Forms.Button();
            this.BtnMilk = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnChild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnSubmit.Location = new System.Drawing.Point(898, 140);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(165, 61);
            this.BtnSubmit.TabIndex = 0;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cow";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtCow
            // 
            this.TxtCow.Location = new System.Drawing.Point(113, 157);
            this.TxtCow.Name = "TxtCow";
            this.TxtCow.Size = new System.Drawing.Size(126, 29);
            this.TxtCow.TabIndex = 2;
            // 
            // TxtSheep
            // 
            this.TxtSheep.Location = new System.Drawing.Point(380, 157);
            this.TxtSheep.Name = "TxtSheep";
            this.TxtSheep.Size = new System.Drawing.Size(125, 29);
            this.TxtSheep.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sheep";
            // 
            // TxtGoat
            // 
            this.TxtGoat.Location = new System.Drawing.Point(658, 160);
            this.TxtGoat.Name = "TxtGoat";
            this.TxtGoat.Size = new System.Drawing.Size(119, 29);
            this.TxtGoat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Goat";
            // 
            // BtnSound
            // 
            this.BtnSound.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSound.Location = new System.Drawing.Point(198, 358);
            this.BtnSound.Name = "BtnSound";
            this.BtnSound.Size = new System.Drawing.Size(165, 61);
            this.BtnSound.TabIndex = 7;
            this.BtnSound.Text = "Sound";
            this.BtnSound.UseVisualStyleBackColor = false;
            this.BtnSound.Click += new System.EventHandler(this.BtnSound_Click);
            // 
            // BtnMilk
            // 
            this.BtnMilk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMilk.Location = new System.Drawing.Point(407, 358);
            this.BtnMilk.Name = "BtnMilk";
            this.BtnMilk.Size = new System.Drawing.Size(165, 61);
            this.BtnMilk.TabIndex = 8;
            this.BtnMilk.Text = "Milk";
            this.BtnMilk.UseVisualStyleBackColor = false;
            this.BtnMilk.Click += new System.EventHandler(this.BtnMilk_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnReset.Location = new System.Drawing.Point(860, 358);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(165, 61);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter number of animals:";
            // 
            // BtnChild
            // 
            this.BtnChild.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnChild.Location = new System.Drawing.Point(612, 358);
            this.BtnChild.Name = "BtnChild";
            this.BtnChild.Size = new System.Drawing.Size(165, 61);
            this.BtnChild.TabIndex = 11;
            this.BtnChild.Text = "Child";
            this.BtnChild.UseVisualStyleBackColor = false;
            this.BtnChild.Click += new System.EventHandler(this.BtnChild_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 686);
            this.Controls.Add(this.BtnChild);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnMilk);
            this.Controls.Add(this.BtnSound);
            this.Controls.Add(this.TxtGoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSheep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCow;
        private System.Windows.Forms.TextBox TxtSheep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtGoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSound;
        private System.Windows.Forms.Button BtnMilk;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnChild;
    }
}


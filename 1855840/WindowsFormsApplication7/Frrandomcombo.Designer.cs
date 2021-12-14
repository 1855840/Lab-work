
namespace WindowsFormsApplication7
{
    partial class Frrandomcombo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbrandom = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.btngeneratcomb = new System.Windows.Forms.Button();
            this.btnbackgg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbrandom);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btngeneratcomb);
            this.groupBox1.Location = new System.Drawing.Point(33, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbrandom
            // 
            this.cmbrandom.FormattingEnabled = true;
            this.cmbrandom.Location = new System.Drawing.Point(19, 49);
            this.cmbrandom.Name = "cmbrandom";
            this.cmbrandom.Size = new System.Drawing.Size(121, 27);
            this.cmbrandom.TabIndex = 4;
            this.cmbrandom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(181, 152);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(152, 23);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "greater than 500";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(181, 108);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 23);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "less than 500";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rest";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btngeneratcomb
            // 
            this.btngeneratcomb.Location = new System.Drawing.Point(213, 43);
            this.btngeneratcomb.Name = "btngeneratcomb";
            this.btngeneratcomb.Size = new System.Drawing.Size(75, 36);
            this.btngeneratcomb.TabIndex = 0;
            this.btngeneratcomb.Text = "Generat";
            this.btngeneratcomb.UseVisualStyleBackColor = true;
            this.btngeneratcomb.Click += new System.EventHandler(this.btngeneratcomb_Click);
            // 
            // btnbackgg
            // 
            this.btnbackgg.Location = new System.Drawing.Point(565, 359);
            this.btnbackgg.Name = "btnbackgg";
            this.btnbackgg.Size = new System.Drawing.Size(107, 41);
            this.btnbackgg.TabIndex = 3;
            this.btnbackgg.Text = "back";
            this.btnbackgg.UseVisualStyleBackColor = true;
            this.btnbackgg.Click += new System.EventHandler(this.btnbackgg_Click);
            // 
            // Frrandomcombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbackgg);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frrandomcombo";
            this.Text = "Frrandomcombo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btngeneratcomb;
        private System.Windows.Forms.ComboBox cmbrandom;
        private System.Windows.Forms.Button btnbackgg;
    }
}
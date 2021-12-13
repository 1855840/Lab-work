namespace WindowsFormsApplication7
{
    partial class akn
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
            this.log = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnRadio = new System.Windows.Forms.Button();
            this.btncobo = new System.Windows.Forms.Button();
            this.btnfood = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Button();
            this.btntorandom = new System.Windows.Forms.Button();
            this.btnrandomcombo = new System.Windows.Forms.Button();
            this.array = new System.Windows.Forms.Button();
            this.BtnArray2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(96, 248);
            this.log.Margin = new System.Windows.Forms.Padding(4);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(122, 51);
            this.log.TabIndex = 0;
            this.log.Text = "Login";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 151);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 206);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 27);
            this.textBox2.TabIndex = 5;
            // 
            // btnRadio
            // 
            this.btnRadio.Location = new System.Drawing.Point(100, 329);
            this.btnRadio.Margin = new System.Windows.Forms.Padding(4);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(118, 73);
            this.btnRadio.TabIndex = 6;
            this.btnRadio.Text = "Radio";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // btncobo
            // 
            this.btncobo.Location = new System.Drawing.Point(104, 425);
            this.btncobo.Name = "btncobo";
            this.btncobo.Size = new System.Drawing.Size(235, 66);
            this.btncobo.TabIndex = 7;
            this.btncobo.Text = "COMBO";
            this.btncobo.UseVisualStyleBackColor = true;
            this.btncobo.Click += new System.EventHandler(this.btncobo_Click);
            // 
            // btnfood
            // 
            this.btnfood.Location = new System.Drawing.Point(247, 329);
            this.btnfood.Name = "btnfood";
            this.btnfood.Size = new System.Drawing.Size(117, 73);
            this.btnfood.TabIndex = 8;
            this.btnfood.Text = "Food";
            this.btnfood.UseVisualStyleBackColor = true;
            this.btnfood.Click += new System.EventHandler(this.btnfood_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(100, 29);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(103, 39);
            this.id.TabIndex = 9;
            this.id.Text = "Quiz2-ID";
            this.id.UseVisualStyleBackColor = true;
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // btntorandom
            // 
            this.btntorandom.Location = new System.Drawing.Point(443, 107);
            this.btntorandom.Name = "btntorandom";
            this.btntorandom.Size = new System.Drawing.Size(224, 71);
            this.btntorandom.TabIndex = 10;
            this.btntorandom.Text = "Random numbers & colors";
            this.btntorandom.UseVisualStyleBackColor = true;
            this.btntorandom.Click += new System.EventHandler(this.btntorandom_Click);
            // 
            // btnrandomcombo
            // 
            this.btnrandomcombo.Location = new System.Drawing.Point(443, 206);
            this.btnrandomcombo.Name = "btnrandomcombo";
            this.btnrandomcombo.Size = new System.Drawing.Size(224, 70);
            this.btnrandomcombo.TabIndex = 11;
            this.btnrandomcombo.Text = "Random combo";
            this.btnrandomcombo.UseVisualStyleBackColor = true;
            this.btnrandomcombo.Click += new System.EventHandler(this.btnrandomcombo_Click);
            // 
            // array
            // 
            this.array.Location = new System.Drawing.Point(491, 341);
            this.array.Name = "array";
            this.array.Size = new System.Drawing.Size(134, 61);
            this.array.TabIndex = 12;
            this.array.Text = "Array";
            this.array.UseVisualStyleBackColor = true;
            this.array.Click += new System.EventHandler(this.array_Click);
            // 
            // BtnArray2
            // 
            this.BtnArray2.Location = new System.Drawing.Point(470, 432);
            this.BtnArray2.Name = "BtnArray2";
            this.BtnArray2.Size = new System.Drawing.Size(171, 59);
            this.BtnArray2.TabIndex = 13;
            this.BtnArray2.Text = "Array2";
            this.BtnArray2.UseVisualStyleBackColor = true;
            this.BtnArray2.Click += new System.EventHandler(this.BtnArray2_Click);
            // 
            // akn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 554);
            this.Controls.Add(this.BtnArray2);
            this.Controls.Add(this.array);
            this.Controls.Add(this.btnrandomcombo);
            this.Controls.Add(this.btntorandom);
            this.Controls.Add(this.id);
            this.Controls.Add(this.btnfood);
            this.Controls.Add(this.btncobo);
            this.Controls.Add(this.btnRadio);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "akn";
            this.Text = "My first app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.Button btncobo;
        private System.Windows.Forms.Button btnfood;
        private System.Windows.Forms.Button id;
        private System.Windows.Forms.Button btntorandom;
        private System.Windows.Forms.Button btnrandomcombo;
        private System.Windows.Forms.Button array;
        private System.Windows.Forms.Button BtnArray2;
    }
}


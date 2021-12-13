
namespace WindowsFormsApplication7
{
    partial class Formlog
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.btngpa = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 200);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 27);
            this.textBox1.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(190, 203);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 19);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID";
            // 
            // btngpa
            // 
            this.btngpa.Location = new System.Drawing.Point(591, 340);
            this.btngpa.Name = "btngpa";
            this.btngpa.Size = new System.Drawing.Size(93, 43);
            this.btngpa.TabIndex = 7;
            this.btngpa.Text = "GPA";
            this.btngpa.UseVisualStyleBackColor = true;
            this.btngpa.Click += new System.EventHandler(this.btngpa_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(279, 82);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 27);
            this.textBox2.TabIndex = 8;
            // 
            // Formlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btngpa);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Formlog";
            this.Text = "Formlog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button btngpa;
        private System.Windows.Forms.TextBox textBox2;
    }
}
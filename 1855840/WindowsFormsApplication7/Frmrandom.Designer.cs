
namespace WindowsFormsApplication7
{
    partial class Frmrandom
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
            this.btngenerate = new System.Windows.Forms.Button();
            this.btnrandom = new System.Windows.Forms.Button();
            this.btnbackgg = new System.Windows.Forms.Button();
            this.lblcolorrandom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngenerate
            // 
            this.btngenerate.Location = new System.Drawing.Point(247, 62);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(290, 84);
            this.btngenerate.TabIndex = 0;
            this.btngenerate.Text = "Gnerate random color";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // btnrandom
            // 
            this.btnrandom.Location = new System.Drawing.Point(85, 295);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(121, 36);
            this.btnrandom.TabIndex = 1;
            this.btnrandom.Text = "random number";
            this.btnrandom.UseVisualStyleBackColor = true;
            this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
            // 
            // btnbackgg
            // 
            this.btnbackgg.Location = new System.Drawing.Point(619, 374);
            this.btnbackgg.Name = "btnbackgg";
            this.btnbackgg.Size = new System.Drawing.Size(107, 41);
            this.btnbackgg.TabIndex = 2;
            this.btnbackgg.Text = "back";
            this.btnbackgg.UseVisualStyleBackColor = true;
            this.btnbackgg.Click += new System.EventHandler(this.btnbackgg_Click);
            // 
            // lblcolorrandom
            // 
            this.lblcolorrandom.AutoSize = true;
            this.lblcolorrandom.Location = new System.Drawing.Point(361, 188);
            this.lblcolorrandom.Name = "lblcolorrandom";
            this.lblcolorrandom.Size = new System.Drawing.Size(45, 19);
            this.lblcolorrandom.TabIndex = 3;
            this.lblcolorrandom.Text = "r-g-b";
            // 
            // Frmrandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcolorrandom);
            this.Controls.Add(this.btnbackgg);
            this.Controls.Add(this.btnrandom);
            this.Controls.Add(this.btngenerate);
            this.Name = "Frmrandom";
            this.Text = "Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.Button btnrandom;
        private System.Windows.Forms.Button btnbackgg;
        private System.Windows.Forms.Label lblcolorrandom;
    }
}
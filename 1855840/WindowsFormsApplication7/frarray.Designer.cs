
namespace WindowsFormsApplication7
{
    partial class frarray
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
            this.btnnBack = new System.Windows.Forms.Button();
            this.btnArray = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnBack
            // 
            this.btnnBack.Location = new System.Drawing.Point(631, 360);
            this.btnnBack.Name = "btnnBack";
            this.btnnBack.Size = new System.Drawing.Size(102, 42);
            this.btnnBack.TabIndex = 0;
            this.btnnBack.Text = "Back";
            this.btnnBack.UseVisualStyleBackColor = true;
            this.btnnBack.Click += new System.EventHandler(this.btnnBack_Click);
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(462, 149);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(138, 57);
            this.btnArray.TabIndex = 1;
            this.btnArray.Text = "forLoop";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.Location = new System.Drawing.Point(198, 149);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(115, 57);
            this.btnForeach.TabIndex = 2;
            this.btnForeach.Text = "forEach";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // frarray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.btnnBack);
            this.Name = "frarray";
            this.Text = "frarray";
            this.Load += new System.EventHandler(this.frarray_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnBack;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnForeach;
    }
}
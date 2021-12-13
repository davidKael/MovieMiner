
namespace MovieMiner
{
    partial class FormMainMenu
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
            this.tb_srchBox = new System.Windows.Forms.TextBox();
            this.btn_srch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_srchBox
            // 
            this.tb_srchBox.Location = new System.Drawing.Point(12, 13);
            this.tb_srchBox.Name = "tb_srchBox";
            this.tb_srchBox.Size = new System.Drawing.Size(657, 27);
            this.tb_srchBox.TabIndex = 0;
            // 
            // btn_srch
            // 
            this.btn_srch.Location = new System.Drawing.Point(675, 12);
            this.btn_srch.Name = "btn_srch";
            this.btn_srch.Size = new System.Drawing.Size(94, 29);
            this.btn_srch.TabIndex = 1;
            this.btn_srch.Text = "Search";
            this.btn_srch.UseVisualStyleBackColor = true;
            this.btn_srch.Click += new System.EventHandler(this.btn_srch_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_srch);
            this.Controls.Add(this.tb_srchBox);
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_srchBox;
        private System.Windows.Forms.Button btn_srch;
    }
}


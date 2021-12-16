
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
            this.rtb_SrchFindings = new System.Windows.Forms.RichTextBox();
            this.cb_SrchType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_srchBox
            // 
            this.tb_srchBox.BackColor = System.Drawing.Color.Black;
            this.tb_srchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_srchBox.ForeColor = System.Drawing.Color.White;
            this.tb_srchBox.Location = new System.Drawing.Point(12, 16);
            this.tb_srchBox.Name = "tb_srchBox";
            this.tb_srchBox.Size = new System.Drawing.Size(657, 20);
            this.tb_srchBox.TabIndex = 0;
            // 
            // btn_srch
            // 
            this.btn_srch.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_srch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_srch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_srch.FlatAppearance.BorderSize = 0;
            this.btn_srch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_srch.ForeColor = System.Drawing.Color.Black;
            this.btn_srch.Location = new System.Drawing.Point(675, 12);
            this.btn_srch.Name = "btn_srch";
            this.btn_srch.Size = new System.Drawing.Size(94, 28);
            this.btn_srch.TabIndex = 1;
            this.btn_srch.Text = "Search";
            this.btn_srch.UseVisualStyleBackColor = false;
            this.btn_srch.Click += new System.EventHandler(this.btn_srch_Click);
            // 
            // rtb_SrchFindings
            // 
            this.rtb_SrchFindings.BackColor = System.Drawing.Color.Black;
            this.rtb_SrchFindings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_SrchFindings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtb_SrchFindings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_SrchFindings.ForeColor = System.Drawing.Color.White;
            this.rtb_SrchFindings.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.rtb_SrchFindings.Location = new System.Drawing.Point(12, 42);
            this.rtb_SrchFindings.Name = "rtb_SrchFindings";
            this.rtb_SrchFindings.ReadOnly = true;
            this.rtb_SrchFindings.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_SrchFindings.Size = new System.Drawing.Size(657, 510);
            this.rtb_SrchFindings.TabIndex = 2;
            this.rtb_SrchFindings.Text = "";
            // 
            // cb_SrchType
            // 
            this.cb_SrchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SrchType.FormattingEnabled = true;
            this.cb_SrchType.Items.AddRange(new object[] {
            "by ID",
            "by Title"});
            this.cb_SrchType.Location = new System.Drawing.Point(775, 13);
            this.cb_SrchType.Name = "cb_SrchType";
            this.cb_SrchType.Size = new System.Drawing.Size(116, 28);
            this.cb_SrchType.TabIndex = 3;
            this.cb_SrchType.SelectedIndexChanged += new System.EventHandler(this.cb_SrchType_SelectedIndexChanged);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1002, 564);
            this.Controls.Add(this.cb_SrchType);
            this.Controls.Add(this.rtb_SrchFindings);
            this.Controls.Add(this.btn_srch);
            this.Controls.Add(this.tb_srchBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMainMenu";
            this.Text = "Movie Miner - Main Menu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_srchBox;
        private System.Windows.Forms.Button btn_srch;
        private System.Windows.Forms.RichTextBox rtb_SrchFindings;
        private System.Windows.Forms.ComboBox cb_SrchType;
    }
}


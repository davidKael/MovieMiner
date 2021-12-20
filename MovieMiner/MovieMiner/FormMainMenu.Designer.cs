
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_srchBox = new System.Windows.Forms.TextBox();
            this.btn_srch = new System.Windows.Forms.Button();
            this.cb_SrchType = new System.Windows.Forms.ComboBox();
            this.pctrBox_poster = new System.Windows.Forms.PictureBox();
            this.dataGrid_srchResults = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_movieData = new System.Windows.Forms.Panel();
            this.link_poster = new System.Windows.Forms.LinkLabel();
            this.link_homepage = new System.Windows.Forms.LinkLabel();
            this.rtb_overview = new System.Windows.Forms.RichTextBox();
            this.label_orgLanguage = new System.Windows.Forms.Label();
            this.label_rating = new System.Windows.Forms.Label();
            this.label_Runtime = new System.Windows.Forms.Label();
            this.label_Genres = new System.Windows.Forms.Label();
            this.label_ReleaseDate = new System.Windows.Forms.Label();
            this.label_searchResultMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_results = new System.Windows.Forms.Panel();
            this.label_pageCount = new System.Windows.Forms.Label();
            this.btn_prvsPage = new System.Windows.Forms.Button();
            this.btn_nxtPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBox_poster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_srchResults)).BeginInit();
            this.panel_movieData.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_results.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_srchBox
            // 
            this.tb_srchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_srchBox.BackColor = System.Drawing.Color.Black;
            this.tb_srchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_srchBox.ForeColor = System.Drawing.Color.White;
            this.tb_srchBox.Location = new System.Drawing.Point(3, 5);
            this.tb_srchBox.Name = "tb_srchBox";
            this.tb_srchBox.Size = new System.Drawing.Size(776, 27);
            this.tb_srchBox.TabIndex = 0;
            // 
            // btn_srch
            // 
            this.btn_srch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_srch.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_srch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_srch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_srch.FlatAppearance.BorderSize = 0;
            this.btn_srch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_srch.ForeColor = System.Drawing.Color.Black;
            this.btn_srch.Location = new System.Drawing.Point(782, 3);
            this.btn_srch.Name = "btn_srch";
            this.btn_srch.Size = new System.Drawing.Size(94, 28);
            this.btn_srch.TabIndex = 1;
            this.btn_srch.Text = "Search";
            this.btn_srch.UseVisualStyleBackColor = false;
            this.btn_srch.Click += new System.EventHandler(this.btn_srch_Click);
            // 
            // cb_SrchType
            // 
            this.cb_SrchType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_SrchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SrchType.FormattingEnabled = true;
            this.cb_SrchType.Items.AddRange(new object[] {
            "by ID",
            "by Title"});
            this.cb_SrchType.Location = new System.Drawing.Point(882, 4);
            this.cb_SrchType.Name = "cb_SrchType";
            this.cb_SrchType.Size = new System.Drawing.Size(116, 28);
            this.cb_SrchType.TabIndex = 3;
            this.cb_SrchType.SelectedIndexChanged += new System.EventHandler(this.cb_SrchType_SelectedIndexChanged);
            // 
            // pctrBox_poster
            // 
            this.pctrBox_poster.ErrorImage = global::MovieMiner.Properties.Resources.film_reel_g0dd6691b2_1280;
            this.pctrBox_poster.InitialImage = global::MovieMiner.Properties.Resources.film_reel_g0dd6691b2_1280;
            this.pctrBox_poster.Location = new System.Drawing.Point(3, 62);
            this.pctrBox_poster.Name = "pctrBox_poster";
            this.pctrBox_poster.Size = new System.Drawing.Size(288, 400);
            this.pctrBox_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBox_poster.TabIndex = 4;
            this.pctrBox_poster.TabStop = false;
            // 
            // dataGrid_srchResults
            // 
            this.dataGrid_srchResults.AllowUserToAddRows = false;
            this.dataGrid_srchResults.AllowUserToDeleteRows = false;
            this.dataGrid_srchResults.AllowUserToResizeColumns = false;
            this.dataGrid_srchResults.AllowUserToResizeRows = false;
            this.dataGrid_srchResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_srchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_srchResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGrid_srchResults.BackgroundColor = System.Drawing.Color.Black;
            this.dataGrid_srchResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_srchResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_srchResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_srchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_srchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_srchResults.ColumnHeadersVisible = false;
            this.dataGrid_srchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Year});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_srchResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_srchResults.EnableHeadersVisualStyles = false;
            this.dataGrid_srchResults.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_srchResults.MultiSelect = false;
            this.dataGrid_srchResults.Name = "dataGrid_srchResults";
            this.dataGrid_srchResults.ReadOnly = true;
            this.dataGrid_srchResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_srchResults.RowHeadersVisible = false;
            this.dataGrid_srchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_srchResults.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_srchResults.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGrid_srchResults.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_srchResults.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGrid_srchResults.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_srchResults.RowTemplate.Height = 29;
            this.dataGrid_srchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_srchResults.Size = new System.Drawing.Size(322, 471);
            this.dataGrid_srchResults.TabIndex = 5;
            this.dataGrid_srchResults.Visible = false;
            this.dataGrid_srchResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.HeaderText = "";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Year.Visible = false;
            // 
            // label_Title
            // 
            this.label_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(12, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(762, 57);
            this.label_Title.TabIndex = 6;
            this.label_Title.Text = "Title";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_movieData
            // 
            this.panel_movieData.BackColor = System.Drawing.Color.Transparent;
            this.panel_movieData.Controls.Add(this.link_poster);
            this.panel_movieData.Controls.Add(this.link_homepage);
            this.panel_movieData.Controls.Add(this.rtb_overview);
            this.panel_movieData.Controls.Add(this.label_orgLanguage);
            this.panel_movieData.Controls.Add(this.label_rating);
            this.panel_movieData.Controls.Add(this.label_Runtime);
            this.panel_movieData.Controls.Add(this.label_Genres);
            this.panel_movieData.Controls.Add(this.label_ReleaseDate);
            this.panel_movieData.Controls.Add(this.label_Title);
            this.panel_movieData.Controls.Add(this.pctrBox_poster);
            this.panel_movieData.ForeColor = System.Drawing.Color.Transparent;
            this.panel_movieData.Location = new System.Drawing.Point(12, 189);
            this.panel_movieData.Name = "panel_movieData";
            this.panel_movieData.Size = new System.Drawing.Size(777, 475);
            this.panel_movieData.TabIndex = 7;
            this.panel_movieData.Visible = false;
            // 
            // link_poster
            // 
            this.link_poster.AutoEllipsis = true;
            this.link_poster.ForeColor = System.Drawing.Color.White;
            this.link_poster.LinkArea = new System.Windows.Forms.LinkArea(8, 100);
            this.link_poster.Location = new System.Drawing.Point(297, 212);
            this.link_poster.Name = "link_poster";
            this.link_poster.Size = new System.Drawing.Size(459, 25);
            this.link_poster.TabIndex = 17;
            this.link_poster.TabStop = true;
            this.link_poster.Text = "Poster: /posterlink/";
            this.link_poster.UseCompatibleTextRendering = true;
            // 
            // link_homepage
            // 
            this.link_homepage.AutoEllipsis = true;
            this.link_homepage.ForeColor = System.Drawing.Color.White;
            this.link_homepage.LinkArea = new System.Windows.Forms.LinkArea(10, 100);
            this.link_homepage.Location = new System.Drawing.Point(297, 187);
            this.link_homepage.Name = "link_homepage";
            this.link_homepage.Size = new System.Drawing.Size(459, 25);
            this.link_homepage.TabIndex = 16;
            this.link_homepage.TabStop = true;
            this.link_homepage.Text = "Homepage: www.website.com";
            this.link_homepage.UseCompatibleTextRendering = true;
            // 
            // rtb_overview
            // 
            this.rtb_overview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_overview.BackColor = System.Drawing.SystemColors.Desktop;
            this.rtb_overview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_overview.ForeColor = System.Drawing.Color.White;
            this.rtb_overview.Location = new System.Drawing.Point(295, 252);
            this.rtb_overview.Margin = new System.Windows.Forms.Padding(10);
            this.rtb_overview.Name = "rtb_overview";
            this.rtb_overview.ReadOnly = true;
            this.rtb_overview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_overview.Size = new System.Drawing.Size(461, 210);
            this.rtb_overview.TabIndex = 12;
            this.rtb_overview.Text = "First this happened then then that happened... After that another thing happened " +
    "so we do not even oknow what happened anymore..";
            // 
            // label_orgLanguage
            // 
            this.label_orgLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_orgLanguage.BackColor = System.Drawing.Color.Transparent;
            this.label_orgLanguage.ForeColor = System.Drawing.Color.White;
            this.label_orgLanguage.Location = new System.Drawing.Point(295, 162);
            this.label_orgLanguage.Name = "label_orgLanguage";
            this.label_orgLanguage.Size = new System.Drawing.Size(461, 25);
            this.label_orgLanguage.TabIndex = 11;
            this.label_orgLanguage.Text = "Original Language: En";
            this.label_orgLanguage.Click += new System.EventHandler(this.label_orgLanguage_Click);
            // 
            // label_rating
            // 
            this.label_rating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rating.BackColor = System.Drawing.Color.Transparent;
            this.label_rating.ForeColor = System.Drawing.Color.White;
            this.label_rating.Location = new System.Drawing.Point(295, 62);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(461, 25);
            this.label_rating.TabIndex = 10;
            this.label_rating.Text = "Rating: 84%";
            // 
            // label_Runtime
            // 
            this.label_Runtime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Runtime.BackColor = System.Drawing.Color.Transparent;
            this.label_Runtime.ForeColor = System.Drawing.Color.White;
            this.label_Runtime.Location = new System.Drawing.Point(295, 137);
            this.label_Runtime.Name = "label_Runtime";
            this.label_Runtime.Size = new System.Drawing.Size(461, 25);
            this.label_Runtime.TabIndex = 9;
            this.label_Runtime.Text = "Runtime: 1h, 30min";
            // 
            // label_Genres
            // 
            this.label_Genres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Genres.BackColor = System.Drawing.Color.Transparent;
            this.label_Genres.ForeColor = System.Drawing.Color.White;
            this.label_Genres.Location = new System.Drawing.Point(295, 112);
            this.label_Genres.Name = "label_Genres";
            this.label_Genres.Size = new System.Drawing.Size(461, 25);
            this.label_Genres.TabIndex = 8;
            this.label_Genres.Text = "Genres: Action, Horror";
            this.label_Genres.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_ReleaseDate
            // 
            this.label_ReleaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ReleaseDate.BackColor = System.Drawing.Color.Transparent;
            this.label_ReleaseDate.ForeColor = System.Drawing.Color.White;
            this.label_ReleaseDate.Location = new System.Drawing.Point(295, 87);
            this.label_ReleaseDate.Name = "label_ReleaseDate";
            this.label_ReleaseDate.Size = new System.Drawing.Size(461, 25);
            this.label_ReleaseDate.TabIndex = 7;
            this.label_ReleaseDate.Text = "Release date: 2020-02-12";
            this.label_ReleaseDate.Click += new System.EventHandler(this.label_ReleaseDate_Click);
            // 
            // label_searchResultMessage
            // 
            this.label_searchResultMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_searchResultMessage.BackColor = System.Drawing.Color.Transparent;
            this.label_searchResultMessage.ForeColor = System.Drawing.Color.White;
            this.label_searchResultMessage.Location = new System.Drawing.Point(795, 186);
            this.label_searchResultMessage.Name = "label_searchResultMessage";
            this.label_searchResultMessage.Size = new System.Drawing.Size(408, 25);
            this.label_searchResultMessage.TabIndex = 13;
            this.label_searchResultMessage.Click += new System.EventHandler(this.label_searchResultMessage_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.tb_srchBox);
            this.panel2.Controls.Add(this.btn_srch);
            this.panel2.Controls.Add(this.cb_SrchType);
            this.panel2.Location = new System.Drawing.Point(119, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 35);
            this.panel2.TabIndex = 8;
            // 
            // panel_results
            // 
            this.panel_results.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_results.BackColor = System.Drawing.Color.Transparent;
            this.panel_results.Controls.Add(this.label_pageCount);
            this.panel_results.Controls.Add(this.btn_prvsPage);
            this.panel_results.Controls.Add(this.btn_nxtPage);
            this.panel_results.Controls.Add(this.dataGrid_srchResults);
            this.panel_results.Location = new System.Drawing.Point(795, 214);
            this.panel_results.Name = "panel_results";
            this.panel_results.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_results.Size = new System.Drawing.Size(322, 531);
            this.panel_results.TabIndex = 9;
            // 
            // label_pageCount
            // 
            this.label_pageCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_pageCount.BackColor = System.Drawing.Color.Transparent;
            this.label_pageCount.ForeColor = System.Drawing.Color.White;
            this.label_pageCount.Location = new System.Drawing.Point(103, 474);
            this.label_pageCount.Name = "label_pageCount";
            this.label_pageCount.Size = new System.Drawing.Size(115, 57);
            this.label_pageCount.TabIndex = 8;
            this.label_pageCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_prvsPage
            // 
            this.btn_prvsPage.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_prvsPage.Location = new System.Drawing.Point(3, 477);
            this.btn_prvsPage.Name = "btn_prvsPage";
            this.btn_prvsPage.Size = new System.Drawing.Size(94, 29);
            this.btn_prvsPage.TabIndex = 7;
            this.btn_prvsPage.Text = "Previous Page";
            this.btn_prvsPage.UseVisualStyleBackColor = true;
            this.btn_prvsPage.Visible = false;
            this.btn_prvsPage.Click += new System.EventHandler(this.btn_prvsPage_Click);
            // 
            // btn_nxtPage
            // 
            this.btn_nxtPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nxtPage.BackColor = System.Drawing.Color.Transparent;
            this.btn_nxtPage.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_nxtPage.ForeColor = System.Drawing.Color.Black;
            this.btn_nxtPage.Location = new System.Drawing.Point(224, 477);
            this.btn_nxtPage.Name = "btn_nxtPage";
            this.btn_nxtPage.Size = new System.Drawing.Size(94, 29);
            this.btn_nxtPage.TabIndex = 6;
            this.btn_nxtPage.Text = "Next Page";
            this.btn_nxtPage.UseVisualStyleBackColor = false;
            this.btn_nxtPage.Visible = false;
            this.btn_nxtPage.Click += new System.EventHandler(this.btn_nxtPage_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 123);
            this.label1.TabIndex = 10;
            this.label1.Text = "Movie Miner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MovieMiner.Properties.Resources.theatre_g3117f58f5_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1215, 791);
            this.Controls.Add(this.label_searchResultMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_results);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_movieData);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMainMenu";
            this.RightToLeftLayout = true;
            this.Text = "Movie Miner - Main Menu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBox_poster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_srchResults)).EndInit();
            this.panel_movieData.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_results.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_srchBox;
        private System.Windows.Forms.Button btn_srch;
        private System.Windows.Forms.ComboBox cb_SrchType;
        private System.Windows.Forms.PictureBox pctrBox_poster;
        private System.Windows.Forms.DataGridView dataGrid_srchResults;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel_movieData;
        private System.Windows.Forms.Label label_ReleaseDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_results;
        private System.Windows.Forms.Label label_Genres;
        private System.Windows.Forms.Label label_orgLanguage;
        private System.Windows.Forms.Label label_rating;
        private System.Windows.Forms.Label label_Runtime;
        private System.Windows.Forms.Label label_searchResultMessage;
        private System.Windows.Forms.RichTextBox rtb_overview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_poster;
        private System.Windows.Forms.LinkLabel link_homepage;
        private System.Windows.Forms.Button btn_prvsPage;
        private System.Windows.Forms.Button btn_nxtPage;
        private System.Windows.Forms.Label label_pageCount;
    }
}


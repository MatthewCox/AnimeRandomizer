namespace AnimeRandomizer.Frontends
{
    partial class AnimeRandomizerForm
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
            this.AnimeListBox = new System.Windows.Forms.ListBox();
            this.Title = new System.Windows.Forms.Label();
            this.AnimeDescriptionBox = new System.Windows.Forms.TextBox();
            this.AnimeImageBox = new System.Windows.Forms.PictureBox();
            this.SuggestedByLabel = new System.Windows.Forms.Label();
            this.AnimeSuggestedByBox = new System.Windows.Forms.TextBox();
            this.buttonAddAnime = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPick1 = new System.Windows.Forms.Button();
            this.buttonPickAvailable = new System.Windows.Forms.Button();
            this.AnimeNameBox = new System.Windows.Forms.TextBox();
            this.buttonRemoveAnime = new System.Windows.Forms.Button();
            this.AnimeImageFilepath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.AnimeImageBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimeListBox
            // 
            this.AnimeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.AnimeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AnimeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimeListBox.FormattingEnabled = true;
            this.AnimeListBox.ItemHeight = 16;
            this.AnimeListBox.Location = new System.Drawing.Point(12, 37);
            this.AnimeListBox.Name = "AnimeListBox";
            this.AnimeListBox.Size = new System.Drawing.Size(208, 468);
            this.AnimeListBox.TabIndex = 0;
            this.AnimeListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AnimeListBox_MouseDoubleClick);
            this.AnimeListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.AnimeListBox_DrawItem);
            this.AnimeListBox.SelectedIndexChanged += new System.EventHandler(this.AnimeListBox_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(160, 20);
            this.Title.TabIndex = 100;
            this.Title.Text = "Anime Randomizer";
            // 
            // AnimeDescriptionBox
            // 
            this.AnimeDescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimeDescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimeDescriptionBox.Location = new System.Drawing.Point(3, 35);
            this.AnimeDescriptionBox.Multiline = true;
            this.AnimeDescriptionBox.Name = "AnimeDescriptionBox";
            this.AnimeDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AnimeDescriptionBox.Size = new System.Drawing.Size(494, 197);
            this.AnimeDescriptionBox.TabIndex = 2;
            this.AnimeDescriptionBox.Text = "<AnimeDescriptionBox>";
            this.AnimeDescriptionBox.TextChanged += new System.EventHandler(this.AnimeDescriptionBox_TextChanged);
            // 
            // AnimeImageBox
            // 
            this.AnimeImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimeImageBox.Location = new System.Drawing.Point(157, 3);
            this.AnimeImageBox.Name = "AnimeImageBox";
            this.AnimeImageBox.Size = new System.Drawing.Size(340, 191);
            this.AnimeImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnimeImageBox.TabIndex = 4;
            this.AnimeImageBox.TabStop = false;
            // 
            // SuggestedByLabel
            // 
            this.SuggestedByLabel.AutoSize = true;
            this.SuggestedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuggestedByLabel.Location = new System.Drawing.Point(3, 0);
            this.SuggestedByLabel.Name = "SuggestedByLabel";
            this.SuggestedByLabel.Size = new System.Drawing.Size(93, 16);
            this.SuggestedByLabel.TabIndex = 101;
            this.SuggestedByLabel.Text = "Suggested By";
            // 
            // AnimeSuggestedByBox
            // 
            this.AnimeSuggestedByBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimeSuggestedByBox.Location = new System.Drawing.Point(4, 19);
            this.AnimeSuggestedByBox.Name = "AnimeSuggestedByBox";
            this.AnimeSuggestedByBox.Size = new System.Drawing.Size(139, 22);
            this.AnimeSuggestedByBox.TabIndex = 3;
            this.AnimeSuggestedByBox.Text = "<AnimeSuggestedBy>";
            this.AnimeSuggestedByBox.TextChanged += new System.EventHandler(this.AnimeSuggestedByBox_TextChanged);
            // 
            // buttonAddAnime
            // 
            this.buttonAddAnime.Location = new System.Drawing.Point(4, 106);
            this.buttonAddAnime.Name = "buttonAddAnime";
            this.buttonAddAnime.Size = new System.Drawing.Size(139, 23);
            this.buttonAddAnime.TabIndex = 7;
            this.buttonAddAnime.Text = "Add Anime";
            this.buttonAddAnime.UseVisualStyleBackColor = true;
            this.buttonAddAnime.Click += new System.EventHandler(this.buttonAddAnime_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(4, 164);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(4, 193);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(139, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPick1
            // 
            this.buttonPick1.Location = new System.Drawing.Point(4, 47);
            this.buttonPick1.Name = "buttonPick1";
            this.buttonPick1.Size = new System.Drawing.Size(139, 23);
            this.buttonPick1.TabIndex = 4;
            this.buttonPick1.Text = "Pick Random Anime";
            this.buttonPick1.UseVisualStyleBackColor = true;
            this.buttonPick1.Click += new System.EventHandler(this.buttonPick1_Click);
            // 
            // buttonPickAvailable
            // 
            this.buttonPickAvailable.Location = new System.Drawing.Point(4, 77);
            this.buttonPickAvailable.Name = "buttonPickAvailable";
            this.buttonPickAvailable.Size = new System.Drawing.Size(139, 23);
            this.buttonPickAvailable.TabIndex = 6;
            this.buttonPickAvailable.Text = "Pick Available Anime";
            this.buttonPickAvailable.UseVisualStyleBackColor = true;
            this.buttonPickAvailable.Click += new System.EventHandler(this.buttonPickAvailable_Click);
            // 
            // AnimeNameBox
            // 
            this.AnimeNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimeNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimeNameBox.Location = new System.Drawing.Point(3, 3);
            this.AnimeNameBox.Name = "AnimeNameBox";
            this.AnimeNameBox.Size = new System.Drawing.Size(494, 26);
            this.AnimeNameBox.TabIndex = 1;
            this.AnimeNameBox.Text = "<AnimeNameBox>";
            this.AnimeNameBox.TextChanged += new System.EventHandler(this.AnimeNameBox_TextChanged);
            // 
            // buttonRemoveAnime
            // 
            this.buttonRemoveAnime.Location = new System.Drawing.Point(4, 135);
            this.buttonRemoveAnime.Name = "buttonRemoveAnime";
            this.buttonRemoveAnime.Size = new System.Drawing.Size(139, 23);
            this.buttonRemoveAnime.TabIndex = 8;
            this.buttonRemoveAnime.Text = "Remove Anime";
            this.buttonRemoveAnime.UseVisualStyleBackColor = true;
            this.buttonRemoveAnime.Click += new System.EventHandler(this.buttonRemoveAnime_Click);
            // 
            // AnimeImageFilepath
            // 
            this.AnimeImageFilepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimeImageFilepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimeImageFilepath.Location = new System.Drawing.Point(157, 200);
            this.AnimeImageFilepath.Name = "AnimeImageFilepath";
            this.AnimeImageFilepath.Size = new System.Drawing.Size(266, 22);
            this.AnimeImageFilepath.TabIndex = 11;
            this.AnimeImageFilepath.Text = "<AnimeImageFilepath>";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(429, 199);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(68, 23);
            this.buttonBrowse.TabIndex = 12;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SuggestedByLabel);
            this.panel1.Controls.Add(this.AnimeSuggestedByBox);
            this.panel1.Controls.Add(this.buttonAddAnime);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonRemoveAnime);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonPick1);
            this.panel1.Controls.Add(this.buttonPickAvailable);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 221);
            this.panel1.TabIndex = 102;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(226, 37);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AnimeDescriptionBox);
            this.splitContainer1.Panel1.Controls.Add(this.AnimeNameBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.AnimeImageBox);
            this.splitContainer1.Panel2.Controls.Add(this.AnimeImageFilepath);
            this.splitContainer1.Panel2.Controls.Add(this.buttonBrowse);
            this.splitContainer1.Size = new System.Drawing.Size(502, 468);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 104;
            // 
            // AnimeRandomizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 515);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.AnimeListBox);
            this.Name = "AnimeRandomizerForm";
            this.Text = "Anime Randomizer";
            this.Load += new System.EventHandler(this.AnimeRandomizerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnimeImageBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AnimeListBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox AnimeDescriptionBox;
        private System.Windows.Forms.PictureBox AnimeImageBox;
        private System.Windows.Forms.Label SuggestedByLabel;
        private System.Windows.Forms.TextBox AnimeSuggestedByBox;
        private System.Windows.Forms.Button buttonAddAnime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPick1;
        private System.Windows.Forms.Button buttonPickAvailable;
        private System.Windows.Forms.TextBox AnimeNameBox;
        private System.Windows.Forms.Button buttonRemoveAnime;
        private System.Windows.Forms.TextBox AnimeImageFilepath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
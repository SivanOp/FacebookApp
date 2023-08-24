



namespace FacebookWinFormApp
{
    public partial class MainForm
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
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.listBoxFavoriteTeam = new System.Windows.Forms.ListBox();
            this.pictureBoxTeam = new System.Windows.Forms.PictureBox();
            this.linkLabelFetchAlbums = new System.Windows.Forms.LinkLabel();
            this.linkLabelTeams = new System.Windows.Forms.LinkLabel();
            this.linkLabelFetchGroups = new System.Windows.Forms.LinkLabel();
            this.linkLabelPopularPhotos = new System.Windows.Forms.LinkLabel();
            this.pictureBoxPopular1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPopular0 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPopular2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikePages = new System.Windows.Forms.PictureBox();
            this.listBoxLikePages = new System.Windows.Forms.ListBox();
            this.linkLabelLikePages = new System.Windows.Forms.LinkLabel();
            this.listBoxPostsComments = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.linkLabelPosts = new System.Windows.Forms.LinkLabel();
            this.linkLabelEvents = new System.Windows.Forms.LinkLabel();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.textBoxCheckIfGoodLiker = new System.Windows.Forms.TextBox();
            this.buttonCheckIfGoodLiker = new System.Windows.Forms.Button();
            this.labelCheckIfGoodLiker = new System.Windows.Forms.Label();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelPhotos = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.lableSortByForPages = new System.Windows.Forms.Label();
            this.comboBoxLikedPages = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikePages)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.Enabled = false;
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(951, 54);
            this.pictureBoxUserProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(130, 115);
            this.pictureBoxUserProfile.TabIndex = 53;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // listBoxFavoriteTeam
            // 
            this.listBoxFavoriteTeam.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFavoriteTeam.FormattingEnabled = true;
            this.listBoxFavoriteTeam.ItemHeight = 26;
            this.listBoxFavoriteTeam.Location = new System.Drawing.Point(858, 291);
            this.listBoxFavoriteTeam.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFavoriteTeam.Name = "listBoxFavoriteTeam";
            this.listBoxFavoriteTeam.Size = new System.Drawing.Size(241, 160);
            this.listBoxFavoriteTeam.TabIndex = 57;
            this.listBoxFavoriteTeam.SelectedIndexChanged += new System.EventHandler(this.listBoxFavoriteTeam_SelectedIndexChanged);
            // 
            // pictureBoxTeam
            // 
            this.pictureBoxTeam.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxTeam.Enabled = false;
            this.pictureBoxTeam.Location = new System.Drawing.Point(1014, 378);
            this.pictureBoxTeam.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxTeam.Name = "pictureBoxTeam";
            this.pictureBoxTeam.Size = new System.Drawing.Size(85, 73);
            this.pictureBoxTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTeam.TabIndex = 59;
            this.pictureBoxTeam.TabStop = false;
            this.pictureBoxTeam.Visible = false;
            // 
            // linkLabelFetchAlbums
            // 
            this.linkLabelFetchAlbums.AutoSize = true;
            this.linkLabelFetchAlbums.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFetchAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkLabelFetchAlbums.Location = new System.Drawing.Point(25, 653);
            this.linkLabelFetchAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelFetchAlbums.Name = "linkLabelFetchAlbums";
            this.linkLabelFetchAlbums.Size = new System.Drawing.Size(111, 32);
            this.linkLabelFetchAlbums.TabIndex = 61;
            this.linkLabelFetchAlbums.TabStop = true;
            this.linkLabelFetchAlbums.Text = "Fetch Albums";
            this.linkLabelFetchAlbums.UseCompatibleTextRendering = true;
            this.linkLabelFetchAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchAlbums_LinkClicked);
            // 
            // linkLabelTeams
            // 
            this.linkLabelTeams.AutoSize = true;
            this.linkLabelTeams.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelTeams.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkLabelTeams.Location = new System.Drawing.Point(858, 204);
            this.linkLabelTeams.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelTeams.Name = "linkLabelTeams";
            this.linkLabelTeams.Size = new System.Drawing.Size(283, 58);
            this.linkLabelTeams.TabIndex = 62;
            this.linkLabelTeams.TabStop = true;
            this.linkLabelTeams.Text = "Fetch Teams\r\n(Click on an album to view picture)";
            this.linkLabelTeams.UseCompatibleTextRendering = true;
            this.linkLabelTeams.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTeams_LinkClicked);
            // 
            // linkLabelFetchGroups
            // 
            this.linkLabelFetchGroups.AutoSize = true;
            this.linkLabelFetchGroups.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFetchGroups.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkLabelFetchGroups.Location = new System.Drawing.Point(25, 572);
            this.linkLabelFetchGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelFetchGroups.Name = "linkLabelFetchGroups";
            this.linkLabelFetchGroups.Size = new System.Drawing.Size(119, 32);
            this.linkLabelFetchGroups.TabIndex = 63;
            this.linkLabelFetchGroups.TabStop = true;
            this.linkLabelFetchGroups.Text = "Fetch Groups\r\n";
            this.linkLabelFetchGroups.UseCompatibleTextRendering = true;
            this.linkLabelFetchGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchGroups_LinkClicked);
            // 
            // linkLabelPopularPhotos
            // 
            this.linkLabelPopularPhotos.AutoSize = true;
            this.linkLabelPopularPhotos.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPopularPhotos.LinkArea = new System.Windows.Forms.LinkArea(0, 22);
            this.linkLabelPopularPhotos.Location = new System.Drawing.Point(867, 640);
            this.linkLabelPopularPhotos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelPopularPhotos.Name = "linkLabelPopularPhotos";
            this.linkLabelPopularPhotos.Size = new System.Drawing.Size(226, 58);
            this.linkLabelPopularPhotos.TabIndex = 65;
            this.linkLabelPopularPhotos.TabStop = true;
            this.linkLabelPopularPhotos.Text = "Fetch Popular Pictures\r\n(Shows top 3 liked pictures)";
            this.linkLabelPopularPhotos.UseCompatibleTextRendering = true;
            this.linkLabelPopularPhotos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPopularPhotos_LinkClicked);
            // 
            // pictureBoxPopular1
            // 
            this.pictureBoxPopular1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxPopular1.Enabled = false;
            this.pictureBoxPopular1.Location = new System.Drawing.Point(975, 723);
            this.pictureBoxPopular1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPopular1.Name = "pictureBoxPopular1";
            this.pictureBoxPopular1.Size = new System.Drawing.Size(85, 73);
            this.pictureBoxPopular1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPopular1.TabIndex = 66;
            this.pictureBoxPopular1.TabStop = false;
            this.pictureBoxPopular1.Visible = false;
            // 
            // pictureBoxPopular0
            // 
            this.pictureBoxPopular0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxPopular0.Enabled = false;
            this.pictureBoxPopular0.Location = new System.Drawing.Point(867, 723);
            this.pictureBoxPopular0.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPopular0.Name = "pictureBoxPopular0";
            this.pictureBoxPopular0.Size = new System.Drawing.Size(85, 73);
            this.pictureBoxPopular0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPopular0.TabIndex = 67;
            this.pictureBoxPopular0.TabStop = false;
            this.pictureBoxPopular0.Visible = false;
            // 
            // pictureBoxPopular2
            // 
            this.pictureBoxPopular2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxPopular2.Enabled = false;
            this.pictureBoxPopular2.Location = new System.Drawing.Point(1088, 723);
            this.pictureBoxPopular2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPopular2.Name = "pictureBoxPopular2";
            this.pictureBoxPopular2.Size = new System.Drawing.Size(85, 73);
            this.pictureBoxPopular2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPopular2.TabIndex = 70;
            this.pictureBoxPopular2.TabStop = false;
            this.pictureBoxPopular2.Visible = false;
            // 
            // pictureBoxLikePages
            // 
            this.pictureBoxLikePages.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxLikePages.Enabled = false;
            this.pictureBoxLikePages.Location = new System.Drawing.Point(178, 367);
            this.pictureBoxLikePages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLikePages.Name = "pictureBoxLikePages";
            this.pictureBoxLikePages.Size = new System.Drawing.Size(85, 74);
            this.pictureBoxLikePages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLikePages.TabIndex = 79;
            this.pictureBoxLikePages.TabStop = false;
            this.pictureBoxLikePages.Visible = false;
            // 
            // listBoxLikePages
            // 
            this.listBoxLikePages.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLikePages.FormattingEnabled = true;
            this.listBoxLikePages.ItemHeight = 26;
            this.listBoxLikePages.Location = new System.Drawing.Point(23, 281);
            this.listBoxLikePages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLikePages.Name = "listBoxLikePages";
            this.listBoxLikePages.Size = new System.Drawing.Size(240, 160);
            this.listBoxLikePages.TabIndex = 78;
            this.listBoxLikePages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikePages_SelectedIndexChanged);
            // 
            // linkLabelLikePages
            // 
            this.linkLabelLikePages.AutoSize = true;
            this.linkLabelLikePages.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLikePages.LinkArea = new System.Windows.Forms.LinkArea(0, 16);
            this.linkLabelLikePages.Location = new System.Drawing.Point(23, 150);
            this.linkLabelLikePages.Name = "linkLabelLikePages";
            this.linkLabelLikePages.Size = new System.Drawing.Size(289, 58);
            this.linkLabelLikePages.TabIndex = 77;
            this.linkLabelLikePages.TabStop = true;
            this.linkLabelLikePages.Text = "Fetch Like Pages \r\n(Click on a page to view it\'s picture)";
            this.linkLabelLikePages.UseCompatibleTextRendering = true;
            this.linkLabelLikePages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLikePages_LinkClicked);
            // 
            // listBoxPostsComments
            // 
            this.listBoxPostsComments.BackColor = System.Drawing.Color.OldLace;
            this.listBoxPostsComments.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostsComments.FormattingEnabled = true;
            this.listBoxPostsComments.ItemHeight = 26;
            this.listBoxPostsComments.Location = new System.Drawing.Point(353, 315);
            this.listBoxPostsComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPostsComments.Name = "listBoxPostsComments";
            this.listBoxPostsComments.Size = new System.Drawing.Size(483, 56);
            this.listBoxPostsComments.TabIndex = 75;
            this.listBoxPostsComments.Visible = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 26;
            this.listBoxPosts.Location = new System.Drawing.Point(353, 203);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(483, 108);
            this.listBoxPosts.TabIndex = 74;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // linkLabelPosts
            // 
            this.linkLabelPosts.AutoSize = true;
            this.linkLabelPosts.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPosts.LinkArea = new System.Windows.Forms.LinkArea(0, 11);
            this.linkLabelPosts.Location = new System.Drawing.Point(353, 150);
            this.linkLabelPosts.Name = "linkLabelPosts";
            this.linkLabelPosts.Size = new System.Drawing.Size(324, 58);
            this.linkLabelPosts.TabIndex = 73;
            this.linkLabelPosts.TabStop = true;
            this.linkLabelPosts.Text = "Fetch Posts\r\n(Click on a post to view the comments)\r\n";
            this.linkLabelPosts.UseCompatibleTextRendering = true;
            this.linkLabelPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPosts_LinkClicked);
            // 
            // linkLabelEvents
            // 
            this.linkLabelEvents.AutoSize = true;
            this.linkLabelEvents.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkLabelEvents.Location = new System.Drawing.Point(25, 494);
            this.linkLabelEvents.Name = "linkLabelEvents";
            this.linkLabelEvents.Size = new System.Drawing.Size(121, 32);
            this.linkLabelEvents.TabIndex = 72;
            this.linkLabelEvents.TabStop = true;
            this.linkLabelEvents.Text = "Fetch Events \r\n";
            this.linkLabelEvents.UseCompatibleTextRendering = true;
            this.linkLabelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEvents_LinkClicked);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostStatus.Location = new System.Drawing.Point(768, 102);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(75, 36);
            this.buttonPostStatus.TabIndex = 87;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(353, 54);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(490, 22);
            this.textBoxPostStatus.TabIndex = 88;
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileName.Location = new System.Drawing.Point(950, 9);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(131, 33);
            this.labelProfileName.TabIndex = 95;
            this.labelProfileName.Text = "ProfileName";
            // 
            // textBoxCheckIfGoodLiker
            // 
            this.textBoxCheckIfGoodLiker.Location = new System.Drawing.Point(867, 550);
            this.textBoxCheckIfGoodLiker.Name = "textBoxCheckIfGoodLiker";
            this.textBoxCheckIfGoodLiker.Size = new System.Drawing.Size(337, 22);
            this.textBoxCheckIfGoodLiker.TabIndex = 96;
            // 
            // buttonCheckIfGoodLiker
            // 
            this.buttonCheckIfGoodLiker.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIfGoodLiker.Location = new System.Drawing.Point(1129, 590);
            this.buttonCheckIfGoodLiker.Name = "buttonCheckIfGoodLiker";
            this.buttonCheckIfGoodLiker.Size = new System.Drawing.Size(75, 35);
            this.buttonCheckIfGoodLiker.TabIndex = 97;
            this.buttonCheckIfGoodLiker.Text = "Check";
            this.buttonCheckIfGoodLiker.UseVisualStyleBackColor = true;
            this.buttonCheckIfGoodLiker.Click += new System.EventHandler(this.buttonCheckIfGoodLiker_Click);
            // 
            // labelCheckIfGoodLiker
            // 
            this.labelCheckIfGoodLiker.AutoSize = true;
            this.labelCheckIfGoodLiker.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckIfGoodLiker.Location = new System.Drawing.Point(868, 494);
            this.labelCheckIfGoodLiker.Name = "labelCheckIfGoodLiker";
            this.labelCheckIfGoodLiker.Size = new System.Drawing.Size(231, 52);
            this.labelCheckIfGoodLiker.TabIndex = 98;
            this.labelCheckIfGoodLiker.Text = "Enter here a friend \r\nto check if he is a good liker ";
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberUser.Location = new System.Drawing.Point(93, 102);
            this.checkBoxRememberUser.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(145, 30);
            this.checkBoxRememberUser.TabIndex = 101;
            this.checkBoxRememberUser.Text = "Remember me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(186, 44);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(118, 41);
            this.buttonLogout.TabIndex = 100;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(23, 44);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(126, 41);
            this.buttonLogin.TabIndex = 99;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelPhotos
            // 
            this.panelPhotos.AutoScroll = true;
            this.panelPhotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPhotos.Location = new System.Drawing.Point(353, 407);
            this.panelPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPhotos.Name = "panelPhotos";
            this.panelPhotos.Size = new System.Drawing.Size(490, 390);
            this.panelPhotos.TabIndex = 89;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(26, 741);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(279, 22);
            this.textBoxName.TabIndex = 90;
            this.textBoxName.Visible = false;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumName.Location = new System.Drawing.Point(19, 704);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(115, 26);
            this.labelAlbumName.TabIndex = 91;
            this.labelAlbumName.Text = "Album Name:";
            this.labelAlbumName.Visible = false;
            // 
            // lableSortByForPages
            // 
            this.lableSortByForPages.AutoSize = true;
            this.lableSortByForPages.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableSortByForPages.Location = new System.Drawing.Point(18, 224);
            this.lableSortByForPages.Name = "lableSortByForPages";
            this.lableSortByForPages.Size = new System.Drawing.Size(73, 26);
            this.lableSortByForPages.TabIndex = 101;
            this.lableSortByForPages.Text = "Sort by:";
            // 
            // comboBoxLikedPages
            // 
            this.comboBoxLikedPages.FormattingEnabled = true;
            this.comboBoxLikedPages.Items.AddRange(new object[] {
            "SortByA-Z",
            "SortByZ-A",
            "SortByNumberOfLikes"});
            this.comboBoxLikedPages.Location = new System.Drawing.Point(97, 227);
            this.comboBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLikedPages.Name = "comboBoxLikedPages";
            this.comboBoxLikedPages.Size = new System.Drawing.Size(166, 24);
            this.comboBoxLikedPages.TabIndex = 100;
            this.comboBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.comboBoxLikePages_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1236, 984);
            this.Controls.Add(this.lableSortByForPages);
            this.Controls.Add(this.comboBoxLikedPages);
            this.Controls.Add(this.linkLabelFetchAlbums);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panelPhotos);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelCheckIfGoodLiker);
            this.Controls.Add(this.buttonCheckIfGoodLiker);
            this.Controls.Add(this.textBoxCheckIfGoodLiker);
            this.Controls.Add(this.labelProfileName);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.pictureBoxLikePages);
            this.Controls.Add(this.listBoxLikePages);
            this.Controls.Add(this.linkLabelLikePages);
            this.Controls.Add(this.listBoxPostsComments);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.linkLabelPosts);
            this.Controls.Add(this.linkLabelEvents);
            this.Controls.Add(this.pictureBoxPopular2);
            this.Controls.Add(this.pictureBoxPopular0);
            this.Controls.Add(this.pictureBoxPopular1);
            this.Controls.Add(this.linkLabelPopularPhotos);
            this.Controls.Add(this.linkLabelFetchGroups);
            this.Controls.Add(this.linkLabelTeams);
            this.Controls.Add(this.pictureBoxTeam);
            this.Controls.Add(this.listBoxFavoriteTeam);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "facebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikePages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.ListBox listBoxFavoriteTeam;
        private System.Windows.Forms.PictureBox pictureBoxTeam;
        private System.Windows.Forms.LinkLabel linkLabelFetchAlbums;
        private System.Windows.Forms.LinkLabel linkLabelTeams;
        private System.Windows.Forms.LinkLabel linkLabelFetchGroups;
        private System.Windows.Forms.LinkLabel linkLabelPopularPhotos;
        private System.Windows.Forms.PictureBox pictureBoxPopular1;
        private System.Windows.Forms.PictureBox pictureBoxPopular0;
        private System.Windows.Forms.PictureBox pictureBoxPopular2;
        private System.Windows.Forms.PictureBox pictureBoxLikePages;
        private System.Windows.Forms.ListBox listBoxLikePages;
        private System.Windows.Forms.LinkLabel linkLabelLikePages;
        private System.Windows.Forms.ListBox listBoxPostsComments;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.LinkLabel linkLabelPosts;
        private System.Windows.Forms.LinkLabel linkLabelEvents;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.TextBox textBoxCheckIfGoodLiker;
        private System.Windows.Forms.Button buttonCheckIfGoodLiker;
        private System.Windows.Forms.Label labelCheckIfGoodLiker;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelPhotos;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.Label lableSortByForPages;
        private System.Windows.Forms.ComboBox comboBoxLikedPages;
    }
}
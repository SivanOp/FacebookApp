using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic.Iterator;
using FacebookLogic.Strategy;
using FacebookLogic;

namespace FacebookWinFormApp
{
    public partial class MainForm : Form
    {
        private Logic m_Logic = new Logic();
        private Builder m_Builder = new Builder();
        private Album m_AlbumNameChange = new Album();
        private UserInfoPick m_UserInfoPick;

        public MainForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 20;
            Logic.s_AppSetings = AppSettings.LoadDataFromFile();
            StartPosition = FormStartPosition.Manual;
            Size = Logic.s_AppSetings.m_WindowSize;
            Location = Logic.s_AppSetings.m_WindowLocation;
            checkBoxRememberUser.Checked = Logic.s_AppSetings.m_RememberUser;
        }

        public class UserInfoPick
        {
            public ICommandCreateForm m_CommandCreateForm { get; set; }

            public void Selected(Panel i_Panel, User i_CurrentUser, Builder i_Builder)
            {
                if (m_CommandCreateForm != null)
                {
                    m_CommandCreateForm.Execute(i_Panel, i_CurrentUser, i_Builder);
                }
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (Logic.IsConnectToFacebook())
            {
                new Thread(ConnectRemmemberedUserAutomaticly).Start();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Logic.s_AppSetings.m_WindowSize = this.Size;
            Logic.s_AppSetings.m_WindowLocation = this.Location;
            Logic.s_AppSetings.m_RememberUser = this.checkBoxRememberUser.Checked;
            Logic.RememberUser();
        }

        public void ConnectRemmemberedUserAutomaticly()
        {
            pictureBoxUserProfile.Invoke(new Action(() => pictureBoxUserProfile.LoadAsync(Logic.s_LoggedInUser.PictureNormalURL)));
            this.Invoke(new Action(() => this.Text = Logic.s_LoggedInUser.Name));
            new Thread(fetchUserAlbums).Start();
            new Thread(fetchUserTeams).Start();
            new Thread(fetchUserGroups).Start();
            new Thread(fetchPosts).Start();
            new Thread(fetchEvents).Start();
            new Thread(fetchPages).Start();
            new Thread(fetchPopularPhotos).Start();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
            StartLogin();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
        }

        public void StartLogin()
        {
            bool isAccessTokenOK = m_Logic.CheckAccessToken();

            if (isAccessTokenOK)
            {
                pictureBoxUserProfile.LoadAsync(Logic.s_LoggedInUser.PictureNormalURL);
                labelProfileName.Text = Logic.s_LoggedInUser.Name;
            }

            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void fetchUserAlbums()
        {
            m_Builder.ShowName += ShowAlbumName;
            m_UserInfoPick = new UserInfoPick { m_CommandCreateForm = new ComposerForm.CreateAlbumFormCommand() };
            m_UserInfoPick.Selected(panelPhotos, Logic.s_LoggedInUser, m_Builder);
        }

        public void ShowAlbumName(Album i_Album)
        {
            m_AlbumNameChange = i_Album;
            labelAlbumName.Visible = true;
            textBoxName.Visible = true;
            textBoxName.Text = i_Album.Name;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            foreach (Control control in panelPhotos.Controls)
            {
                if (control is Label)
                {
                    if (string.Equals((control as Label).Text.Remove(0, 5), m_AlbumNameChange.Name))
                    {
                        (control as Label).Text = "Name:" + (sender as TextBox).Text;
                    }
                }
            }

            m_AlbumNameChange.Name = (sender as TextBox).Text;
        }

        private void fetchUserTeams()
        {
            listBoxFavoriteTeam.Invoke(new Action(() => listBoxFavoriteTeam.Items.Clear()));
            listBoxFavoriteTeam.Invoke(new Action(() => listBoxFavoriteTeam.DisplayMember = "Name"));

            if (listBoxFavoriteTeam.Items.Count > 0)
            {
                foreach (Page team in Logic.s_LoggedInUser.FavofriteTeams)
                {
                    listBoxFavoriteTeam.Invoke(new Action(() => listBoxFavoriteTeam.Items.Add(team)));
                }
            }

            else
            {
                MessageBox.Show("No Teams to retrive :(");

            }
        }

        private void showTeamPicture()
        {
            if (listBoxFavoriteTeam.Items.Count > 0)
            {
                hidePictrue();
                pictureBoxTeam.Visible = true;
                Page teamPicked = listBoxFavoriteTeam.SelectedItem as Page;
                pictureBoxTeam.LoadAsync(teamPicked.PictureNormalURL);
            }
        }

        private void listBoxFavoriteTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTeamPicture();
        }

        private void linkLabelFetchAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchUserAlbums();
        }

        private void linkLabelTeams_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchUserTeams();
        }

        private void fetchUserGroups()
        {
            m_UserInfoPick = new UserInfoPick { m_CommandCreateForm = new ComposerForm.CreateGroupFormCommand() };
            m_UserInfoPick.Selected(panelPhotos, Logic.s_LoggedInUser, m_Builder);
        }

        private void linkLabelFetchGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchUserGroups();
        }

        private void fetchPopularPhotos()
        {
            List<Photo> popularPhotosList = new List<Photo>();
            popularPhotosList = Logic.CreatePopularPhotosList();

            for (int index = 0; index < popularPhotosList.Count; index++)
            {
                switch (index)
                {
                    case 0:
                        pictureBoxPopular0.Invoke(new Action(() => pictureBoxPopular0.LoadAsync(popularPhotosList[index].PictureNormalURL)));
                        pictureBoxPopular0.Invoke(new Action(() => pictureBoxPopular0.Visible = true));
                        break;
                    case 1:
                        pictureBoxPopular1.Invoke(new Action(() => pictureBoxPopular1.LoadAsync(popularPhotosList[index].PictureNormalURL)));
                        pictureBoxPopular1.Invoke(new Action(() => pictureBoxPopular1.Visible = true));
                        break;
                    case 2:
                        pictureBoxPopular2.Invoke(new Action(() => pictureBoxPopular2.LoadAsync(popularPhotosList[index].PictureNormalURL)));
                        pictureBoxPopular2.Invoke(new Action(() => pictureBoxPopular2.Visible = true));
                        break;
                }
            }

            if (popularPhotosList.Count == 0)
            {
                MessageBox.Show("This user have no pictures");
            }
        }

        private void linkLabelPopularPhotos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPopularPhotos();
        }

        private void linkLabelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            m_UserInfoPick = new UserInfoPick { m_CommandCreateForm = new ComposerForm.CreateEventFormCommand() };
            m_UserInfoPick.Selected(panelPhotos, Logic.s_LoggedInUser, m_Builder);
        }

        private void linkLabelPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
            foreach (Post simplePosts in Logic.s_LoggedInUser.Posts)
            {
                if (simplePosts.Message != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(simplePosts.Message)));
                }

                else if (simplePosts.Caption != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(simplePosts.Caption)));
                }

                else
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", simplePosts.Type))));
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void linkLabelLikePages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPages();
        }

        private void fetchPages()
        {
            List<Page> likedPagesList = new List<Page>();
            listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Clear()));
            listBoxLikePages.Invoke(new Action(() => listBoxLikePages.DisplayMember = "Name"));

            try
            {
                likedPagesList = Logic.CreateUserLikePagesList();
                foreach (Page likedPage in likedPagesList)
                {
                    listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Add(likedPage)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxLikePages_SelectedIndexChanged(object sender, EventArgs e)
        {
            showLikePagesPicture();
        }

        private void showLikePagesPicture()
        {
            if (listBoxLikePages.SelectedItems.Count > 0)
            {
                hidePictrue();
                pictureBoxLikePages.Visible = true;
                Page selectedPage = listBoxLikePages.SelectedItem as Page;
                pictureBoxLikePages.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void hidePictrue()
        {
            pictureBoxTeam.Visible = false;
            pictureBoxLikePages.Visible = false;
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPostsComments();
        }

        private void showPostsComments()
        {
            if (listBoxPosts.Items.Count > 0)
            {
                listBoxPostsComments.Visible = true;
                Post selectedPost = Logic.s_LoggedInUser.Posts[listBoxPosts.SelectedIndex];
                listBoxPostsComments.DisplayMember = "Message";
                listBoxPostsComments.DataSource = selectedPost.Comments;
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = Logic.s_LoggedInUser.PostStatus(textBoxPostStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonCheckIfGoodLiker_Click(object sender, EventArgs e)
        {
            showIfUserIsGoodLiker();
        }

        private void showIfUserIsGoodLiker()
        {
            bool isGoodLiker = m_Logic.CheckIfFriendIsGoodLiker(textBoxCheckIfGoodLiker.Text);

            if (isGoodLiker)
            {
                MessageBox.Show(textBoxCheckIfGoodLiker.Text + " IS A GOOD FRIEND!!!  :)");
            }

            else
            {
                MessageBox.Show(textBoxCheckIfGoodLiker.Text + " NEEDS TO LIKE YOUR PHOTOS MORE :( ");
            }
        }

        private void comboBoxLikePages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                Page[] userLikedPages = Logic.s_LoggedInUser.LikedPages.ToArray();

                comboBoxLikePagesDecision();

                listBoxLikePages.Invoke(new Action(() => listBoxLikePages.DisplayMember = "Name"));
                listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Clear()));

                Logic.m_PostsSorter.StrategySort(userLikedPages);

                foreach (Page simplePage in userLikedPages)
                {
                    listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Add(simplePage)));
                }
            }
        }

        private void comboBoxLikePagesDecision()
        {
            switch (comboBoxLikedPages.SelectedIndex)
            {
                case 0:
                    Logic.m_PostsSorter = new StrategySorter(new AZSortStrategy());
                    break;
                case 1:
                    Logic.m_PostsSorter = new StrategySorter(new ZASortStrategy());
                    break;
                case 2:
                    Logic.m_PostsSorter = new StrategySorter(new LikesCountSortStrategy());
                    break;
                default:
                    break;
            }
        }
    }   
}

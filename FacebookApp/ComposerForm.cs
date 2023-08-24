using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookWinFormApp
{
    public partial class ComposerForm : Form
    {
        private List<object> m_UserInfo = new List<object>();
        private Panel m_Panel = new Panel();
        private User m_CurrentUser = new User();
        private Builder m_Builder = new Builder();
        private UserInfoBuilderPick m_UserInfoBuilderPick = new UserInfoBuilderPick();

        public ComposerForm()
        {
            InitializeComponent();
        }

        public class UserInfoBuilderPick
        {
            public ICommandBuildPanel m_CommandBuildPanel { get; set; }

            public void Selected(Panel i_Panel, List<object> i_UserInfo, User i_CurrentUser, Builder i_builder)
            {
                if (m_CommandBuildPanel != null)
                {
                    m_CommandBuildPanel.Execute(i_Panel, i_UserInfo, i_CurrentUser, i_builder);
                }
            }
        }

        public void InfoToGet(Panel i_Panel, User i_CurrentUser, Builder i_Builder)
        {
            m_Panel = i_Panel;
            m_CurrentUser = i_CurrentUser;
            m_Builder = i_Builder;
        }

        private void albumFormBuilder()
        {
            m_UserInfoBuilderPick = new UserInfoBuilderPick { m_CommandBuildPanel = new Builder.BuildAlbumPanelCommand() };
            this.Size = new Size(346, 545);
            Label label = new Label();
            label.Size = new Size(191, 17);
            label.Text = "Pick info on album to present";
            label.Location = new Point(28, 11);
            this.Controls.Add(label);
            CheckBox checkBoxAlbumName = new CheckBox();
            checkBoxAlbumName.Text = "Name";
            checkBoxAlbumName.Size = new Size(67, 21);
            checkBoxAlbumName.Location = new Point(61, 55);
            checkBoxAlbumName.Checked = true;
            checkBoxAlbumName.Enabled = false;
            checkBoxAlbumName.Visible = true;
            this.Controls.Add(checkBoxAlbumName);
            CheckBox checkBoxAlbumCoverPhoto = new CheckBox();
            checkBoxAlbumCoverPhoto.Text = "Cover Photo";
            checkBoxAlbumCoverPhoto.Size = new Size(108, 21);
            checkBoxAlbumCoverPhoto.Location = new Point(61, 105);
            checkBoxAlbumCoverPhoto.Visible = true;
            checkBoxAlbumCoverPhoto.CheckedChanged += checkBoxAlbumCoverPhoto_CheckedChanged;
            this.Controls.Add(checkBoxAlbumCoverPhoto);
            CheckBox checkBoxAlbumNumberOfPhotos = new CheckBox();
            checkBoxAlbumNumberOfPhotos.Text = "Number Of Photos";
            checkBoxAlbumNumberOfPhotos.Size = new Size(147, 21);
            checkBoxAlbumNumberOfPhotos.Location = new Point(61, 159);
            checkBoxAlbumNumberOfPhotos.Visible = true;
            checkBoxAlbumNumberOfPhotos.CheckedChanged += checkBoxAlbumNumberOfPhotos_CheckedChanged;
            this.Controls.Add(checkBoxAlbumNumberOfPhotos);
            CheckBox checkBoxAlbumTimeCreated = new CheckBox();
            checkBoxAlbumTimeCreated.Text = "Time Created";
            checkBoxAlbumTimeCreated.Size = new Size(115, 21);
            checkBoxAlbumTimeCreated.Location = new Point(61, 207);
            checkBoxAlbumTimeCreated.Visible = true;
            checkBoxAlbumTimeCreated.CheckedChanged += checkBoxAlbumTimeCreated_CheckedChanged;
            this.Controls.Add(checkBoxAlbumTimeCreated);
            CheckBox checkBoxAlbumLastUpdated = new CheckBox();
            checkBoxAlbumLastUpdated.Text = "Last Updated";
            checkBoxAlbumLastUpdated.Size = new Size(115, 21);
            checkBoxAlbumLastUpdated.Location = new Point(61, 258);
            checkBoxAlbumLastUpdated.Visible = true;
            checkBoxAlbumLastUpdated.CheckedChanged += checkBoxAlbumLastUpdated_CheckedChanged;
            this.Controls.Add(checkBoxAlbumLastUpdated);
            CheckBox checkBoxAlbumAmountOfLikes = new CheckBox();
            checkBoxAlbumAmountOfLikes.Text = "Amount Of Likes";
            checkBoxAlbumAmountOfLikes.Size = new Size(134, 21);
            checkBoxAlbumAmountOfLikes.Location = new Point(61, 314);
            checkBoxAlbumAmountOfLikes.Visible = true;
            checkBoxAlbumAmountOfLikes.CheckedChanged += checkBoxAlbumAmountOfLikes_CheckedChanged;
            this.Controls.Add(checkBoxAlbumAmountOfLikes);
            buttonBuilder.Location = new Point(89, 383);
        }

        private void groupFormBuilder()
        {
            m_UserInfoBuilderPick = new UserInfoBuilderPick { m_CommandBuildPanel = new Builder.BuildGroupPanelCommand() };
            this.Size = new Size(326, 489);
            Label label = new Label();
            label.Size = new Size(191, 17);
            label.Text = "Pick info on group to present";
            label.Location = new Point(28, 11);
            this.Controls.Add(label);
            CheckBox checkBoxGroupName = new CheckBox();
            checkBoxGroupName.Text = "Name";
            checkBoxGroupName.Size = new Size(67, 21);
            checkBoxGroupName.Location = new Point(61, 55);
            checkBoxGroupName.Checked = true;
            checkBoxGroupName.Enabled = false;
            checkBoxGroupName.Visible = true;
            this.Controls.Add(checkBoxGroupName);
            CheckBox checkBoxGroupCoverPhoto = new CheckBox();
            checkBoxGroupCoverPhoto.Text = "Cover Photo";
            checkBoxGroupCoverPhoto.Size = new Size(108, 21);
            checkBoxGroupCoverPhoto.Location = new Point(61, 105);
            checkBoxGroupCoverPhoto.Visible = true;
            checkBoxGroupCoverPhoto.CheckedChanged += checkBoxGroupCoverPhoto_CheckedChanged;
            this.Controls.Add(checkBoxGroupCoverPhoto);
            CheckBox checkBoxGroupDescription = new CheckBox();
            checkBoxGroupDescription.Text = "Group Description";
            checkBoxGroupDescription.Size = new Size(147, 21);
            checkBoxGroupDescription.Location = new Point(61, 159);
            checkBoxGroupDescription.Visible = true;
            checkBoxGroupDescription.CheckedChanged += checkBoxGroupDescription_CheckedChanged;
            this.Controls.Add(checkBoxGroupDescription);
            CheckBox checkBoxGroupLastUpdated = new CheckBox();
            checkBoxGroupLastUpdated.Text = "Last Updated";
            checkBoxGroupLastUpdated.Size = new Size(115, 21);
            checkBoxGroupLastUpdated.Location = new Point(61, 207);
            checkBoxGroupLastUpdated.Visible = true;
            checkBoxGroupLastUpdated.CheckedChanged += checkBoxGroupLastUpdated_CheckedChanged;
            this.Controls.Add(checkBoxGroupLastUpdated);
            CheckBox checkBoxGroupOwner = new CheckBox();
            checkBoxGroupOwner.Text = "Owner";
            checkBoxGroupOwner.Size = new Size(134, 21);
            checkBoxGroupOwner.Location = new Point(61, 258);
            checkBoxGroupOwner.Visible = true;
            checkBoxGroupOwner.CheckedChanged += checkBoxGroupOwner_CheckedChanged;
            this.Controls.Add(checkBoxGroupOwner);
            buttonBuilder.Location = new Point(89, 327);
        }

        private void eventsFormBuilder()
        {
            m_UserInfoBuilderPick = new UserInfoBuilderPick { m_CommandBuildPanel = new Builder.BuildEventPanelCommand() };
            this.Size = new Size(326, 489);
            Label label = new Label();
            label.Size = new Size(191, 17);
            label.Text = "Pick info on Event to present";
            label.Location = new Point(28, 11);
            this.Controls.Add(label);
            CheckBox checkBoxEventName = new CheckBox();
            checkBoxEventName.Text = "Name";
            checkBoxEventName.Size = new Size(67, 21);
            checkBoxEventName.Location = new Point(61, 55);
            checkBoxEventName.Checked = true;
            checkBoxEventName.Enabled = false;
            checkBoxEventName.Visible = true;
            this.Controls.Add(checkBoxEventName);
            CheckBox checkBoxEventCoverPhoto = new CheckBox();
            checkBoxEventCoverPhoto.Text = "Cover Photo";
            checkBoxEventCoverPhoto.Size = new Size(108, 21);
            checkBoxEventCoverPhoto.Location = new Point(61, 105);
            checkBoxEventCoverPhoto.Visible = true;
            checkBoxEventCoverPhoto.CheckedChanged += checkBoxEventCoverPhoto_CheckedChanged;
            this.Controls.Add(checkBoxEventCoverPhoto);
            CheckBox checkBoxEventDescription = new CheckBox();
            checkBoxEventDescription.Text = "Description";
            checkBoxEventDescription.Size = new Size(147, 21);
            checkBoxEventDescription.Location = new Point(61, 159);
            checkBoxEventDescription.Visible = true;
            checkBoxEventDescription.CheckedChanged += checkBoxEventDescription_CheckedChanged;
            this.Controls.Add(checkBoxEventDescription);
            CheckBox checkBoxEventStartTime = new CheckBox();
            checkBoxEventStartTime.Text = "Start Time";
            checkBoxEventStartTime.Size = new Size(115, 21);
            checkBoxEventStartTime.Location = new Point(61, 207);
            checkBoxEventStartTime.Visible = true;
            checkBoxEventStartTime.CheckedChanged += checkBoxEventStartTime_CheckedChanged;
            this.Controls.Add(checkBoxEventStartTime);
            CheckBox checkBoxEventEndTime = new CheckBox();
            checkBoxEventEndTime.Text = "End Time";
            checkBoxEventEndTime.Size = new Size(115, 21);
            checkBoxEventEndTime.Location = new Point(61, 258);
            checkBoxEventEndTime.Visible = true;
            checkBoxEventEndTime.CheckedChanged += checkBoxEventEndTime_CheckedChanged;
            this.Controls.Add(checkBoxEventEndTime);
            buttonBuilder.Location = new Point(89, 327);
        }

        private void buttonBuilder_Click(object sender, EventArgs e)
        {
            m_Panel.Controls.Clear();
            Close();
            new Thread(activateBuilder).Start();
        }

        private void activateBuilder()
        {
            m_UserInfoBuilderPick.Selected(m_Panel, m_UserInfo, m_CurrentUser, m_Builder);
        }

        private void checkBoxAlbumCoverPhoto_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eAlbumInfo.AlbumCoverPhoto);
            }
            else
            {
                m_UserInfo.Remove(eAlbumInfo.AlbumCoverPhoto);
            }
        }

        private void checkBoxAlbumNumberOfPhotos_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eAlbumInfo.AlbumNumberOfPhotos);
            }
            else
            {
                m_UserInfo.Remove(eAlbumInfo.AlbumNumberOfPhotos);
            }
        }

        private void checkBoxAlbumTimeCreated_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eAlbumInfo.AlbumTimeCreated);
            }
            else
            {
                m_UserInfo.Remove(eAlbumInfo.AlbumTimeCreated);
            }
        }

        private void checkBoxAlbumLastUpdated_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eAlbumInfo.AlbumLastUpdated);
            }
            else
            {
                m_UserInfo.Remove(eAlbumInfo.AlbumLastUpdated);
            }
        }

        private void checkBoxAlbumAmountOfLikes_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eAlbumInfo.AlbumAmountOfLikes);
            }
            else
            {
                m_UserInfo.Remove(eAlbumInfo.AlbumAmountOfLikes);
            }
        }

        private void checkBoxGroupCoverPhoto_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eGroupInfo.GroupCoverPhoto);
            }
            else
            {
                m_UserInfo.Remove(eGroupInfo.GroupCoverPhoto);
            }
        }

        private void checkBoxGroupDescription_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eGroupInfo.GroupDescription);
            }
            else
            {
                m_UserInfo.Remove(eGroupInfo.GroupDescription);
            }
        }

        private void checkBoxGroupLastUpdated_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eGroupInfo.GroupLastUpdated);
            }
            else
            {
                m_UserInfo.Remove(eGroupInfo.GroupLastUpdated);
            }
        }

        private void checkBoxGroupOwner_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eGroupInfo.GroupOwner);
            }
            else
            {
                m_UserInfo.Remove(eGroupInfo.GroupOwner);
            }
        }

        private void checkBoxEventCoverPhoto_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eEventInfo.EventCoverPhoto);
            }
            else
            {
                m_UserInfo.Remove(eEventInfo.EventCoverPhoto);
            }
        }

        private void checkBoxEventDescription_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eEventInfo.EventDescription);
            }
            else
            {
                m_UserInfo.Remove(eEventInfo.EventDescription);
            }
        }

        private void checkBoxEventStartTime_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eEventInfo.EventStartTime);
            }
            else
            {
                m_UserInfo.Remove(eEventInfo.EventStartTime);
            }
        }

        private void checkBoxEventEndTime_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_UserInfo.Add(eEventInfo.EventEndTime);
            }
            else
            {
                m_UserInfo.Remove(eEventInfo.EventEndTime);
            }
        }

        public class CreateAlbumFormCommand : ICommandCreateForm
        {
            public ComposerForm m_ComposerForm = new ComposerForm();

            public void Execute(Panel i_Panel, User i_CurrentUser, Builder i_Builder)
            {
                m_ComposerForm.InfoToGet(i_Panel, i_CurrentUser, i_Builder);
                m_ComposerForm.albumFormBuilder();
                m_ComposerForm.ShowDialog();
            }
        }

        public class CreateGroupFormCommand : ICommandCreateForm
        {
            public ComposerForm m_ComposerForm = new ComposerForm();

            public void Execute(Panel i_Panel, User i_CurrentUser, Builder i_Builder)
            {
                m_ComposerForm.InfoToGet(i_Panel, i_CurrentUser, i_Builder);
                m_ComposerForm.groupFormBuilder();
                m_ComposerForm.ShowDialog();
            }
        }

        public class CreateEventFormCommand : ICommandCreateForm
        {
            public ComposerForm m_ComposerForm = new ComposerForm();

            public void Execute(Panel i_Panel, User i_CurrentUser, Builder i_Builder)
            {
                m_ComposerForm.InfoToGet(i_Panel, i_CurrentUser, i_Builder);
                m_ComposerForm.eventsFormBuilder();
                m_ComposerForm.ShowDialog();
            }
        }
    }
}

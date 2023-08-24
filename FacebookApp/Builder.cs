using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookWinFormApp
{
    public enum eAlbumInfo
    {
        AlbumCoverPhoto,
        AlbumNumberOfPhotos,
        AlbumTimeCreated,
        AlbumLastUpdated,
        AlbumAmountOfLikes
    }

    public enum eGroupInfo
    {
        GroupCoverPhoto,
        GroupDescription,
        GroupLastUpdated,
        GroupOwner
    }

    public enum eEventInfo
    {
        EventCoverPhoto,
        EventDescription,
        EventStartTime,
        EventEndTime
    }

    public class Builder
    {
        private User m_CurrentUser = new User();

        public event Action<Album> ShowName;

        public void BuildAlbumPanel(Panel i_Panel, List<object> i_AlbumInfos, User i_CurrentUser)
        {
            i_Panel.Controls.Clear();
            m_CurrentUser = i_CurrentUser;
            int countAlbums = 0;
            int countLines = 0;
            int amountOfInfo = 0;
            foreach (Album album in i_CurrentUser.Albums)
            {
                int previousAmountOfInfo = amountOfInfo;
                if (i_AlbumInfos.Contains(eAlbumInfo.AlbumCoverPhoto))
                {
                    amountOfInfo = 0;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(130, 140);
                    pictureBox.LoadAsync(album.PictureAlbumURL);
                    pictureBox.Location = new Point(countAlbums * 138, countLines * 145);
                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(pictureBox)));
                }

                Label labelName = new Label();
                labelName.Text = "Name:" + album.Name;
                if (i_AlbumInfos.Contains(eAlbumInfo.AlbumCoverPhoto))
                {
                    labelName.Location = new Point(132 + (140 * countAlbums), countLines * 145);
                }
                else
                {
                    labelName.Location = new Point(140 * countAlbums, amountOfInfo);
                }

                labelName.Size = new Size(140, 15);
                labelName.Click += labelAlbumName_Click;
                i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelName)));
                amountOfInfo += 15;
                if (i_AlbumInfos.Contains(eAlbumInfo.AlbumAmountOfLikes))
                {
                    Label labelLikes = new Label();
                    labelLikes.Text = "Amount of likes:" + album.LikedBy.Count();
                    labelLikes.Size = new Size(140, 15);
                    if (i_AlbumInfos.Contains(eAlbumInfo.AlbumCoverPhoto))
                    {
                        labelLikes.Location = new Point(132 + (140 * countAlbums), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelLikes.Location = new Point(140 * countAlbums, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelLikes)));
                    amountOfInfo += 15;
                }

                if (i_AlbumInfos.Contains(eAlbumInfo.AlbumTimeCreated))
                {
                    Label labelTimeCreated = new Label();
                    labelTimeCreated.Text = "Time Created:" + album.CreatedTime;
                    labelTimeCreated.Size = new Size(140, 15);
                    if (i_AlbumInfos.Contains(eAlbumInfo.AlbumCoverPhoto))
                    {
                        labelTimeCreated.Location = new Point(132 + (140 * countAlbums), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelTimeCreated.Location = new Point(140 * countAlbums, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelTimeCreated)));
                    amountOfInfo += 15;
                }

                if (i_AlbumInfos.Contains(eAlbumInfo.AlbumNumberOfPhotos))
                {
                    Label labelNumberOfPhotos = new Label();
                    labelNumberOfPhotos.Text = "Number Of Photos:" + album.Photos.Count();
                    labelNumberOfPhotos.Size = new Size(140, 15);
                    if (i_AlbumInfos.Contains(eAlbumInfo.AlbumCoverPhoto))
                    {
                        labelNumberOfPhotos.Location = new Point(132 + (140 * countAlbums), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelNumberOfPhotos.Location = new Point(140 * countAlbums, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelNumberOfPhotos)));
                    amountOfInfo += 15;
                }

                if (i_AlbumInfos.Contains(eAlbumInfo.AlbumLastUpdated))
                {
                    Label labelLastUpdated = new Label();
                    labelLastUpdated.Text = "Last Updated:" + album.UpdateTime;
                    labelLastUpdated.Size = new Size(140, 15);
                    if (i_AlbumInfos.Contains(eAlbumInfo.AlbumCoverPhoto))
                    {
                        labelLastUpdated.Location = new Point(132 + (140 * countAlbums), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelLastUpdated.Location = new Point(140 * countAlbums, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelLastUpdated)));
                }

                countAlbums += i_AlbumInfos.Contains(eAlbumInfo.AlbumCoverPhoto) ? 2 : 1;
                if (i_Panel.Width - (countAlbums * 150) < countAlbums * 150)
                {
                    countLines++;
                    countAlbums = 0;
                    if (!i_AlbumInfos.Contains(eAlbumInfo.AlbumCoverPhoto))
                    {
                        previousAmountOfInfo = amountOfInfo + 20;
                    }
                }

                if (!i_AlbumInfos.Contains(eAlbumInfo.AlbumCoverPhoto))
                {
                    amountOfInfo = previousAmountOfInfo;
                }
            }
        }

        public void BuildGroupPanel(Panel i_Panel, List<object> i_GroupInfos, User i_CurrentUser)
        {
            i_Panel.Controls.Clear();
            m_CurrentUser = i_CurrentUser;
            int countGroups = 0;
            int countLines = 0;
            int amountOfInfo = 0;
            foreach (Group group in i_CurrentUser.Groups)
            {
                int previousAmountOfInfo = amountOfInfo;
                if (i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                {
                    amountOfInfo = 0;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(130, 140);
                    pictureBox.LoadAsync(group.PictureNormalURL);
                    pictureBox.Location = new Point(countGroups * 138, countLines * 145);
                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(pictureBox)));
                }

                Label labelName = new Label();
                labelName.Text = "Name:" + group.Name;
                if (i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                {
                    labelName.Location = new Point(132 + (140 * countGroups), countLines * 145);
                }

                else
                {
                    labelName.Location = new Point(140 * countGroups, amountOfInfo);
                }

                labelName.Size = new Size(140, 15);
                i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelName)));
                amountOfInfo += 15;
                if (i_GroupInfos.Contains(eGroupInfo.GroupDescription))
                {
                    Label labelDescription = new Label();
                    labelDescription.Text = "Description:" + group.Description;
                    labelDescription.Size = new Size(140, 15);
                    if (i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                    {
                        labelDescription.Location = new Point(132 + (140 * countGroups), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelDescription.Location = new Point(140 * countGroups, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelDescription)));
                    amountOfInfo += 15;
                }

                if (i_GroupInfos.Contains(eGroupInfo.GroupLastUpdated))
                {
                    Label labelLastUpdated = new Label();
                    labelLastUpdated.Text = "Last Updated:" + group.UpdateTime;
                    labelLastUpdated.Size = new Size(140, 15);
                    if (i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                    {
                        labelLastUpdated.Location = new Point(132 + (140 * countGroups), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelLastUpdated.Location = new Point(140 * countGroups, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelLastUpdated)));
                    amountOfInfo += 15;
                }

                if (i_GroupInfos.Contains(eGroupInfo.GroupOwner))
                {
                    Label labelGroupOwner = new Label();
                    labelGroupOwner.Text = "Group Owner:" + group.Owner;
                    labelGroupOwner.Size = new Size(140, 15);
                    if (i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                    {
                        labelGroupOwner.Location = new Point(132 + (140 * countGroups), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelGroupOwner.Location = new Point(140 * countGroups, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelGroupOwner)));
                }

                countGroups += i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto) ? 2 : 1;
                if (i_Panel.Width - (countGroups * 150) < countGroups * 150)
                {
                    countLines++;
                    countGroups = 0;
                    if (!i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                    {
                        previousAmountOfInfo = amountOfInfo + 20;
                    }
                }

                if (!i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                {
                    amountOfInfo = previousAmountOfInfo;
                }
            }
        }

        public void BuildEventPanel(Panel i_Panel, List<object> i_EventInfo, User i_CurrentUser)
        {
            i_Panel.Controls.Clear();
            m_CurrentUser = i_CurrentUser;
            int countEvents = 0;
            int countLines = 0;
            int amountOfInfo = 0;
            foreach (Event thisEvent in i_CurrentUser.Events)
            {
                int previousAmountOfInfo = amountOfInfo;
                if (i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                {
                    amountOfInfo = 0;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(130, 140);
                    pictureBox.LoadAsync(thisEvent.PictureNormalURL);
                    pictureBox.Location = new Point(countEvents * 138, countLines * 145);
                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(pictureBox)));
                }

                Label labelName = new Label();
                labelName.Text = "Name:" + thisEvent.Name;
                if (i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                {
                    labelName.Location = new Point(132 + (140 * countEvents), countLines * 145);
                }

                else
                {
                    labelName.Location = new Point(140 * countEvents, amountOfInfo);
                }

                labelName.Size = new Size(140, 15);
                i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelName)));
                amountOfInfo += 15;
                if (i_EventInfo.Contains(eEventInfo.EventDescription))
                {
                    Label labelDescription = new Label();
                    labelDescription.Text = "Description:" + thisEvent.Description;
                    labelDescription.Size = new Size(140, 15);
                    if (i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                    {
                        labelDescription.Location = new Point(132 + (140 * countEvents), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelDescription.Location = new Point(140 * countEvents, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelDescription)));
                    amountOfInfo += 15;
                }

                if (i_EventInfo.Contains(eEventInfo.EventStartTime))
                {
                    Label labelStartTime = new Label();
                    labelStartTime.Text = "Start Time:" + thisEvent.StartTime;
                    labelStartTime.Size = new Size(140, 15);
                    if (i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                    {
                        labelStartTime.Location = new Point(132 + (140 * countEvents), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelStartTime.Location = new Point(140 * countEvents, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelStartTime)));
                    amountOfInfo += 15;
                }

                if (i_EventInfo.Contains(eEventInfo.EventEndTime))
                {
                    Label labelEndTime = new Label();
                    labelEndTime.Text = "End Time:" + thisEvent.EndTime;
                    labelEndTime.Size = new Size(140, 15);
                    if (i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                    {
                        labelEndTime.Location = new Point(132 + (140 * countEvents), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelEndTime.Location = new Point(140 * countEvents, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelEndTime)));
                    amountOfInfo += 15;
                }

                countEvents += i_EventInfo.Contains(eEventInfo.EventCoverPhoto) ? 2 : 1;
                if (i_Panel.Width - (countEvents * 150) < countEvents * 150)
                {
                    countLines++;
                    countEvents = 0;
                    if (!i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                    {
                        previousAmountOfInfo = amountOfInfo + 20;
                    }
                }

                if (!i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                {
                    amountOfInfo = previousAmountOfInfo;
                }
            }
        }

        public void Builder_ShowName(Album i_Album)
        {
            OnShowName(i_Album);
        }

        private void OnShowName(Album i_Album)
        {
            if (ShowName != null)
            {
                ShowName.Invoke(i_Album);
            }
        }

        private void labelAlbumName_Click(object sender, EventArgs e)
        {
            foreach (Album album in m_CurrentUser.Albums)
            {
                if (string.Equals((sender as Label).Text.Remove(0, 5), album.Name))
                {
                    ShowName(album);
                    break;
                }
            }
        }

        public class BuildAlbumPanelCommand : ICommandBuildPanel
        {
            private Builder m_Builder = new Builder();

            public void Execute(Panel i_Panel, List<object> i_UserInfo, User i_CurrentUser, Builder i_Builder)
            {
                m_Builder.ShowName = i_Builder.ShowName;
                m_Builder.BuildAlbumPanel(i_Panel, i_UserInfo, i_CurrentUser);
            }
        }

        public class BuildGroupPanelCommand : ICommandBuildPanel
        {
            private Builder m_Builder = new Builder();

            public void Execute(Panel i_Panel, List<object> i_UserInfo, User i_CurrentUser, Builder i_Builder)
            {
                m_Builder.BuildGroupPanel(i_Panel, i_UserInfo, i_CurrentUser);
            }
        }

        public class BuildEventPanelCommand : ICommandBuildPanel
        {
            private Builder m_Builder = new Builder();

            public void Execute(Panel i_Panel, List<object> i_UserInfo, User i_CurrentUser, Builder i_Builder)
            {
                m_Builder.BuildEventPanel(i_Panel, i_UserInfo, i_CurrentUser);
            }
        }
    }
}

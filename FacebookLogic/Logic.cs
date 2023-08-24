using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading;
using FacebookLogic.Iterator;
using FacebookLogic.Strategy;


namespace FacebookLogic
{
    public class Logic
    {
        public static LoginResult s_LoginResult { get; set; }
        public static User s_LoggedInUser { get; set; }
        public static AppSettings s_AppSetings;
        private Adapter.ISocialNetworks m_FBAdapter = new Adapter.FacebookAdapter();
        public static StrategySorter m_PostsSorter = new Strategy.StrategySorter(new AZSortStrategy());
        public IAggregateT<User> m_UserFriendsAggregate;
        public IIteratorT<User> m_UserFriendsIterator;

        public static bool IsConnectToFacebook()
        {
            bool isConnected = false;

            if (s_AppSetings.m_RememberUser && !string.IsNullOrEmpty(s_AppSetings.m_AccessToken))
            {
                s_LoginResult = FacebookService.Connect(s_AppSetings.m_AccessToken);
                s_LoggedInUser = s_LoginResult.LoggedInUser;
                isConnected = true;
            }

            return isConnected;
        }

        public static void RememberUser()
        {
            if (s_AppSetings.m_RememberUser)
            {
                s_AppSetings.SaveDataToFile(s_LoginResult.AccessToken);
                s_AppSetings.m_AccessToken = s_LoginResult.AccessToken;
            }

            else
            {
                s_AppSetings.DeleteFile();
                s_AppSetings.m_AccessToken = null;
            }
        }

        public bool CheckAccessToken()
        {
            bool isAccessTokenOK = false;
            (m_FBAdapter as Adapter.FacebookAdapter).LogIn();
            s_LoggedInUser = (this.m_FBAdapter as Adapter.FacebookAdapter).LoggedInUser;
            s_LoginResult = (this.m_FBAdapter as Adapter.FacebookAdapter).LogInResult;

            if (!string.IsNullOrEmpty(s_LoginResult.AccessToken))
            {
                s_LoggedInUser = s_LoginResult.LoggedInUser;
                isAccessTokenOK = true;
            }

            return isAccessTokenOK;
        }

        public static List<Photo> CreatePopularPhotosList()
        {
            List<int> max = new List<int> { 0, 0, 0, };
            List<Photo> photosList = new List<Photo>();

            foreach (Album album in Logic.s_LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (photo.LikedBy.Count() > max[2])
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (photo.LikedBy.Count() > max[i])
                            {
                                max.RemoveAt(i);
                                max.Insert(i, photo.LikedBy.Count());
                                photosList.Insert(i, photo);
                            }
                        }
                    }
                }
            }

            return photosList;
        }

        public bool CheckIfFriendIsGoodLiker(string i_NameToCheck)
        {
            int likesCounter = 0;
            int photosCounter = 0;
            bool isGoodLiker = false;

            if (checkIfUserIsFriend(i_NameToCheck))
            {
                foreach (Album album in s_LoggedInUser.Albums)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        foreach (User user in photo.LikedBy)
                        {
                            if (string.Compare(i_NameToCheck, user.Name) == 0)
                            {
                                likesCounter++;
                            }
                        }
                    }

                    photosCounter++;
                }

                if (likesCounter > photosCounter / 2)
                {
                    isGoodLiker = true;
                }

                return isGoodLiker;
            }

            else
            {
                throw new Exception("This user is not a friend");
            }
        }

        private bool checkIfUserIsFriend(string i_NameToCheck)
        {
            bool isFriend = false;
            m_UserFriendsAggregate = new UserAggregate(s_LoggedInUser);
            m_UserFriendsIterator = m_UserFriendsAggregate.CreateIterator();

            foreach (User friend in m_UserFriendsIterator.NextItem)
            {
                if (string.Compare(friend.Name, i_NameToCheck) == 0)
                {
                    isFriend = true;
                }
            }

            return isFriend;
        }

        public static List<Page> CreateUserLikePagesList()
        {
            List<Page> likedPagesList = new List<Page>();

            if (s_LoggedInUser.LikedPages.Count > 0)
            {
                foreach (Page simplePage in s_LoggedInUser.LikedPages)
                {
                    likedPagesList.Add(simplePage);
                }

                return likedPagesList;
            }

            else
            {
                throw new Exception("No liked pages to retrieve :(");
            }
        }
    }
}
































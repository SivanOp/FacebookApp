using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookLogic.Adapter
{
    public class FacebookAdapter : ISocialNetworks
    {
        public LoginResult LogInResult { get; set; }

        public User LoggedInUser { get; set; }

        public FacebookAdapter()
        {
        }

        public void LogIn()
        {
            this.LogInResult = FacebookService.Login(
                    "714412376288619",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos",
                    "groups_access_member_info");

            if (!string.IsNullOrEmpty(LogInResult.AccessToken))
            {
                LoggedInUser = LogInResult.LoggedInUser;
            }

        }
    }
}

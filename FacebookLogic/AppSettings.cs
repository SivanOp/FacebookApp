using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;

namespace FacebookLogic
{
    public class AppSettings
    {
        public Point m_WindowLocation { get; set; }

        public Size m_WindowSize { get; set; }

        public bool m_RememberUser { get; set; }

        public string m_AccessToken { get; set; }

        private AppSettings()
        {
            m_WindowLocation = new Point(100, 50);
            m_WindowSize = new Size(940, 1000);
            m_RememberUser = false;
            m_AccessToken = null;
        }

        public static AppSettings LoadDataFromFile()
        {
            AppSettings obj = new AppSettings();

            if(File.Exists(@"UserData.xml"))
            {
                using(Stream stream = new FileStream(@"UserData.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return obj;
        }

        public void SaveDataToFile(string i_UserAccessToken)
        {
            if(!File.Exists(@"UserData.xml"))
            {
                using (Stream stream = new FileStream(@"UserData.xml", FileMode.Create))
                {
                    m_AccessToken = i_UserAccessToken;
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using(Stream stream = new FileStream(@"UserData.xml", FileMode.Truncate))
                {
                    m_AccessToken = i_UserAccessToken;
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }

        public void DeleteFile()
        {
            if(File.Exists(@"UserData.xml"))
            {
                File.Delete(@"UserData.xml");
            }
        }
    }
}

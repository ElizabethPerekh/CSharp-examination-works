using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace wpf_hw_Quiz.Model
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string login, string password) 
        {
            Login = login;
            Password = password;
        }

        public User() { }

        public static List<User> LoadUsers ()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>), new XmlRootAttribute("Users"));
                using (FileStream fs = new FileStream("users.xml", FileMode.OpenOrCreate))
                {
                    return (List<User>)serializer.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
    }
}
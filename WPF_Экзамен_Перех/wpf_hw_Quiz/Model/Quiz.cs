using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Xml.Serialization;
using wpf_hw_Quiz.Model;


namespace wpf_hw_Quiz.Model
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public string Name { get; set; }
      
        public Quiz(List<Question> questions, string name)
        {
            Questions = questions;
            Name = name;
        }

        public Quiz() : this(new List<Question>(), string.Empty) { }

        public static Quiz LoadQuiz(string filePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Quiz));
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    return (Quiz)serializer.Deserialize(fs);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__8__quiz_creation_.ViewModel
{

    public class QuizFile
    {
        public string FileName { get; set; }
        public string Topic { get; set; }
    }
    internal class QuizListViewModel
    {
        List<QuizFile> quizFiles { get; set; }

        public QuizListViewModel()
        {
            new QuizFile() { FileName = "Test.xml", Topic = "asdraasd" };
            new QuizFile() { FileName = "Test.xml", Topic = "asdraasd" };
            new QuizFile() { FileName = "Test.xml", Topic = "asdraasd" };
        }

        public void StarQuizHandler (object obj)
        {
            //
            //
            //
            //
        
            //
        }
    }
}

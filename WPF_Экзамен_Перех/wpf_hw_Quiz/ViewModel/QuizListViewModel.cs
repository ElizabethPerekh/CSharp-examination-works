using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using wpf_hw_Quiz.Model;

namespace wpf_hw_Quiz.ViewModel
{
    public class QuizFile
    {
        public string FileName { get; set; }
        public string QuizName { get; set; }
        public string Topic { get; set; }
    }

    internal class QuizListViewModel
    {
        public List<QuizFile> QuizFiles { get; set; }
        public ICommand StartQuizCommand { get; set; }
        private User _currentUser;
        private Window _window;

        public QuizListViewModel(User currentUser, Window window)
        {
            _currentUser = currentUser;
            _window = window;

            QuizFiles = new List<QuizFile>
        {
            new QuizFile() { FileName = "Викторина 1.xml", QuizName = "Викторина 1", Topic = "Тема: Викторина 1" },
            new QuizFile() { FileName = "Викторина 2.xml", QuizName = "Викторина 2", Topic = "Тема: Викторина 2" },
            new QuizFile() { FileName = "Викторина 3.xml", QuizName = "Викторина 3", Topic = "Тема: Викторина 3" }
        };

            StartQuizCommand = new DelegateCommand(StartQuizHandler);
        }

        public void StartQuizHandler(object obj)
        {
            if (obj is QuizFile selectedQuiz)
            {
                var quizWindow = new MainWindow(selectedQuiz.FileName, _currentUser);
                quizWindow.Show();
                _window.Close();
            }
        }
    }
}
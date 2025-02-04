using Homework__8__quiz_creation_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.IO;
using System.Xml.Serialization;

namespace Homework__8__quiz_creation_.ViewModel
{
    public class QuizViewModel : INotifyPropertyChanged
    {
        private Window _window;

        public QuizViewModel (Window window)
        {
            _window = window;
            CurrentQuestion = new Question();
            CurrentQuiz = new Quiz(new List<Question>(), string.Empty);
            AddQuestionCommand = new DelegateCommand(AddQuestionHandler);
            ExportToXMLCommand = new DelegateCommand(ExportToXMLCommandHandler);
        }

        private Question _currentQuestion;

        public Question CurrentQuestion
        {
            get { return _currentQuestion; }
            set 
            { 
                _currentQuestion = value;
                OnPropertyChanged("CurrentQuestion");
            }
        }

        private Quiz _currentQuiz;

        public Quiz CurrentQuiz
        {
            get { return _currentQuiz; }
            set
            {
                _currentQuiz = value;
                OnPropertyChanged("CurrentQuiz");
            }
        }

        public ICommand AddQuestionCommand { get; set; }
        public ICommand ExportToXMLCommand { get; set; }

        public void AddQuestionHandler(Object obj)
        {
            try
            {
               // MessageBox.Show(CurrentQuestion.Answers[0].Text);
                CurrentQuiz.Questions.Add(CurrentQuestion);

                Quiz temp = CurrentQuiz;
                CurrentQuiz = null;
                CurrentQuiz = temp;
                CurrentQuestion = new Question();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.ToString());
            }
        }

        public void ExportToXMLCommandHandler(Object obj)
        {
            try
            {
                string fileName = $"{CurrentQuiz.Name}.xml";
                using (var stream = new FileStream(fileName, FileMode.Create))
                {
                    var serlizer = new XmlSerializer(typeof(Quiz));
                    serlizer.Serialize(stream, CurrentQuiz);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при сохранении данных: " + ex.Message);
            }
        }

        public void SetCorrectAnswer(int index)
        {
            for (int i = 0; i < 3; i++)
            {
                CurrentQuestion.Answers[i].IsCorrect = (index == i);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}


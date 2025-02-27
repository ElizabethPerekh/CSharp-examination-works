﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using wpf_hw_Quiz.Model;
using wpf_hw_Quiz.ViewModel;

namespace wpf_hw_Quiz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private QuizViewModel _viewModel;

        public MainWindow(string quizFileName, User currentUser)
        {
            InitializeComponent();
            _viewModel = new QuizViewModel(this, currentUser, quizFileName);
            this.DataContext = _viewModel;
        }
    }
}
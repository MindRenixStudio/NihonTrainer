using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Nihon_Trainee.Dictionary;
using Nihon_Trainee.CodeBehind;

namespace Nihon_Trainee.Pages
{
    /// <summary>
    /// Interakční logika pro VocabularyGreeting_Page.xaml
    /// </summary>
    public partial class VocabularyGreeting_Page : Page
    {
        public List<Dictionary_Type> GreetingsList = new List<Dictionary_Type>();
        public Vocabulary_Greetings_Quiz GreetingsQuiz = new Vocabulary_Greetings_Quiz();

        public VocabularyGreeting_Page()
        {
            InitializeComponent();

            TrainingProgress.Value = 0;

            Vocabulary_Dict VocabDict = new Vocabulary_Dict();
            GreetingsList = VocabDict.GreetingsVocab();

            GreetingsQuiz.SelectGuessAnswers(GreetingsList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
        }

        private void BT1_Click(object sender, RoutedEventArgs e)
        {
            if (RightAnswer.Content.ToString() == "1")
            {
                int ARightInt = Int32.Parse(ARight.Content.ToString());

                ARightInt += 1;
                TrainingProgress.Value += 1;
                ARight.Content = ARightInt;

                GreetingsQuiz.SelectGuessAnswers(GreetingsList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
            else
            {
                int AWrongInt = Int32.Parse(AWrong.Content.ToString());

                AWrongInt += 1;
                TrainingProgress.Value += 1;
                AWrong.Content = AWrongInt;

                GreetingsQuiz.SelectGuessAnswers(GreetingsList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
        }

        private void BT2_Click(object sender, RoutedEventArgs e)
        {
            if (RightAnswer.Content.ToString() == "2")
            {
                int ARightInt = Int32.Parse(ARight.Content.ToString());

                ARightInt += 1;
                TrainingProgress.Value += 1;
                ARight.Content = ARightInt;

                GreetingsQuiz.SelectGuessAnswers(GreetingsList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
            else
            {
                int AWrongInt = Int32.Parse(AWrong.Content.ToString());

                AWrongInt += 1;
                TrainingProgress.Value += 1;
                AWrong.Content = AWrongInt;

                GreetingsQuiz.SelectGuessAnswers(GreetingsList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
        }

        private void BT3_Click(object sender, RoutedEventArgs e)
        {
            if (RightAnswer.Content.ToString() == "3")
            {
                int ARightInt = Int32.Parse(ARight.Content.ToString());

                ARightInt += 1;
                TrainingProgress.Value += 1;
                ARight.Content = ARightInt;

                GreetingsQuiz.SelectGuessAnswers(GreetingsList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
            else
            {
                int AWrongInt = Int32.Parse(AWrong.Content.ToString());

                AWrongInt += 1;
                TrainingProgress.Value += 1;
                AWrong.Content = AWrongInt;

                GreetingsQuiz.SelectGuessAnswers(GreetingsList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
        }

        private void BT4_Click(object sender, RoutedEventArgs e)
        {
            if (RightAnswer.Content.ToString() == "4")
            {
                int ARightInt = Int32.Parse(ARight.Content.ToString());

                ARightInt += 1;
                TrainingProgress.Value += 1;
                ARight.Content = ARightInt;

                GreetingsQuiz.SelectGuessAnswers(GreetingsList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
            else
            {
                int AWrongInt = Int32.Parse(AWrong.Content.ToString());

                AWrongInt += 1;
                TrainingProgress.Value += 1;
                AWrong.Content = AWrongInt;

                GreetingsQuiz.SelectGuessAnswers(GreetingsList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
        }

    }
}

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
    /// Interakční logika pro Katakana_Page.xaml
    /// </summary>
    public partial class Katakana_Page : Page
    {
        public List<List_Type> KatakanaList = new List<List_Type>();
        public Katakana_Quiz KQuiz = new Katakana_Quiz();

        public Katakana_Page()
        {
            InitializeComponent();

            TrainingProgress.Value = 0;

            Katakana_Dict KDict = new Katakana_Dict();
            KatakanaList = KDict.Katakana();

            KQuiz.SelectGuessAnswers(KatakanaList, GuessLabel, RightAnswer, BT1, BT2, BT3, BT4);
        }

        private void BT1_Click(object sender, RoutedEventArgs e)
        {
            if (RightAnswer.Content.ToString() == "1")
            {
                int ARightInt = Int32.Parse(ARight.Content.ToString());

                ARightInt += 1;
                TrainingProgress.Value += 1;
                ARight.Content = ARightInt;

                KQuiz.SelectGuessAnswers(KatakanaList, GuessLabel, RightAnswer, BT1, BT2, BT3, BT4);
            }
            else
            {
                int AWrongInt = Int32.Parse(AWrong.Content.ToString());

                AWrongInt += 1;
                TrainingProgress.Value += 1;
                AWrong.Content = AWrongInt;

                KQuiz.SelectGuessAnswers(KatakanaList, GuessLabel, RightAnswer, BT1, BT2, BT3, BT4);
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

                KQuiz.SelectGuessAnswers(KatakanaList, GuessLabel, RightAnswer, BT1, BT2, BT3, BT4);
            }
            else
            {
                int AWrongInt = Int32.Parse(AWrong.Content.ToString());

                AWrongInt += 1;
                TrainingProgress.Value += 1;
                AWrong.Content = AWrongInt;

                KQuiz.SelectGuessAnswers(KatakanaList, GuessLabel, RightAnswer, BT1, BT2, BT3, BT4);
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

                KQuiz.SelectGuessAnswers(KatakanaList, GuessLabel, RightAnswer, BT1, BT2, BT3, BT4);
            }
            else
            {
                int AWrongInt = Int32.Parse(AWrong.Content.ToString());

                AWrongInt += 1;
                TrainingProgress.Value += 1;
                AWrong.Content = AWrongInt;

                KQuiz.SelectGuessAnswers(KatakanaList, GuessLabel, RightAnswer, BT1, BT2, BT3, BT4);
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

                KQuiz.SelectGuessAnswers(KatakanaList, GuessLabel, RightAnswer, BT1, BT2, BT3, BT4);
            }
            else
            {
                int AWrongInt = Int32.Parse(AWrong.Content.ToString());

                AWrongInt += 1;
                TrainingProgress.Value += 1;
                AWrong.Content = AWrongInt;

                KQuiz.SelectGuessAnswers(KatakanaList, GuessLabel, RightAnswer, BT1, BT2, BT3, BT4);
            }
        }
    }
}

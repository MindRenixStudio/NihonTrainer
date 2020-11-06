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
    /// Interakční logika pro Kanji_Page.xaml
    /// </summary>
    public partial class Kanji_Page : Page
    {
        public List<Kanji_Type> KanjiList = new List<Kanji_Type>();
        public Kanji_Quiz KjQuiz = new Kanji_Quiz();

        public Kanji_Page()
        {
            InitializeComponent();

            TrainingProgress.Value = 0;

            Kanji_Dict KjDict = new Kanji_Dict();
            KanjiList = KjDict.Kanji();

            KjQuiz.SelectGuessAnswers(KanjiList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
        }

        private void BT1_Click(object sender, RoutedEventArgs e)
        {
            if (RightAnswer.Content.ToString() == "1")
            {
                int ARightInt = Int32.Parse(ARight.Content.ToString());

                ARightInt += 1;
                TrainingProgress.Value += 1;
                ARight.Content = ARightInt;

                KjQuiz.SelectGuessAnswers(KanjiList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
            else
            {
                int AWrongInt = Int32.Parse(AWrong.Content.ToString());

                AWrongInt += 1;
                TrainingProgress.Value += 1;
                AWrong.Content = AWrongInt;

                KjQuiz.SelectGuessAnswers(KanjiList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
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

                KjQuiz.SelectGuessAnswers(KanjiList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
            else
            {
                int AWrongInt = Int32.Parse(AWrong.Content.ToString());

                AWrongInt += 1;
                TrainingProgress.Value += 1;
                AWrong.Content = AWrongInt;

                KjQuiz.SelectGuessAnswers(KanjiList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
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

                KjQuiz.SelectGuessAnswers(KanjiList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
            else
            {
                int AWrongInt = Int32.Parse(AWrong.Content.ToString());

                AWrongInt += 1;
                TrainingProgress.Value += 1;
                AWrong.Content = AWrongInt;

                KjQuiz.SelectGuessAnswers(KanjiList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
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

                KjQuiz.SelectGuessAnswers(KanjiList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
            else
            {
                int AWrongInt = Int32.Parse(AWrong.Content.ToString());

                AWrongInt += 1;
                TrainingProgress.Value += 1;
                AWrong.Content = AWrongInt;

                KjQuiz.SelectGuessAnswers(KanjiList, GuessLabel, RightAnswer, Meaning, BT1, BT2, BT3, BT4);
            }
        }
    }
}

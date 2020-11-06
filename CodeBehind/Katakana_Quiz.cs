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

namespace Nihon_Trainee.CodeBehind
{
    public class Katakana_Quiz
    {
        public void SelectGuessAnswers(List<List_Type> katakana_list, Label GuessLabel, Label RightAnswer, Button BT1, Button BT2, Button BT3, Button BT4)
        {
            Random rnd = new Random();

            int rightAnswer = rnd.Next(1, 5);

            int answer1 = rnd.Next(1, katakana_list.Count);
            int answer2 = rnd.Next(1, katakana_list.Count);

            int guessSelection = rnd.Next(katakana_list.Count);
            GuessLabel.Content = katakana_list[guessSelection].Character;

            RightAnswer.Content = rightAnswer;

            int answer3 = rnd.Next(1, katakana_list.Count);
            int answer4 = rnd.Next(1, katakana_list.Count);

            if (answer1 <= katakana_list.Count && answer3 > 4)
            {
                answer1 -= 2;
            }

            if (answer2 < katakana_list.Count - 3)
            {
                answer2 += 1;
            }

            if (answer3 <= katakana_list.Count && answer3 > 4)
            {
                answer3 -= 3;
            }

            BT1.Content = katakana_list[answer1].Romaji;
            BT2.Content = katakana_list[answer2].Romaji;
            BT3.Content = katakana_list[answer3].Romaji;
            BT4.Content = katakana_list[answer4].Romaji;

            if (rightAnswer == 1)
            {
                BT1.Content = katakana_list[guessSelection].Romaji;
            }
            if (rightAnswer == 2)
            {
                BT2.Content = katakana_list[guessSelection].Romaji;
            }
            if (rightAnswer == 3)
            {
                BT3.Content = katakana_list[guessSelection].Romaji;
            }
            if (rightAnswer == 4)
            {
                BT4.Content = katakana_list[guessSelection].Romaji;
            }

        }
    }
}

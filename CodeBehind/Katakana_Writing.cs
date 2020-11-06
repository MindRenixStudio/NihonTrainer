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

namespace Nihon_Trainee.CodeBehind
{
    public class Katakana_Writing
    {
        public void KatakanaCharWrite(List<List_Type> katakana_list, Label GuessLabel, Label Meaning)
        {
            Random rnd = new Random();
            int katakanaInt = rnd.Next(katakana_list.Count);

            GuessLabel.Content = katakana_list[katakanaInt].Romaji;
            Meaning.Content = katakana_list[katakanaInt].Character;

            Meaning.Background = Brushes.Black;
        }

        public void KatakanaWriteSwitch(Label GuessLabel, Label Meaning)
        {
            string guessLabel = GuessLabel.Content.ToString();
            string meaning = Meaning.Content.ToString();

            GuessLabel.Content = meaning;
            Meaning.Content = guessLabel;

            Meaning.Background = Brushes.White;
        }
    }
}

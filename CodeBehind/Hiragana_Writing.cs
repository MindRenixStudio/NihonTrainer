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
    public class Hiragana_Writing
    {
        public void HiraganaCharWrite(List<List_Type> hiragana_list, Label GuessLabel, Label Meaning)
        {
            Random rnd = new Random();
            int hiraganaInt = rnd.Next(hiragana_list.Count);

            GuessLabel.Content = hiragana_list[hiraganaInt].Romaji;
            Meaning.Content = hiragana_list[hiraganaInt].Character;

            Meaning.Background = Brushes.Black;
        }
        public void HiraganaWriteSwitch(Label GuessLabel, Label Meaning)
        {
            string guessLabel = GuessLabel.Content.ToString();
            string meaning = Meaning.Content.ToString();

            GuessLabel.Content = meaning;
            Meaning.Content = guessLabel;

            Meaning.Background = Brushes.White;
        }
    }
}

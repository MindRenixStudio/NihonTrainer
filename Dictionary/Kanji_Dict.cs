using System;
using System.Collections.Generic;
using System.Text;

namespace Nihon_Trainee.Dictionary
{
    public class Kanji_Dict
    {
        public List<Kanji_Type> Kanji()
        {
            List<Kanji_Type> Kanji = new List<Kanji_Type>();

            Kanji.Add(new Kanji_Type { Character = "人", Romaji = "Hito", Trans = "Person"});
            Kanji.Add(new Kanji_Type { Character = "男", Romaji = "Otoko", Trans = "Man, Boy" });
            Kanji.Add(new Kanji_Type { Character = "女", Romaji = "Onna", Trans = "Woman, Girl" });
            Kanji.Add(new Kanji_Type { Character = "子", Romaji = "Ko", Trans = "Child" });
            Kanji.Add(new Kanji_Type { Character = "母", Romaji = "Haha", Trans = "Mother" });
            Kanji.Add(new Kanji_Type { Character = "父", Romaji = "Chichi", Trans = "Father" });
            Kanji.Add(new Kanji_Type { Character = "友", Romaji = "Tomo", Trans = "Friend" });
            Kanji.Add(new Kanji_Type { Character = "火", Romaji = "Hi", Trans = "Fire" });
            Kanji.Add(new Kanji_Type { Character = "水", Romaji = "Mizu", Trans = "Water" });
            Kanji.Add(new Kanji_Type { Character = "木", Romaji = "Ki", Trans = "Tree" });
            Kanji.Add(new Kanji_Type { Character = "土", Romaji = "Tsuchi", Trans = "Earth" });
            Kanji.Add(new Kanji_Type { Character = "金", Romaji = "Kane", Trans = "Money" });
            Kanji.Add(new Kanji_Type { Character = "本", Romaji = "Moto", Trans = "Book" });
            Kanji.Add(new Kanji_Type { Character = "川", Romaji = "Kawa", Trans = "River" });
            Kanji.Add(new Kanji_Type { Character = "花", Romaji = "Hana", Trans = "Flower" });
            Kanji.Add(new Kanji_Type { Character = "気", Romaji = "Ki, Ke", Trans = "Spirit" });
            Kanji.Add(new Kanji_Type { Character = "生", Romaji = "Ikiru", Trans = "Live, To live" });
            Kanji.Add(new Kanji_Type { Character = "魚", Romaji = "Sakana", Trans = "Fish" });
            Kanji.Add(new Kanji_Type { Character = "天", Romaji = "Ame", Trans = "Heaven" });
            Kanji.Add(new Kanji_Type { Character = "空", Romaji = "Sora", Trans = "Sky" });
            Kanji.Add(new Kanji_Type { Character = "山", Romaji = "Yama", Trans = "Mountain" });
            Kanji.Add(new Kanji_Type { Character = "雨", Romaji = "Ame", Trans = "Rain" });
            Kanji.Add(new Kanji_Type { Character = "電", Romaji = "Den", Trans = "Electricity" });
            Kanji.Add(new Kanji_Type { Character = "車", Romaji = "Kuroma", Trans = "Car" });
            Kanji.Add(new Kanji_Type { Character = "語", Romaji = "Kata", Trans = "Language" });
            Kanji.Add(new Kanji_Type { Character = "耳", Romaji = "Mimi", Trans = "Ear" });
            Kanji.Add(new Kanji_Type { Character = "手", Romaji = "Te", Trans = "Hand" });
            Kanji.Add(new Kanji_Type { Character = "足", Romaji = "Ashi", Trans = "Foot" });
            Kanji.Add(new Kanji_Type { Character = "目", Romaji = "Me", Trans = "Eye" });
            Kanji.Add(new Kanji_Type { Character = "口", Romaji = "Kuchi", Trans = "Mouth" });
            Kanji.Add(new Kanji_Type { Character = "名", Romaji = "Na", Trans = "Name" });

            return Kanji;
        }
    }
}

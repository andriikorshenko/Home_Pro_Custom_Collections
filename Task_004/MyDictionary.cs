using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_004
{
    internal class MyDictionary
    {
        private List<Word> _myDictionary;

        public MyDictionary()
        {
            _myDictionary = new List<Word>();

            _myDictionary.Add(new Word("птах", "bird","птица"));
            _myDictionary.Add(new Word("кiт", "cat", "кот"));
            _myDictionary.Add(new Word("сонце", "sun", "солнце"));
            _myDictionary.Add(new Word("стiл", "table", "стол"));
            _myDictionary.Add(new Word("лiтак", "plane", "самолет"));
        }

        public void Translate(string word, string translatTo)
        {
            switch (translatTo)
            {
                case "eng":
                    {
                        var translateToEng = _myDictionary.Find(x => x.Ukr.Contains(word));

                        if (translateToEng != null)
                        {
                            Console.WriteLine($"Перевод украинского слова '{word}' на английский : "
                            + translateToEng.Eng);
                        }
                        else throw new ArgumentException("Нет английской версии для пеервода в словаре!");
                    }
                    break;

                case "rus":
                    {
                        var translateToRus = _myDictionary.Find(x => x.Ukr.Contains(word));

                        if (translateToRus != null)
                        {
                            Console.WriteLine($"Перевод украинского слова '{word}' на русский : "
                            + translateToRus.Rus);
                        }
                        else throw new ArgumentException("Нет русской версии для пеервода в словаре!");
                    }
                    break;

                default: throw new ArgumentException("Выбран неверный формат для перевода!");
            }
        }
    }
}

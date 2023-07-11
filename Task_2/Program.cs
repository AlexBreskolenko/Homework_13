/*Ваша задача — написать программу ,которая позволит понять, какие 10 слов чаще всего встречаются в тексте.
Подсказка
Для того чтобы убрать из текста знаки пунктуации, добавьте ссылку на пространство имён System.Linq и используйте следующий фрагмент кода:
var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
*/

using System.Linq;
using System.IO;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        string path = "C:\\Users\\abres\\Desktop\\Text1.txt";
        string text;

        using (StreamReader  sr = new StreamReader(path)) 
        {
            text = sr.ReadToEnd();
        }

        var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
        string[] splitted = noPunctuationText.Split(new char[] { ' ', '\n' });

        List<string> list = splitted.Cast<string>().ToList();

        list = list.Where(x => x != "").ToList();

        var grouppedWords = list.GroupBy(x => x).OrderByDescending(x => x.Count());

        for (int i = 0;i < 10; i++)
        {
            Console.WriteLine(grouppedWords.ElementAt(i).Key);
        }
    }
}

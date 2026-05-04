using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập họ tên: ");
        string input = Console.ReadLine();

        string result = ChuanHoaHoTen(input);

        Console.WriteLine("Chuỗi sau khi chuẩn hoá: " + result);
    }

    static string ChuanHoaHoTen(string str)
    {
        str = str.Trim();

        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i].ToLower();
            words[i] = char.ToUpper(word[0]) + word.Substring(1);
        }

        return string.Join(" ", words);
    }
}
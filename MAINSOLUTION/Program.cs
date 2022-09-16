

Console.Clear();

void BeepOnError()
{
    Console.Beep(800, 100);
    Console.Beep(600, 150);
    Console.Beep(400, 200);
}

string[] CreatArrFromKeyboardInString()
{
    Console.Write("Введите слова через пробел (также можно использовать '.' , ',' , ';' , '/' в качестве разделителей значений) в одну строку: ");
    Console.WriteLine();
    char[] sep = new char[] { ' ', ',', ';', '/', '.' };
    string[] input = Console.ReadLine()!.Split(sep, StringSplitOptions.RemoveEmptyEntries).ToArray();
    if (input.Length > 0) return input;

    else Console.WriteLine("Введите значение."); BeepOnError(); return null!;
}

string[] FindWordsUnderThree(string[] words)
{
    if (words != null)
    {
        int count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= 3)
                ++count;
        }
        string[] shortwords = new string[count];
        int num = 0;
        for (int i = 0; i < words.Length; i++)
            if (words[i].Length <= 3)
            {
                shortwords[num] = words[i];
                ++num;
            }
        return shortwords;
    }
    else Console.WriteLine("В метод передано нулевое значение массива"); return null!;
}

void PrintArray(string[] arr)
{
    if (arr != null)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(i < arr.Length - 1 ? $"\"{arr[i]}\", " : $"\"{arr[i]}\"");
        }
        Console.Write("]");
    }
    else
    {
        Console.WriteLine("Не переданы значения масcива для вывода на экран");
    }
}

string [] words = CreatArrFromKeyboardInString();

Console.WriteLine();

string [] shortwords = FindWordsUnderThree(words);

PrintArray(words);
if (shortwords!=null)Console.Write(" -> ");
PrintArray(shortwords!);
Console.WriteLine();


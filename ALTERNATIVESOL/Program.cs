// Альтернативное решение встроенными методами

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
if (words == null!) Console.WriteLine ("Нулевое значение."); 
else
{

    string[] shortwords = Array.FindAll(words, ele => ele.Length <= 3);
    
    // Еще один вариант, как можно.
    // string[] shortwords = words.OfType<string>().Where(item => item.Length <= 3).ToArray();

PrintArray(words);
if (shortwords!=null)Console.Write(" -> ");
PrintArray(shortwords!);
Console.WriteLine();
}

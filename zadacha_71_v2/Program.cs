// Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с»
// и «в». Покажите все слова, состоящие из n букв, которые можно построить из
// букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
// ав, ва, ви, ив, св, вс

// ВАРИАНТ РЕШЕНИЯ 2

Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine());

string symbols = "аисв";

int n = 1;

async void FindWords(string alfavit, char[] word, int length = 0)
{
    if (length == word.Length)
    {
    Console.WriteLine($"{n++} {new string(word)}");
    return;
    }

    for (int i = 0; i < alfavit.Length; i++)
    {
        word[length] = alfavit[i];
        FindWords(alfavit, word, length + 1);
    }
}
FindWords(symbols, new char[num]);
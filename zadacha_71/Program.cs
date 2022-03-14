// Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с»
// и «в». Покажите все слова, состоящие из n букв, которые можно построить из
// букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
// ав, ва, ви, ив, св, вс
string alf = "аисв";
int n = 3;
string[] Words(string a, int num)
{
    if (num == 0)
    {
        string[] resul = { "" };
        return resul;
    }
    string[] w = Words(a, num - 1);
    string[] result = new string[w.Length * 4];
    int k = 0;
    for (int i = 0; i < w.Length; i++)
    {
        for (int j = 0; j < a.Length; j++)
        {
            result[k] = w[i] + a[j];
            k++;
        }
    }
    return result;
}
string[] res = Words(alf, n);
for (int i = 0; i < res.Length; i++)
    Console.Write(res[i] + " ");

// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
// представления нескольких чисел (без разделителя). В массиве data хранится
// информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений чисел
// массива data с учётом информации из массива info.
// 25 мин
// входные данные:
// - data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// - info = {2, 3, 3, 1 }
// выходные данные:
// - 1, 7, 0, 1






















int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
double[] result = new double[info.Length];
int k = 0;                                                                                    
for (int i = 0; i < info.Length; i++)                           
{
    result[i] = 0;                                              
    for (int j = k, l = info[i]-1; (j < k + info[i] && l >= 0); j++, l--)                       
    {
        result[i] = (data[j] * Math.Pow(2, l)) + result[i];
        Console.WriteLine($"data[{j}] = {data[j] }");          
    }
    k = k + info[i];                                                                 
    Console.WriteLine($"result[{i}] = {result[i] }");
    Console.WriteLine(" ");
}


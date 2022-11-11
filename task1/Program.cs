/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
["hello","2","world",":-)"] -> ["2", ":-)"]
["1234","1567","-2","computer science"] -> ["-2"]
["Russia","Denmark","Kazan"] -> []
*/

Console.Clear();
Console.WriteLine("Приветствую! Эта программа покажет значения из массива строк, которые имеют длину меньше либо равному 3 символа.");
Console.WriteLine("Первоначальный массив вводится с клавиатуры.");
Console.WriteLine("Программа написана без использования коллекций.");
int N = 1;
string[] arr = new string[1000];
Console.WriteLine("Вводите значения через Enter. Оставьте поле пустым и нажмите Enter - это остановит ввод значений.");
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите строку №{N}:");
    string userNumberString = Console.ReadLine();
    if (userNumberString == "")
    {
        break;
    }
    N++;
    string userNumber = Convert.ToString(userNumberString);
    arr[i] = userNumber;
}
Console.WriteLine("Спасибо!");
Console.Write("Вы ввели значения -> [");
for (int index = 0; index < N - 2; index++)
{
    Console.Write($"\"{arr[index]}\", ");
}
Console.WriteLine($"\"{arr[N - 2]}\"]");
Console.Write("Ответ -> [");
if (arr[0].Length <= 3)
{
    Console.Write($"\"{arr[0]}\"");
}
for (int index = 1; index < N - 1; index++)
{
    if (arr[index].Length <= 3)
    {
        Console.Write($", \"{arr[index]}\"");
    }
}
Console.Write("]");
Console.WriteLine("");
Console.WriteLine("Bye!");
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

/// Метод void userAnotherTry позволяет пользователю использовать программу второй и последующий раз по желанию пользователя без необходимости запускать ее снова

void userAnotherTry()
{
    Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    string? userChoice = Console.ReadLine();
    while (userChoice?.ToLower() != "y" && userChoice?.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
        userChoice = Console.ReadLine();
    }
    if (userChoice?.ToLower() == "y")
    {
        userData();
    }
    else
    {
        Console.WriteLine("Bye!");
    }
}

/// Метод void userData - это основной код расчетов программы

void userData()
{
    int N = 1;
    int total = 0;
    int count = 0;
    string?[] userArray = new string[1000]; /// Создание нового массива, в котором будут содержаться все строки пользователя. Лимит - 1000 можно увеличить путем увеличение цифры здесь
    Console.WriteLine("Вводите значения через Enter. Оставьте поле пустым и нажмите Enter - это остановит ввод значений.");
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"Введите строку №{N}:");
        string? userString = Console.ReadLine();
        if (userString == "")
        {
            break;
        }
        N++;
        string? userArrString = Convert.ToString(userString);
        userArray[i] = userArrString;
    }
    if (userArray[0] == null) /// Это случай, когда пользователь в первом же значении матрицы ничего не вводит. Без этого программа выводит ошибку.
    {
        Console.WriteLine("Спасибо!");
        Console.WriteLine("Вы ничего не ввели, поэтому ответа нет.");
        userAnotherTry();
        return;
    }
    Console.WriteLine("Спасибо!");
    Console.Write("Вы ввели значения -> ["); /// Далее идет выведение на экран всех значений пользователя
    for (int index = 0; index < N - 2; index++)
    {
        if (userArray[index]?.Length <= 3)
        {
            total++;
        }
        Console.Write($"\"{userArray[index]}\", ");
    }
    if (userArray[N - 2]?.Length <= 3)
    {
        total++;
    }
    Console.WriteLine($"\"{userArray[N - 2]}\"]");
    string?[] solveArray = new string[total]; /// Создание нового массива, в котором будет содержаться ответ
    for (int index = 0; index < N - 1; index++)
    {
        if (userArray[index]?.Length <= 3)
        {
            solveArray[count] = userArray[index];
            count++;
        }
    }
    Console.Write("Ответ -> ["); /// С этого момента начинается вывод на экран ответа для пользователя.
    if (count > 0)
    {
        Console.Write($"\"{solveArray[0]}\"");
    }
    if (count > 1)
    {
        for (int index = 1; index < count; index++)
        {
            Console.Write($", \"{solveArray[index]}\"");
        }
    }
    Console.Write("]");
    Console.WriteLine("");
    userAnotherTry();
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа покажет значения из массива строк, которые имеют длину меньше либо равному 3 символа.");
Console.WriteLine("Первоначальный массив вводится с клавиатуры.");
Console.WriteLine("Программа написана без использования коллекций.");

userData();
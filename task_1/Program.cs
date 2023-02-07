/*  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split()) */

string[] GetNumbers(string messeng)
{
    Console.Write(messeng);
    char[] separators = new char[] { ' ', '.', ',' };
    string[] splitArray = Console.ReadLine()!.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return splitArray;
}

int[] GetArray(string[] splitArray)
{
    int[] arr = new int[splitArray.Length];
    int resultNumber = 0;
    for (int i = 0; i < splitArray.Length; i++)
    {
        if (int.TryParse(splitArray[i], out resultNumber))
            arr[i] = resultNumber;
        else Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
    }

    return arr;
}

void GuantityPositiveNumbers(int[] array)
{
    var count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }

    Console.WriteLine($"Введенный пользователем массив - это {string.Join(", ", array)} количество положительных цифр в нем равно {count}");
}

GuantityPositiveNumbers(GetArray(GetNumbers("Введите цифры-> ")));
//
// Задача 37. Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА
//

// Ввод числа, как массив. Массив это числп разделенные пробелом (пробелами) и или Табом
string InputArrayAsString()
{
    Console.Write(" --- Input array of integers (as example: 12 45 89 -12 101), it is array of integer");
    Console.Write("\n --- Or input array of double (as example: 99.0 1.01 -12.24 10.0 101.0), it is array of double");

    Console.Write("\nInput array, please: ");
    string? strArray = Console.ReadLine();
    if( String.IsNullOrEmpty(strArray) == true)
        strArray = "";

    string str = "";
    // Из строки, которая может иметь значение NULL, делаем строку без NULL. Чтобы не использовать string?
    string.Concat(str, strArray);
    return str;

}

int GetCountElementsOfArray(string strArray)
{
    int countElements = 0;

    //string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    return countElements;
}

// Возвращает Истина, если strArray состоит из целых чисел, Ложь - если строка состоит из вещественных чисел.
// Алгоритм проверки: Если в строка чисел содержится ".", пример: "12.0 77.4 -55.5", значит это строка вещественных чисел.
bool IsSrtOfIntegers(string strArray)
{
    bool isIntegers = true;

    if(strArray.IndexOf(".") > 0)
        isIntegers = false;

    return isIntegers;
}

int[] GetConvertStrArrayToArrayInt(string strArray)
{
    int[] array = new int[12];

    return array;
}

void main()
{
    // Получить строку ввода массива. Это строка вида: "11 71 88 -10 -12 33", если массив целочисленных цисел
    // Или строка вида: "11.0 -5.5 3.1 88.9", если массив вещественных чисел.
    string strArray = InputArrayAsString();

    // Получить кол-во элементов массива, без относительно целые или вещественные числа в массиве
    int countElements = GetCountElementsOfArray(strArray);

    // Проверяем у нас строка целых или строка вещественных чисел в массиве
    bool isOfIntegers = IsSrtOfIntegers(strArray);

    if(isOfIntegers == true)
    {
        int[] array = GetConvertStrArrayToArrayInt(strArray);
    }
    else
    {

    }
}

main();





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
    Console.Write("\n --- Or input array of double (as example: 99,0 1,01 -12,24 10,0 101,0), it is array of double");
    Console.Write("\n --- The number separator is a space and or Tab!");
    Console.Write("\n --- Attention, please. Decimal separator, strictly comma (,)!!!");

    Console.Write("\nInput array, please: ");
    string? strArray = Console.ReadLine();
    if( String.IsNullOrEmpty(strArray) == true)
        strArray = "";

    string str = "";
    // Из строки, которая может иметь значение NULL, делаем строку без NULL. Чтобы не использовать string?
    str = string.Concat("", strArray);
    return str;

}

// НЕ ИСПОЛЬЗУЕТСЯ, НО ПОКА ОСТАВИМ
// Возвращает количество элементов в строке, разделеных пробелом: "10 -3 55 77"
// Получаем массив строк, каждая строка - есть число в строковом виде. И кол-во строк и есть кол-во элементов
int GetCountElementsOfArray(string strArray)
{
    int countElements = 0;

    string[] words = strArray.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    countElements = words.Length;

    return countElements;
}

// Возвращает Истина, если strArray состоит из целых чисел, Ложь - если строка состоит из вещественных чисел.
// Алгоритм проверки: Если в строка чисел содержится ",", пример: "12,0 77,4 -55,5", значит это строка вещественных чисел.
bool IsSrtOfIntegers(string strArray)
{
    bool isIntegers = true;

    if(strArray.IndexOf(",") > 0)
        isIntegers = false;

    return isIntegers;
}

int[] GetConvertStrArrayToArrayInt(string[] wordsOfNumbers)
{
    int lengthArray = wordsOfNumbers.Length;
    int[] array = new int[lengthArray];

    for(int i = 0; i < lengthArray; ++i)
    {
        array[i] = Convert.ToInt32(wordsOfNumbers[i]);
    }

    return array;
}

double[] GetConvertStrArrayToArrayDouble(string[] wordsOfNumbers)
{
    int lengthArray = wordsOfNumbers.Length;
    double[] array = new double[lengthArray];

    for (int i = 0; i < lengthArray; ++i)
    {
        array[i] = Convert.ToDouble(wordsOfNumbers[i]);
    }

    return array;
}

// Возвращает массив слов, где каждый элемент массива число в виде строки.
// Ключевое решение задачи ввода массива чисел в виде строки
string[] GetStrArrayOfNumvers(string strArray)
{

    return strArray.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

}

void PrintArrayOfInt(int[] array)
{
    string str = "";
    for(int i = 0; i < array.Length - 1; ++i)
    {
        str = str + string.Concat(array[i], ", ");
    }
    str = str + string.Concat("", array[array.Length - 1]);

    Console.WriteLine($" Result array (int): {str}");
}

void PrintArrayOfDouble(double[] array)
{
    string str = "";
    for(int i = 0; i < array.Length - 1; ++i)
    {
        str = str + string.Concat(array[i], ", ");
    }
    str = str + string.Concat("", array[array.Length - 1]);

    Console.WriteLine($" Result array (double): {str}");
}

// Произведение пар чисел в одномерном массиве целых чисел. Возвращает массив целых чисел.
int[] MultElementsOfArrayInt(int[] array)
{
    // Для нечетного массива, увеличим длину на 1, чтобы умножить среднее число на себя же
    int lenHalf = array.Length / 2 + array.Length % 2;
    int len = array.Length;
    int[] arrayResult = new int[lenHalf];

    for(int i = 0; i < lenHalf; ++i)
    {
        arrayResult[i] = array[i] * array[len - i - 1];
    }

    return arrayResult;

}

// Произведение пар чисел в одномерном массиве вещественных чисел. Возвращает массив вещественных чисел.
double[] MultElementsOfArrayDouble(double[] array)
{
    // Для нечетного массива, увеличим длину на 1, чтобы умножить среднее число на себя же
    int lenHalf = array.Length / 2 + array.Length % 2;
    int len = array.Length;
    double[] arrayResult = new double[lenHalf];

    for(int i = 0; i < lenHalf; ++i)
    {
        arrayResult[i] = array[i] * array[len - i - 1];
    }

    return arrayResult;

}

void main()
{
    Console.WriteLine(" ------- Task-37 -------");

    // Получить строку ввода массива. Это строка вида: "11 71 88 -10 -12 33", если массив целочисленных цисел
    // Или строка вида: "11,0 -5,5 3,1 88,9", если массив вещественных чисел (разделитель - запятая!).
    string strArray = InputArrayAsString();
    Console.WriteLine($"\n You input array: {strArray}");

    // Получить кол-во элементов массива, без относительно целые или вещественные числа в массиве
    //int countElements = GetCountElementsOfArray(strArray);

    // Для отладки
    //Console.WriteLine($"countElements: {countElements}");

    string[] wordsOfNumbers = GetStrArrayOfNumvers(strArray);

    // Проверяем у нас строка целых или строка вещественных чисел в массиве
    bool isOfIntegers = IsSrtOfIntegers(strArray);

    // Если у нас массив целых чисел, то идем по ветке - целых чисел
    if (isOfIntegers == true)
    {
        // Получим массив целых чисел из массива строк чисел
        int[] array = GetConvertStrArrayToArrayInt(wordsOfNumbers);
        // Для отладки
        //PrintArrayOfInt(array);

        // Конвертнем массив и получим массив произведений половинной длины
        int[] arrayResult = MultElementsOfArrayInt(array);
        // Печать результат
        PrintArrayOfInt(arrayResult);
    }
    else
    {
        // Получим массив вещественных чисел из массива строк чисел
        double[] array = GetConvertStrArrayToArrayDouble(wordsOfNumbers);
        // Для отладки
        //PrintArrayOfDouble(array);

        // Конвертнем массив и получим массив произведений половинной длины
        double[] arrayResult = MultElementsOfArrayDouble(array);
        // Печать результат
        PrintArrayOfDouble(arrayResult);
    }

}

main();





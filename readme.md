#
# <span style="color: green"> Урок 3. Базовые алгоритмы. </span>

 __Домашнее задание состоит из задачи: 37__
 
 Задача находятся в каталоге: Task_37
 
 К задаче идет программа на C# и Блок-схема ключевого алгоритма.


## <span style="color: brown"> Задача 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА </span>


Ввод массива как целых так и вещественных чисел.

Пример: "1  -2  3  -77  -999 0" - для целых чисел.

Допустимы отрицательные значения.
Для массива вещественных чисел, __разделитель дробной части, запятая "," и или точка "."!__

Пример: "-1,22  3,0  99,09  22,0  -22,0" или "1.6 3.0 -333.9 -3.01" или "1.3 4,55 1.00 22,99".

Разделитель между числами пробел, пробелы или табуляция.

[Код](Task_37/Program.cs) | [Блок-схема потока данных](/diagram.drawio.png)

__Ключевое решение для преобразования строки чисел в массив чисел. Первый шаг из строки чисел делаем массив строк, посредством функции: string. Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)__, где разделитель - пробел, пробелы, табуляция
Далее приведение типов из строки в число целое или вещественное.

Пример: "1 3 7 8 9" => массив ["1", "3", "7", "8", "9"] => массив [1, 3, 7, 8, 9].

Формула, по которой осуществляется перемножение пар чисел:

__arrayResult[i] = array[i] * array[len - i - 1]__, где len - длинна исходного массива

[Блок-схема алгоритма](/diagram.drawio.png)

Программа понимает какой массив чисел ввел пользователь, вещественные или целые. Идет проверка на наличие в строке чисел разделителя вещественных чисел - запятой. Если в строке чисел есть число с запятой, то считаем, что
у нас массив вещественных чисел. Пример: "1,2 55,0 44,4" - это массив вещественных чисел, т. к. есть запятая.


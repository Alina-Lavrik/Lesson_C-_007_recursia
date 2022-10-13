// Собрать строку с числами от a до b, a <= b

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)  // запускаем цикл, который будет менять счетчит от значения a до <= b
    {
        result += $"{i} ";  // в результирующую строку собирвем конкретное значение счетчика
    }
    return result;
}
string NumbersRec(int a, int b)  // используем рекурсию
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b); // собираем строку с текущим значением a и вызываем новую копию метода со значениями аргументов
                                                       // Первый аргумент будет увеличен на 1
    else return String.Empty;                          // условие окончания рекурсии, возвращаем пустую строку в случае, если условие не выполнилось
}
Console.WriteLine(NumbersFor (1, 10));
Console.WriteLine(NumbersRec (1, 10));
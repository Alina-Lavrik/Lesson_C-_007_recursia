// Собрать строку с числами от a до b, a >= b от БОЛЬШЕГО к МЕНЬШЕМУ

string NumbersFor(int a, int b)  // Итеративный подход
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)  // запускаем цикл, используем декримент счетчика --
    {
        result += $"{i} ";  // в результирующую строку собирвем конкретное значение счетчика
    }
    return result;
}
string NumbersRec(int a, int b)  // используем рекурсию
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} "; // с текущее значением "a" прибавляем не слева, а справа                                                  
    else return String.Empty;                          // условие окончания рекурсии, возвращаем пустую строку в случае, если условие не выполнилось
}
Console.WriteLine(NumbersFor (1, 10));
Console.WriteLine(NumbersRec (1, 10));
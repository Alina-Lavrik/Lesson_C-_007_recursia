// Сумма чисел от 1 до n

int SumFor(int n)
{
    int result = 0;
    for (int i =1; i <= n; i++) result += i;
    return result;
}
int SumRec(int n)    // рекурсия
{
    if (n == 0) return 0;        // условие выхода из рекурсии n == 0
    else return n + SumRec(n -1);  // рекурсивный вызов функции с элементом на 1 меньше
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));


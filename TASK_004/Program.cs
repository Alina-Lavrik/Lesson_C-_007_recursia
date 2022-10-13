﻿// Фактоирал числа - произведение чисел от 1 до n (5! = 1*2*3*4*5 = 120 )

int FactorialFor(int n)   // описываем функцию, которая принимает значение n
{
    int result = 1;        // заводим результирующую переменную
    for(int i = 1 ; i <= n; i++) result *= i; // цикл и резалт в корором будем умножать на текущее значение i
    return result;    // возвращаем результат
}
int FactorialRec(int n)
{
    if (n == 1) return 1;   // обязательное условие выхода для рекурсивного подхода m == 0
    else return n * FactorialRec(n - 1);  // когда мы будем возвращать текущее значение n * на вызов рекурсивной функции
                                          // с аргументом на еденичку меньше
}

Console.WriteLine(FactorialFor(5));
Console.WriteLine(FactorialRec(10));

// See https://aka.ms/new-console-template for more information


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Введите цифру, чтобы узнать, является ли соответствующий день недели выходным: ");
int a = int.Parse(Console.ReadLine());

if (5 < a && a <= 7){
    Console.WriteLine("Да, идите отдыхать!");

}else if (0 < a && a <= 5){

    Console.WriteLine("Нет, работайте, солнце ещё высоко!");

}else{

    Console.WriteLine("Цифра не обозначает день недели. Введите цифру от 1 до 7");

}
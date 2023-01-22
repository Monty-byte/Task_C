/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
*/

Console.Clear();

double b1 = ReadInt("Введите значение b1: ");
double k1 = ReadInt("Введите значение k1: ");
double b2 = ReadInt("Введите значение b2: ");
double k2 = ReadInt("Введите значение k2: ");

double fit = (b1 - b2) / (k2 - k1);
double two = (k2 * fit) + b2;

Console.Clear();

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({fit}; {two})");

double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
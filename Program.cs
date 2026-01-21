using System.Globalization;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("--List and Stack Generic--");

//ArrayList - зберігає список елементів, будь які типи object
//Використання ArrayList має багато проблем не рекомендовано його використовувати

//System.Collections.Generic - простір імен, який містить Generic колекції
//Generic - узагальнений, параметризований тип даних
//парметризований тип - це конкретно задний при створенні колекції тип
List<float> listInt = new(); //створення списку цілих чисел
                           //List<int> listInt = new List<int>(); //старий синтаксис створення списку цілих чисел

Console.WriteLine("Вкажіть вік ваших тварин (exit - вихід):"); //ввід даних від користувача
int number = 1; //номер тварини
while (true)
{ 
    Console.Write($"{number}: -> "); //вивід номера тварини
    string str = Console.ReadLine() ?? ""; //ввід рядка від користувача
    str = str.Replace(',', '.'); //заміна коми на крапку для коректного вводу дробних чисел
    //якщо людина пише Exat,то буде exit
    if (str.ToLower() == "exit" || str == "") //перевірка на вихід з циклу
    {
        break; //вихід з циклу
    }

    float age = float.Parse(str,new CultureInfo("en")); //підключаємо культуру для коректного вводу дробних чисел, щоб вводити через крапку
    listInt.Add(age);//додавання елемента в кінець списку
    number++; //щоб збільшити номер тварини
}

//як пишуться дробові числа в різних культурах
//Україна - 3,4
//США - 3.4 en
//Німеччина - 3,4
//OAЕ - 3.4


Console.WriteLine("Вік ваших тварин"); //вивід віку тварин
foreach (float age in listInt) //перебір елементів списку
{
    Console.WriteLine($"{age} років"); //вивід віку тварини
}

Console.WriteLine("---Середній вік тварин---"); //обчислення середнього віку тварин

float sum = 0.0F; //змінна для збереження суми віку тварин
foreach (float age in listInt) //перебір елементів списку
{
    sum += age; //додавання віку тварини до суми
}
float average = sum / listInt.Count; //Count - властивість яка повертає кількість елементів в списку
Console.WriteLine($"Середній вік: {average} років"); //вивід середнього віку тварин

//Поснення коду з використанням List Generetic замість ArrayList


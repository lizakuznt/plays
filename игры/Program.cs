using System;

string plays;

while (true)
{

    Console.WriteLine("Выберите действие \n" +
                  "1. \"Угадай число\"\n" +
                  "2. Вывод делителей числа\n" +
                  "3. Выйти из программы\n");
    string plays1 = Console.ReadLine();
    int a = Convert.ToInt32(plays1);
    if (a == 1)
        Chiclo();
    if (a == 2)
        Table();
    if (a == 3)
        TheEnd();
}
static void Chiclo()
{
    Random rand = new Random();
    int i = rand.Next(10);
    int count = 1;
    Console.WriteLine("Было загадано число от 0 до 100. Попробуйте отгадать его за три попытки.");
    Console.WriteLine("Введите первое число:");
    int k = Convert.ToInt32(Console.ReadLine());

    while (count <= 3)
    {
        if (i == k)
        {
            Console.WriteLine("Да! Было загадано число " + k + "!");
            break;
        }
        else
        {
            count++;
            Console.WriteLine("Нет, это не число " + k + "! Попытка № " + count + ":");
            k = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("Увы, вы не отгадали загаданное число. Это было число " + i + "!");
    Console.ReadLine();
}
static void Table()
{
    string str = "";

    Console.WriteLine("");
    Console.WriteLine("Введите число: ");
    int y = Convert.ToInt32(Console.ReadLine());
    List<int> numbers = new List<int>();
    for (int i = 1; i < y; i++)
    {
        if (y % 1 == 0)
        {
            numbers.Add(i);
        }

    }
    foreach (int i in numbers)
    {
        str = str + i.ToString() + '\t';
    }
    Console.WriteLine("");
    Console.WriteLine("Список делителей числа " + y.ToString() + '\n' + str);

}

static void TheEnd()
{
    Environment.Exit(0);
}








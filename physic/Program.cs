Console.WriteLine("Введите метры: ");
int metr = int.Parse(Console.ReadLine());
Console.WriteLine("Сантиметры: "+ metr * 100);
Console.WriteLine("Километры: "+ metr * 0.001);


Console.WriteLine("Введите граммы: ");
int gram = int.Parse(Console.ReadLine());
double galon = gram * 0.001;
Console.WriteLine("Литров: "+ galon);
Console.WriteLine("галлоны: "+ gram * 0.001);
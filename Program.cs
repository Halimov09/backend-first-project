// circle face and circle lenngth

Console.Write("enter the circle radius ");
double radius = double.Parse(Console.ReadLine());
double pi = 3.14159;

Console.WriteLine($"doira yuzi: {pi * radius * radius}");
Console.WriteLine($"aylana uzunlugi: {2 * pi * radius}");

// currency money
Console.Write("summani kiriting ");
double foreignMoney = double.Parse(Console.ReadLine());
int localMoney = 12400;

Console.WriteLine($"Foreign money wwill be {foreignMoney * localMoney}");


// how old are you
Console.Write("what in the year were you born ");
int year = int.Parse(Console.ReadLine());
int nowYear = 2024;
int days = (nowYear - year) * 365;

Console.WriteLine($"In the {nowYear - year} year. you are lived {days} days");



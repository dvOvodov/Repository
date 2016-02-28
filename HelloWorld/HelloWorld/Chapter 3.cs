using System;
/*
class inches_to_sun
{
    static void Main()
    {
        long miles;
        long inches;

        miles = 93000000;
        inches = 12 * 5280 * miles;

        Console.WriteLine("inches to sun = "+ inches);
        Console.ReadLine();

    }
}
class byteDemo
{
    static void Main()
    {
        byte x;
        int sum;
        sum = 0;

        for (x = 1; x <= 100; x++)
            sum = sum + x;
        Console.WriteLine("summa = " + sum);
        Console.ReadLine();

    }

}
class findRadius
{
    static void Main()
    {
        double r;
        double area;

        area = 10.0;

        r = Math.Sqrt(area / 3.1416);
        Console.WriteLine("radius = " + r);
        Console.ReadLine(); 
    }
}
class Thrigonometry
{
    static void Main()
    {
        double theta; //radiance*

        for (theta = 0.0; theta <= 1.0; theta = theta + 0.1)
        {
            Console.WriteLine("sin theta = " + theta + " = " + Math.Sin(theta));
            Console.WriteLine("cos theta = " + theta + " = " + Math.Cos(theta));
            Console.WriteLine("tg theta = " + theta + " = " + Math.Tan(theta));
            Console.WriteLine();
        }
        Console.ReadLine(); 
    }
}

class UseDecimal
{
    static void Main()
    {
        decimal price;
        decimal discount;
        decimal discounted_price;

        price = 23.0m;
        discount = 0.15m;
        discounted_price = price - (price * discount);

        Console.WriteLine("Price with discount is " + discounted_price);
        Console.WriteLine("Discount is " + discount);
        Console.ReadLine();
    }
}

class FutVal
{
    static void Main()
    {   
        decimal amount;
        decimal rate_of_return;
        decimal years;
        decimal result;
        int x;

        amount = 3000000.0m;
        rate_of_return = 0.07m;
        years = 10;
        for (x = 1; x <= years; x++)
            {      
            result = amount + (amount * rate_of_return);
            amount = result;
            Console.WriteLine("result " + result);
            Console.ReadLine();
            }
        Console.ReadLine();
    }
}
class boolTest
{
    static void Main()
    {
        bool b;
        b = false;
        Console.WriteLine("b is " + b);

        b = true;
        Console.WriteLine("b is " + b);
        if (b) Console.WriteLine("Running");

        b = false;
        if (b) Console.WriteLine("Stoped");
        Console.WriteLine("Result is " + (8 == 8));

        Console.ReadLine();
    }
}

class outputTest
{
    static void Main()
    {
        Console.WriteLine("{0, 10} to {1, 5} ", 31, 10);
        Console.ReadLine();
    }
}

class DisplayTest
{
    static void Main()
    {
        int i;
        Console.WriteLine("Число\tКвадрат\tКуб");
        for(i = 0; i < 10; i++)
        Console.WriteLine("{0}\t{1}\t{2}",i,i*i,i*i*i);
        Console.Read();
    }
}

class decimalFix
{
    static void Main()
    {
        Console.WriteLine("10/3 is {0:#.##}", 10.0 / 3.0);
        Console.ReadLine();
    }
}

class UseSpec_C
{
    static void Main()
    {
        decimal balance;
        balance = 123456.56m;
        Console.WriteLine("Money {0:C}", balance);
        Console.ReadLine();
    }
}

class UseDecimal_WithSpec_C
{
    static void Main()
    {
        decimal price;
        decimal discount;
        decimal discounted_price;

        price = 23.0m;
        discount = 0.15m;
        discounted_price = price - (price * discount);

        Console.WriteLine("Price with discount is {0:C}", discounted_price);
        Console.WriteLine("Discount is {0}%", discount);
        Console.ReadLine();
    }
}

class StrDemo
{
    static void Main()
    {
        Console.WriteLine("First string\nSecond string\nThird string");
        Console.WriteLine("Onet\ttwo\tthree");
        Console.WriteLine("four\tfive\tsix");
        Console.WriteLine("\"For what?\" He ask.");

        Console.ReadLine();
    
    }
}

class Verbatim
{
    static void Main()
    {
        Console.WriteLine(@"Это 
буквальный 
строковый
интервал.");
        Console.WriteLine(@"А это
вывод с табуляцией:
1   2   3
4   5   6");
        Console.WriteLine(@"Отзыв программиста: ""Мне нравится C#""");

        Console.ReadLine();
    }
}

class dynamicInint
{
    static void Main()
    {
        double s1 = 4.0;
        double s2 = 5.0;    
        double hypo = Math.Sqrt((s1 * s1) + (s2 * s2));
        Console.WriteLine("Hypo is {0:##.###}", hypo);
        Console.ReadLine();
    }
}

class impTypeVar
{
    static void Main()
    {
        var s1 = 4.0;
        var s2 = 5.0;
        var hypo = Math.Sqrt((s1 * s1) + (s2 * s2));
        Console.WriteLine("Hypo is {0:##.###}", hypo);
        Console.ReadLine();
    }
}

class ScopeDemo
{
    static void Main()
    {
        int x = 10;
        if (x == 10) 
        {
            int y = 20;
            Console.WriteLine("y = {0}", x = y * 2);
            Console.Read();
        }
        //y = 20; y is not avalible here
    }
}

class VarInitDemo
{
    static void Main()
    { 
        int i;
        for ( i = 0 ; i < 3 ; i++ )
        {
            int y;
            y = -1;
            Console.WriteLine("Y is {0}", y); //перваое присваивание значения переменной

            y = 100;
            Console.WriteLine("Than Y is {0}", y); //второое присваивание значения переменной
        }
        Console.Read();
    }
}

class longtodouble
{
    static void Main()
    {
        long x;
        double y;

        x = 123456L;
        y = x;
        Console.WriteLine("Answer " + x + " " + y);
        Console.ReadLine();
    }
}

class doubletoint
{
    static void Main()
    {
        double x = 123.0;
        double y = 123.0;
        int z;

        z = (int)(x * y);
        Console.WriteLine("Ans = {0}", z);
        Console.Read();
    }
}*/

class translitDemo
{
    static void Main()
    {
        double x, y;
        int i;
        byte b;
        char ch;
        uint u;
        short sh;
        long l;

        x = 10.0;
        y = 3.0;

        //translit double to int (data is lost)
        i = (int)(x / y);
        Console.WriteLine("double to int {0}", i);
        Console.WriteLine();

        //int to byte (without data lost)
        i = 255;
        b = (byte)(i);
        Console.WriteLine("int to byte (without lost) {0}", b);
        Console.WriteLine();

        //int to byte (data is lost)
        i = 257;
        b = (byte)(i);
        Console.WriteLine("int to byte (data is lost) {0}", b);
        Console.WriteLine();

        //uint to short (without data lost)
        u = 32000;
        sh = (short)(u);
        Console.WriteLine("uint to short (without lost) {0}", sh);
        Console.WriteLine();

        //uint to short (data is lost)
        u = 64000;
        sh = (short)(u);
        Console.WriteLine("uint to short (without lost) {0}", sh);
        Console.WriteLine();

        //long to uint (whithout data lost);
        l = 123456789;
        u = (uint)(l);
        Console.WriteLine("long to uint (without lost) {0}", u);
        Console.WriteLine();

        //long to uint (data is lost);
        l = -123456789;
        u = (uint)(l);
        Console.WriteLine("long to uint (data is lost) {0}", u);
        Console.WriteLine();

        //byte to char
        b = 105;
        ch = (char)(b);
        Console.WriteLine(@"byte to char ""{0}""", ch);
        Console.WriteLine();

        //int to char
        i = 88;
        ch = (char)(i);
        Console.WriteLine(@"int to char ""{0}""", i);
        Console.WriteLine();

        Console.ReadLine();
    }
}

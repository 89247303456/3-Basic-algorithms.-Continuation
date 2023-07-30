//Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между 
//ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


    {
        Console.WriteLine("Введите координаты точки A:");
        Console.Write("x: ");
        double ax = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        double ay = double.Parse(Console.ReadLine());
        Console.Write("z: ");
        double az = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты точки B:");
        Console.Write("x: ");
        double bx = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        double by = double.Parse(Console.ReadLine());
        Console.Write("z: ");
        double bz = double.Parse(Console.ReadLine());

        double distance = CalculateDistance(ax, ay, az, bx, by, bz);
        Console.WriteLine("Расстояние между точкой A и B: " + distance.ToString("F2"));
    }

    static double CalculateDistance(double ax, double ay, double az, double bx, double by, double bz)
    {
        double dx = ax - bx;
        double dy = ay - by;
        double dz = az - bz;

        double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);

        return distance;
    }

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Main();

void Main()
{
    int x1 = Promt("Введите координату первой точки X1: ");
    int y1 = Promt("Введите координату первой точки Y1: ");
    int z1 = Promt("Введите координату первой точки Z1: ");
    int x2 = Promt("Введите координату второй точки X2: ");
    int y2 = Promt("Введите координату второй точки Y2: ");
    int z2 = Promt("Введите координату второй точки Z2: ");
    FindLengthTwoPoints(x1, y1, z1, x2, y2, z2);
}

int Promt(string user_message)
{
    Console.Write(user_message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

void FindLengthTwoPoints(int x_1, int y_1, int z_1, int x_2, int y_2, int z_2)
{
    double length = Convert.ToDouble(Math.Round(Math.Sqrt((x_2-x_1)*(x_2-x_1)+(y_2-y_1)*(y_2-y_1)+(z_2-z_1)*(z_2-z_1)),2));
    Console.WriteLine("Расстояние между двумя точками в трёхмерном пространстве: " + length);
}
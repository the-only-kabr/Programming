/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

 b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("Input __ b1, k1, b2, k2 ");
//int[] str = Console.ReadLine().Split().Select(int.Parse).ToArray();
int b1 = int.Parse(Console.ReadLine());
int k1 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());
void CrossPoint(int b1, int k1, int b2, int k2)
    {
            if ((k1-k2) != 0)
            {
                int x = (b2 - b1) / (k1 - k2);
                int y = (k1 * x + b1);
                Console.WriteLine(x, y);
            }
            else Console.WriteLine("Lines are parallel");
    }
CrossPoint(b1, k1, b2, k2);







































/*loat dot[2];  // точка пересечения

bool cross(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4) {
    float n;
    if (y2 - y1 != 0) {  // a(y)
        float q = (x2 - x1) / (y1 - y2);
        float sn = (x3 - x4) + (y3 - y4) * q; if (!sn) { return 0; }  // c(x) + c(y)*q
        float fn = (x3 - x1) + (y3 - y1) * q;   // b(x) + b(y)*q
        n = fn / sn;
    }
    else {
        if (!(y3 - y4)) { return 0; }  // b(y)
        n = (y3 - y1) / (y3 - y4);   // c(y)/b(y)
    }
    dot[0] = x3 + (x4 - x3) * n;  // x3 + (-b(x))*n
    dot[1] = y3 + (y4 - y3) * n;  // y3 +(-b(y))*n
    return 1;
}

int main() {
    if (cross(1,1,7,2, 7,3,5,6)) {
        std::cout << dot[0] << " " << dot[1] << std::endl;
    }
    else {
        std::cout<<"Not cross!"<<std::endl;
    }
    return 0;
}
*/

/*
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");

*/

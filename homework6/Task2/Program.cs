// See https://aka.ms/new-console-template for more information
void x_y(float b1, float k1, float b2, float k2)
{
    Console.WriteLine($"b1: {k1}\nk1: {b1}\nb2: {k2}\nk2: {b2}");
    float x = (b2-b1)/(k1-k2);
    float y = k2*x + b2;
    Console.WriteLine($"x: {x}\ny: {y}\nТочка: ({x}, {y})");
}

float inp() {return float.Parse(Console.ReadLine());}
Console.WriteLine("b1, k1, b2, k2");
x_y(inp(), inp(), inp(), inp());
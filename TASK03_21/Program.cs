/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.Write("Enter X-coordinate of point A: ");
string get_string = CheckInput(Console.ReadLine() ?? String.Empty);
int xa = Convert.ToInt32(get_string);

Console.Write("Enter Y-coordinate of point A: ");
get_string = CheckInput(Console.ReadLine() ?? String.Empty);
int ya = Convert.ToInt32(get_string);

Console.Write("Enter Z-coordinate of point A: ");
get_string = CheckInput(Console.ReadLine() ?? String.Empty);
int za = Convert.ToInt32(get_string);

Console.Write("\nEnter X-coordinate of point B: ");
get_string = CheckInput(Console.ReadLine() ?? String.Empty);
int xb = Convert.ToInt32(get_string);

Console.Write("Enter Y-coordinate of point B: ");
get_string = CheckInput(Console.ReadLine() ?? String.Empty);
int yb = Convert.ToInt32(get_string);

Console.Write("Enter Z-coordinate of point B: ");
get_string = CheckInput(Console.ReadLine() ?? String.Empty);
int zb = Convert.ToInt32(get_string);

double res = Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);

Console.WriteLine($"\nDistance between A ({xa}, {ya}, {za}) and B ({xb}, {yb}, {zb}) in 3D: " + res);

//FUNCTIONS.........................
string CheckInput (string get_string) {
    while (true) {
        if (get_string == "Q") Environment.Exit(0);
        if (int.TryParse(get_string, out int num)) {
        return get_string;
        }
        else {
                Console.Write("\nThis is not an int! ");
                Console.Write("Try again or type 'Q': ");
                get_string = Console.ReadLine() ?? "";
        }
    }
} 
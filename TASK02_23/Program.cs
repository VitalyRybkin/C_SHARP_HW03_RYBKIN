/*
Задача 23

Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.

2,3 -> 8, 27

1,5 -> 1, 8, 27, 64, 125
*/


Console.Clear();

Console.Write("Enter number N: ");
string get_string = Console.ReadLine() ?? String.Empty;
get_string = CheckInput(get_string);
int num_N = Convert.ToInt32(get_string);

Console.Write("Enter number M: ");
get_string = Console.ReadLine() ?? String.Empty;
get_string = CheckInput(get_string);
int num_M = Convert.ToInt32(get_string);

if (num_N < num_M) {
    Console.Write($"\nAll the nubers between N = {num_N} and M = {num_M}: ");
    for (int i = num_N; i <= num_M; i ++) {
        Console.Write(Math.Pow(i, 3) + " ");
    }

}
else if (num_N > num_M) {
    Console.Write($"\nAll the nubers between M = {num_M} and N = {num_N}: ");
    for (int i = num_M; i <= num_N; i ++) {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}
else Console.Write("No cubes in this range!");

Console.WriteLine();

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

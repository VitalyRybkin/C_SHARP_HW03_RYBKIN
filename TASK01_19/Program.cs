/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

using System;
using System.Text;
using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();
Console.Clear();

Console.Write("Enter a number to check for polyndrome: ");
string get_string = Console.ReadLine() ?? String.Empty;
get_string = CheckInput(get_string);
bool is_polyndrome = false;

//"MATHCUTTING AN INT" VERSION................................................
stopwatch.Start();
Console.WriteLine("\nMATHCUTTING AN INT VERSION...");
int string_size = get_string.Length / 2;
int second_half = 0; 
int first_half = Convert.ToInt32(get_string);

for (int i = 0; i < string_size; i ++) {
     second_half = second_half * 10 + first_half%10;
     first_half /= 10;
}

if (get_string.Length % 2 != 0) first_half /= 10;

if (first_half == second_half) is_polyndrome = true;
else is_polyndrome = false;

stopwatch.Stop();
PrintResult(is_polyndrome, stopwatch, get_string);


//BOTHENDS COMPARE LOOP VERSION.......................................
stopwatch.Start();
Console.WriteLine("\nBOTHENDS COMPARE LOOP VERSION...");
int forw_idx = 0, backw_idx = get_string.Length - 1;
while (forw_idx < backw_idx) {
     if (get_string[forw_idx] == get_string[backw_idx]) {
          forw_idx ++;
          backw_idx --;
     }
     else {
          is_polyndrome = false;
          break;
     }
is_polyndrome = true;
}
stopwatch.Stop();
PrintResult(is_polyndrome, stopwatch, get_string);

//STRINGBUILDER VERSION.............................................
stopwatch.Start();
Console.WriteLine("\nSTRINGBUILDER VERSION...");
is_polyndrome = false;
StringBuilder reversed_string = new StringBuilder();

for (int i = get_string.Length - 1; i > - 1; i--) {
     reversed_string.Append(get_string[i]);
}

is_polyndrome = CheckPolyndrome(get_string, reversed_string.ToString());
stopwatch.Stop();
PrintResult(is_polyndrome, stopwatch, get_string);

//CHARARRAY VERSION.................................................
stopwatch.Start();
Console.WriteLine("\nCHARARRAY VERSION...");
is_polyndrome = false;
char[] char_arr = new char[get_string.Length];
char_arr = get_string.ToCharArray();
Array.Reverse(char_arr);
string reverse = new string(char_arr);

is_polyndrome = CheckPolyndrome(get_string, reverse.ToString());
stopwatch.Stop();
PrintResult(is_polyndrome, stopwatch, get_string);

//FUNCTIONS..........................................................
void PrintResult (bool is_polyndrome, Stopwatch stopwatch, string get_string){
     if (is_polyndrome) Console.WriteLine($"This number ({get_string}) is a polyndrome!");
     else Console.WriteLine($"This number ({get_string}) is NOT a polyndrome!");
     Console.WriteLine("Code execution time is: " + stopwatch.ElapsedTicks + " ticks");    
}

bool CheckPolyndrome (string get_string, string reversed_string) {
     bool check = false;
     if (get_string == reversed_string) check = true;
     else check = false;
     return check;
}

string CheckInput (string get_string) {
    while (true) {
        if (get_string == "Q") Environment.Exit(0);
        if (int.TryParse(get_string, out int num)) {
        Console.Clear();
        return get_string;
        }
        else {
                Console.Write("\nThis is not an int! ");
                Console.Write("Try again or type 'Q': ");
                get_string = Console.ReadLine() ?? "";
        }
    }
}   
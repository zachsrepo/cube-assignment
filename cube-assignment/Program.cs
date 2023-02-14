
// find the cube of the odd numbers from 1 - 25
using System.Runtime.CompilerServices;

int x = 1;
int cubedValue;
while(x <= 25) // this is better because its clear what the program is doing.
{
    if (x % 2 == 0)
    {
        x++; //this skips the evens
        continue;
    }
    // x is an odd number here.

    cubedValue = x * x * x;

    Console.WriteLine($"{x} ^ 3 = {cubedValue}");

    x++; // dont forget this. only using ++ every other cycle on the odd numbers.
}
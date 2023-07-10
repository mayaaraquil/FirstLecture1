using System.Net.Cache;
using System.Transactions;

//create a variable called x and give it a value of 5
int age = 5;
string name = "Maya";
string name2 = "Kyle";
/*
 * validate the number variable
 * do something if validated
 */
if (age == 1)
{

}

//declaring variables
int money;
//initialize variable
money = 5;
//combined
bool hungry = true;

//Constant
const double taxRate = 0.06;
//taxRate = 6; // not allowed to change constants
//Console.WriteLine(taxRate)

Console.WriteLine("please enter a radius");
//string entry = Console.ReadLine();
//double value = double.Parse(entry));
double value = double.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(value, 2);
Console.WriteLine(area);

//increment/decrement




//odd or even
Console.WriteLine("Please enter a number");
int input = int.Parse(Console.ReadLine());
int oddCheck = input % 2;
if(oddCheck == 0)
{
    Console.WriteLine("even");
}
else if(oddCheck == 1)
{
    Console.WriteLine("odd");
}


//assignment
value = 0;
value = age * 100 - Math.PI;

int assign = 0;
Console.WriteLine(assign);
assign = 5;
Console.WriteLine(assign);
assign += 2;
Console.WriteLine(assign);
assign -= 5;
Console.WriteLine(assign);

//null
string catName = null;
Console.Write(catName);
catName = "Felony";
Console.WriteLine(catName);

string y = null;

if(y == null)
{
    y = "oogabooga";
}

//nonnullable
//int z = null;



//exercises
//1
Console.WriteLine("enter a funny, cool phrase: ");
string ex1 = Console.ReadLine();
Console.WriteLine(ex1);

//2
Console.WriteLine("Please enter a number queen.");
int ex2 = int.Parse(Console.ReadLine());
Console.WriteLine(ex2 + 1);

//3
Console.WriteLine("okay another request, enter another number pleasee ");
float ex3 = float.Parse(Console.ReadLine());
Console.WriteLine(ex3 + .5);

//4
Console.WriteLine("enter a number");
double ex4_1 = double.Parse(Console.ReadLine());
Console.WriteLine("enter another number");
double ex4_2 = double.Parse(Console.ReadLine());
Console.WriteLine(ex4_1 + ex4_2);


//5
Console.WriteLine("enter a number");
int ex5_1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter another number");
int ex5_2 = int.Parse(Console.ReadLine());
Console.WriteLine(ex5_1 * ex5_2);

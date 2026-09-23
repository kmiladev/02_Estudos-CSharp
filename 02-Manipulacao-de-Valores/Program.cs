//Exercício 1. Aqueciment, criação de varáveis e atribuição. Interpolação

string name = "Camila";
int age = 39;
double height = 1.59;
bool studyingProgramming = true;

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Height: {height}");
Console.WriteLine($"Studing programming: {studyingProgramming}");

//Exercício 2. Manipulação

int firstNumber = 18;
int secondNumber = 9;

int sum = firstNumber + secondNumber;
int subtraction = firstNumber - secondNumber;
int multiplication  = firstNumber * secondNumber;
int division = firstNumber / secondNumber;
int remainder = firstNumber % secondNumber;

Console.WriteLine($"sun = {sum}");
Console.WriteLine($"subtraction = {subtraction}");
Console.WriteLine($"multiplication = {multiplication}");
Console.WriteLine($"division = {division}");
Console.WriteLine($"remainder =  {remainder}"); // remainder - resto

// Exercício 3. criar variáveis e calcular valores

decimal revenue = 5000M;
decimal expenses = 3200M;

decimal balance = revenue - expenses;

Console.WriteLine($"Revenue: {revenue:C2}");
Console.WriteLine($"Expenses: {expenses:C2}");
Console.WriteLine($"Balance: {revenue:C2}");

//Exercício 4. add revenue and espenses

decimal addRevenue = 1000M;

decimal addExpenses = 500M;

decimal totalRevenue = revenue + addRevenue;
decimal totalExpenses = expenses + addExpenses;

decimal finalBalance = totalRevenue - totalExpenses;

Console.WriteLine($"Revenue: {totalRevenue:C2}");
Console.WriteLine($"Expenses: {totalExpenses:C2}");
Console.WriteLine($"Balance: {finalBalance:C2}");
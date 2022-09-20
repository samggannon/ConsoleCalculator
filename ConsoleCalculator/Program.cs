// Building a console calculator using microsoft's documentation tutorial

// In this tutorial, I will,
// Create a visual studio project
// Create a C# console app
// debug my app
// Inspect my complete code

// Declare variables and then initialize to zero.
int num1 = 0;
int num2 = 0;

// Display title as the  C# console calculator app.
Console.WriteLine("Console calculator in C#\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
Console.WriteLine("Type a numbeer, and then press enter");
num1 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number
Console.WriteLine("Type a second number, and then press enter.");
num2 = Convert.ToInt32(Console.ReadLine());

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("Your option? ");



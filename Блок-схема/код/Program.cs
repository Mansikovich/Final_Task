using System;
					
public class Program
{
	public static void Main()
	{

string[] Input = new string[11] {"hello", "2", "world",":-)", "1234", "1567", 
"-2", "computer science","Russia","Denmark","Kazan"};
string[] Output = new string[Input.Length];
FillingOutputArray(Input, Output);
PrintArray(Output);

void FillingOutputArray(string[] Input, string[] Output)
{
    int count = 0;
    for (int i = 0; i < Input.Length; i++)
    {
    if(Input[i].Length <= 3)
        {
        Output[count] = Input[i];
        count++;
        }
    }
}
void PrintArray(string[] Output)
{
    for (int i = 0; i < Output.Length; i++)
    {
        Console.Write($"{Output[i]} ");
    }
    Console.WriteLine();
}


    }
}
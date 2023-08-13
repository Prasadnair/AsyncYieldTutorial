// See https://aka.ms/new-console-template for more information
using AsyncYield;

Console.WriteLine("Combine Async and Yield");

var numbers = AsyncGeneretors.GenerateNumbersAsync();

await foreach (var number in numbers )
{
    Console.WriteLine(number);
}
Console.Read();
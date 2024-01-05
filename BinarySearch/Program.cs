
using UnderstandingAlgorithms.BinarySearch;

Console.Clear();

var items = new List<int>() { 1, 3, 5, 7, 9 };
Console.WriteLine($"Position: {Search.BinarySearch(items, 3)}");
Console.WriteLine($"Position: {Search.BinarySearch(items, -1)}");

using UnderstandingAlgorithms.SelectionSort;


Console.Clear();
var items = new List<int> { 25, 2, 7, 16, 4, 32 };
Console.WriteLine(string.Join(", ", Sort.SelectionSort(items)));

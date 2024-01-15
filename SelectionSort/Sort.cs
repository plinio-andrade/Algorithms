namespace UnderstandingAlgorithms.SelectionSort;

public static class Sort
{

    public static int[] SelectionSort(IList<int> unordered)
    {
        var currentItems = new int[unordered.Count];
        for (int i = 0; i < currentItems.Length; i++)
        {
            var minor = MinorSearch(unordered);
            currentItems[i] = unordered[minor];
            unordered.RemoveAt(minor);
        }
        return currentItems;

    }

    private static int MinorSearch(IList<int> items)
    {
        var minor = items[0];
        var minorIndex = 0;
        for (var i = 0; i < items.Count; i++)
        {
            if (items[i] < minor)
            {
                minor = items[i];
                minorIndex = i;
            }
        }
        return minorIndex;
    }
}
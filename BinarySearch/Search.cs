namespace UnderstandingAlgorithms.BinarySearch;

public static class Search
{
    public static int? BinarySearch(IList<int> list, int item)
    {
        var low = 0;
        var high = list.Count - 1;

        while (low <= high)
        {
            var middle = (low + high) / 2;
            var kick = list[middle];
            if (kick == item)
                return middle;
            if (kick > item)
                high = middle - 1;
            else
                low = middle + 1;
        }
        return null;
    }
}
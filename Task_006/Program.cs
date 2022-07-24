int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

static IEnumerable<int> MakeOddToPow(int[] arr)
{
    var oddNumberPowsList = from p in arr
                            where p % 2 != 0
                            select (int)Math.Pow(p, 2);

    return oddNumberPowsList;
}

var arrList = MakeOddToPow(arr);

foreach (var item in arrList)
{
    Console.WriteLine(item);
}
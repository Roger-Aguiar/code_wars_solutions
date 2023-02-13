public class LargestTwo
{
    public int[] TwoOldestAges(int[] ages) => ages.OrderBy(i => i).TakeLast(2).ToArray();
}
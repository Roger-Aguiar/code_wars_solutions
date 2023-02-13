Console.Clear();
int[] ages = { 10, 25, 12, 5, 65, 70, 48, 50 };
LargestTwo largestTwo = new LargestTwo();
int[] largestAge = largestTwo.TwoOldestAges(ages);

foreach (var age in largestAge)
{
    Console.WriteLine(age);
}
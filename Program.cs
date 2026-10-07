namespace OOPAdvanced03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            Console.WriteLine($"Initial grades: [{string.Join(", ", grades)}]");
            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First grade: {grades[0]}");
            Console.WriteLine($"Last grade: {grades[^1]}");

            grades.Sort();
            Console.WriteLine($"\nSorted: [{string.Join(", ", grades)}]");

            int firstAbove90 = grades.Find(g => g > 90);
            Console.WriteLine($"First above 90: {firstAbove90}");

            List<int> failingGrades = grades.FindAll(g => g < 75);
            Console.WriteLine($"Failing grades: [{string.Join(", ", failingGrades)}]");

            grades.RemoveAll(g => g < 75);
            Console.WriteLine($"After removing failing: [{string.Join(", ", grades)}]");

            bool hasPerfect = grades.Contains(100);
            Console.WriteLine($"Has 100: {hasPerfect}");

            List<string> formatted = grades.ConvertAll(g => $"Grade: {g}");
            Console.WriteLine("\nFormatted:");
            foreach (var item in formatted)
            {
                Console.WriteLine($"  {item}");
            }
            #endregion
        }
    }
}
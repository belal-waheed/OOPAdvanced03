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

            #region Exercise 2: Leaderboard
            Console.WriteLine("\n=== Exercise 2: Leaderboard ===");

            SortedList<int, string> leaderboard = new()
            {
                { 500, "Ahmed" },
                { 200, "Sara" },
                { 800, "Ali" },
                { 350, "Mona" }
            };

            Console.WriteLine("Entries (auto-sorted by score):");
            foreach (var (score, player) in leaderboard)
            {
                Console.WriteLine($"  {score} : {player}");
            }

            Console.WriteLine($"First Key: {leaderboard.Keys[0]}");
            Console.WriteLine($"First Value: {leaderboard.Values[0]}");

            Console.WriteLine($"Score 500 exists: {leaderboard.ContainsKey(500)}");

            if (leaderboard.TryGetValue(999, out string? player999))
            {
                Console.WriteLine($"Player with score 999: {player999}");
            }
            else
            {
                Console.WriteLine("Player with score 999: Not found");
            }

            leaderboard.Remove(200);
            Console.WriteLine("\nUpdated Leaderboard after removing 200:");
            foreach (var (score, player) in leaderboard)
            {
                Console.WriteLine($"  {score} : {player}");
            }
            #endregion

            #region Exercise 3: Phone Book
            Console.WriteLine("\n=== Exercise 3: Phone Book ===");

            Dictionary<string, string> phoneBook = new()
            {
                { "Ahmed", "01011112222" },
                { "Sara", "01033334444" },
                { "Ali", "01055556666" },
                { "Mona", "01077778888" }
            };

            phoneBook["Omar"] = "01099990000";

            try
            {
                phoneBook.Add("Ahmed", "01000000000");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Add duplicate error caught: {ex.Message}");
            }

            bool tryAddResult = phoneBook.TryAdd("Ahmed", "01000000000");
            Console.WriteLine($"TryAdd duplicate succeeded: {tryAddResult}");

            Console.WriteLine($"Contains 'Khaled': {phoneBook.ContainsKey("Khaled")}");

            string contactFallback = phoneBook.GetValueOrDefault("Khaled", "Not Found");
            Console.WriteLine($"Contact 'Khaled' fallback: {contactFallback}");

            Console.WriteLine($"Keys: {string.Join(", ", phoneBook.Keys)}");
            Console.WriteLine($"Values: {string.Join(", ", phoneBook.Values)}");
            #endregion

            #region Exercise 4: Unique Email Validator
            Console.WriteLine("\n=== Exercise 4: Unique Email Validator ===");

            HashSet<string> emails = new(StringComparer.OrdinalIgnoreCase)
            {
                "ahmed@test.com",
                "AHMED@test.com",
                "sara@test.com",
                "Sara@Test.Com"
            };

            Console.WriteLine($"Stored unique emails count: {emails.Count}");
            Console.WriteLine($"Emails: [{string.Join(", ", emails)}]");

            HashSet<int> setA = [1, 2, 3, 4, 5];
            HashSet<int> setB = [4, 5, 6, 7, 8];

            HashSet<int> union = new(setA);
            union.UnionWith(setB);
            Console.WriteLine($"Union: [{string.Join(", ", union)}]");

            HashSet<int> intersect = new(setA);
            intersect.IntersectWith(setB);
            Console.WriteLine($"Intersect: [{string.Join(", ", intersect)}]");

            HashSet<int> except = new(setA);
            except.ExceptWith(setB);
            Console.WriteLine($"Except: [{string.Join(", ", except)}]");

            HashSet<int> subset = [1, 2];
            Console.WriteLine($"Is {{1, 2}} subset of Set A: {subset.IsSubsetOf(setA)}");
            #endregion

            #region Exercise 5: Print Queue Simulator
            Console.WriteLine("\n=== Exercise 5: Print Queue Simulator ===");

            Queue<string> printQueue = new();
            printQueue.Enqueue("Report.pdf");
            printQueue.Enqueue("Invoice.pdf");
            printQueue.Enqueue("Letter.docx");
            printQueue.Enqueue("Resume.pdf");
            printQueue.Enqueue("Photo.jpg");

            Console.WriteLine($"Queue contents: [{string.Join(", ", printQueue)}]");
            Console.WriteLine($"Queue count: {printQueue.Count}");
            Console.WriteLine($"Next document to print (Peek): {printQueue.Peek()}");

            Console.WriteLine("Processing queue:");
            while (printQueue.Count > 0)
            {
                string document = printQueue.Dequeue();
                Console.WriteLine($"  Printing: {document}");
            }

            bool queueEmptyResult = printQueue.TryDequeue(out string? dequeuedDoc);
            Console.WriteLine($"TryDequeue on empty queue succeeded: {queueEmptyResult} (Value: {dequeuedDoc ?? "null"})");
            #endregion
        }
    }
}

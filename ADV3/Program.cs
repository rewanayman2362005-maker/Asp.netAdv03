using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  1.Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };

            #endregion
            #region 2. Print the collection, Count, first and last grade
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}
            //Console.WriteLine($"count :{grades.Count()}");
            //Console.WriteLine($"first : {grades.First()}");
            //Console.WriteLine($"last : {grades.Last()}");



            #endregion
            #region 3. Sort the grades ascending, then print
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
            //grades.Sort();
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            #endregion
            #region 4. Get the first grade above 90
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
            //Console.WriteLine($"first grade above 90 : {grades.FirstOrDefault(g => g > 90)}"); 
            #endregion
            #region  5.Get all grades below 75(failing grades)
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
            //var failingGrades = grades.Where(g => g < 75);
            //foreach (int grade in failingGrades)
            //{
            //    Console.WriteLine(grade);
            //}
            #endregion
            #region   6.Remove all failing grades(below 75)
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
            //grades.RemoveAll(g => g < 75);
            #endregion
            #region 7. Check if any grade equals 100
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
            //Console.WriteLine($"Any grade equals 100? : {grades.Any(g => g == 100)}");
            #endregion
            #region 8. Create a List<string> where each grade becomes "Grade: X"
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
            //var gradeStrings = grades.Select(g => $"Grade: {g}");
            //foreach (string gradeString in gradeStrings)
            //{
            //    Console.WriteLine(gradeString);
            //}
            #endregion
            #region 1. Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();
            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");
            #endregion
            #region 2. Print all entries (they should be sorted by score automatically)
            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

            //foreach (var entry in leaderboard.Reverse()) 
            //{
            //    Console.WriteLine($"Score: {entry.Key} - Player: {entry.Value}");
            //}
            #endregion
        }

    }
}

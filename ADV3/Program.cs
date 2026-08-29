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
        }
    }
}

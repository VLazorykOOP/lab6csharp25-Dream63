namespace Lab6CSharp.Lab6CSharpTask4 {
    public class Task4 {
        public void Task() {
            Console.WriteLine("\n >>> Task 4");
            int[,] myMatrix =  {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};

            MatrixInt matrix = new MatrixInt(myMatrix);

            foreach (var i in matrix) {
                Console.Write(i + ", ");
            }
        }
    }
}
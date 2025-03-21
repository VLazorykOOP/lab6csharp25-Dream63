
namespace Lab6CSharp
{
    internal class StartingFile
    {
        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start() {
            Lab6CSharpTask1.Task1 task1 = new();
            task1.Task();

            Lab6CSharpTask2.Task2 task2 = new();
            task2.Task();

            Lab6CSharpTask3.Task3 task3 = new();
            task3.Task();

            Lab6CSharpTask4.Task4 task4 = new();
            task4.Task();
        }
    }
}

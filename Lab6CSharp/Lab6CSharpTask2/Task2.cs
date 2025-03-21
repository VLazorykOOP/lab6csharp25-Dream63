namespace Lab6CSharp.Lab6CSharpTask2 {
    public class Task2 {
        public void Task() {
            Console.WriteLine("\n >>> Task 2");

            IFigure[] figures = {new Rectangle(1,2), new Triangle(4), new Circle(5)};

            foreach (IFigure f in figures) 
                f.Show();
        }
    }
}
namespace Lab6CSharp.Lab6CSharpTask2 {
    public class Rectangle : IFigure {
        private int a, b;

        public Rectangle(int x, int y) {
            a = x;
            b = y;
        }

        public double Area() {
            return a * b;
        }
        public double Perimeter() {
            return (a + b) * 2;
        }
        public void Show() {
            Console.WriteLine($"Rectangle with side lengths {a} and {b}");
        }    
        public object Clone() {
            return new Rectangle(a, b);
        } 
    }
}
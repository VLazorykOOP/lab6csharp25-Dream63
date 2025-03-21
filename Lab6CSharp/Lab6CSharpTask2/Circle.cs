namespace Lab6CSharp.Lab6CSharpTask2 {
    public class Circle : IFigure {
        private int radius;

        public Circle(int radius) {
            this.radius = radius;
        }

        public double Area() {
            return radius * 3.14;
        }
        public double Perimeter() {
            return 2 * radius * 3.14;
        }
        public void Show() {
            Console.WriteLine($"Circle with radius {radius}");
        }     

        public object Clone() {
            return new Circle(radius);
        }
    }
}
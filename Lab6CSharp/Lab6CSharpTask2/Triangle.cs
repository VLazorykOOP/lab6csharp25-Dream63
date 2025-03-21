namespace Lab6CSharp.Lab6CSharpTask2 {
    public class Triangle : IFigure {
        //equilateral triangle
        private int side;

        public Triangle(int side) {
            this.side = side;
        }

        public double Area() {
            return side * side * Math.Sqrt(3) / 4;
        }
        public double Perimeter() {
            return side * 3;
        }
        public void Show() {
            Console.WriteLine($"Equilateral triangle with side length {side}");
        }     
        public object Clone() {
            return new Triangle(side);
        }
    }
}
namespace Lab6CSharp.Lab6CSharpTask2 {
    public interface IFigure : ICloneable { // Default .NET interface that allows to clone classes
        public double Area();
        public double Perimeter();
        public void Show();

        public new object Clone();
    }
}
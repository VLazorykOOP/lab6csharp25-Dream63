namespace Lab6CSharp.Lab6CSharpTask1
    {
    public interface IPriceable {

        double Price { get; }

        protected void SetPrice(double price) {}

        public string ShowMagazine();

    }
}
namespace Lab6CSharp.Lab6CSharpTask1
    {
    public interface IGenreable {

        string Genre { get; }

        protected void SetGenre(string genre) {}

        public string ShowBook();

    }
}
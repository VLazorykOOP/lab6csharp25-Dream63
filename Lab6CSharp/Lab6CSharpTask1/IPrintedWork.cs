namespace Lab6CSharp.Lab6CSharpTask1
    {
    public interface IPrintedWork {

        string Author { get; }
        int NumOfPages { get; }

        protected void SetNumOfPages(int numOfPages) {}
        protected void SetAuthor(string author) {}
        public string Show() { return "Author: " + Author + " | number of pages: " + NumOfPages; }
    }
}
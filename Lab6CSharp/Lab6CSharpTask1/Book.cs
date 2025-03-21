namespace Lab6CSharp.Lab6CSharpTask1
{
    public class Book : IPrintedWork, IGenreable {

        public string Author { get; private set; } = "Unknown";
        public int NumOfPages { get; private set;} = 1;
        public string Genre {get; private set;} = "Unknown";

        public Book(String Author, int NumOfPages, String Genre) {
            SetAuthor(Author);
            SetNumOfPages(NumOfPages);
            SetGenre(Genre);
        }
        public Book(String Author, int NumOfPages) {
            SetAuthor(Author);
            SetNumOfPages(NumOfPages);
        }
        public Book(String Author) {
            SetAuthor(Author);
        }        
        public Book(int NumOfPages) {
            SetNumOfPages(NumOfPages);
        } 
        public Book() {}
        
        protected void SetAuthor(string author) { this.Author = author; }
        protected void SetNumOfPages(int numOfPages) { this.NumOfPages = numOfPages;}
        protected void SetGenre(string genre) { this.Genre = genre;}


        public string Show() { return "Author: " + Author + " | number of pages: " + NumOfPages; }
        public string ShowBook() { return "Book --- Genre: " + Genre + " | " + Show(); }
    }
}
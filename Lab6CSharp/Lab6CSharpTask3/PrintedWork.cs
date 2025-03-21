namespace Lab6CSharp.Lab6CSharpTask3
{
    public class PrintedWork {
        string author = "Unknown";
        int numOfPages = 1;

        public PrintedWork(string Author, int NumOfPages) {
            author = Author;
            numOfPages = NumOfPages;
        }
        public PrintedWork() {}

        public string Show() {
            return "Author: " + author + " | number of pages: " + numOfPages; 
        }
    }
}
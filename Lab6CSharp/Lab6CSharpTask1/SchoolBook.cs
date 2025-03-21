namespace Lab6CSharp.Lab6CSharpTask1 {
    public class SchoolBook : IPrintedWork {
        public string Author { get; private set; } = "Unknown";
        public int NumOfPages { get; private set;} = 1;
        public string Lesson {get; private set; } = "Unknown";

        public SchoolBook(string Author, int NumOfPages, String Lesson)  {
            SetAuthor(Author);
            SetNumOfPages(NumOfPages);
            SetLesson(Lesson);
        }
        public SchoolBook(string Author, int NumOfPages) {
            SetAuthor(Author);
            SetNumOfPages(NumOfPages);
        }
        public SchoolBook(string Author)  {
            SetAuthor(Author);
        }    
        public SchoolBook(int NumOfPages) {
            SetNumOfPages(NumOfPages);
        }    
        public SchoolBook() { }

        protected void SetAuthor(string author) { this.Author = author; }
        protected void SetNumOfPages(int numOfPages) { this.NumOfPages = numOfPages;}
        protected void SetLesson(string lesson) { this.Lesson = lesson;}


        public string Show() { return "Author: " + Author + " | number of pages: " + NumOfPages; }
        public string ShowBook() { return "SchoolBook --- Lesson: " + Lesson + " | " + Show(); }
}
}


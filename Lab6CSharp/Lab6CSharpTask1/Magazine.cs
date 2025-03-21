namespace Lab6CSharp.Lab6CSharpTask1 {
    public class Magazine : IPrintedWork, IPriceable {
        public string Author { get; private set; } = "Unknown";
        public int NumOfPages { get; private set;} = 1;
        public double Price {get; private set; } = 0;
    
        public Magazine(string Author, int NumOfPages, double Price) {
            SetAuthor(Author);
            SetNumOfPages(NumOfPages);
            SetPrice(Price);
        }
        public Magazine(string Author, int NumOfPages) {
            SetAuthor(Author);
            SetNumOfPages(NumOfPages);
        }
        public Magazine(string Author) {
            SetAuthor(Author);
        }
        public Magazine(int NumOfPages) {
            SetAuthor(Author);
        }
        public Magazine() {}
    
        
        protected void SetAuthor(string author) { this.Author = author; }
        protected void SetNumOfPages(int numOfPages) { this.NumOfPages = numOfPages;}
        protected void SetPrice(double price) { this.Price = price; }
    

        public string Show() { return "Author: " + Author + " | number of pages: " + NumOfPages; }
        public string ShowMagazine() { return "Magazine --- Price: " + Price + " | " + Show(); }

    }
}


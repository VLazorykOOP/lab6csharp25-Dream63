namespace Lab6CSharp.Lab6CSharpTask3 {
    public class Magazine : PrintedWork {
        private double price = 0;
    
        public Magazine(string Author, int NumOfPages, double Price) : base(Author, NumOfPages) {
            // Custom Exception
            if (Price == 404.0) throw new MyException("Error! Wrong value!!!");

            price = Price;
        }
    
        public Magazine() :base() {}
    
        public string Show1() {
            return "Magazine --- Price: " + price + " | " + base.Show(); 
        }
    
        // StackOverflow
        public new string Show() {
            return "Magazine --- Price: " + price + " | " + Show(); 
        }
    }
}


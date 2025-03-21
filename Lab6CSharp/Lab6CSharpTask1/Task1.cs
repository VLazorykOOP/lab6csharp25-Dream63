namespace Lab6CSharp.Lab6CSharpTask1 {
    public class Task1 {
        public void Task() {
            Console.WriteLine("\n >>> Task 1");

            Book book = new Book("Unnamed",100,  "Action");
            Magazine magazine = new Magazine();
            SchoolBook schoolBook = new SchoolBook("Cofrie", 214);

            Console.WriteLine(book.Show());
            Console.WriteLine(magazine.Show());
            Console.WriteLine(schoolBook.Show());
        }
    }
}
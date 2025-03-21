namespace Lab6CSharp.Lab6CSharpTask3 {
    public class Task3 {
        public void Task() {
            Console.WriteLine("\n >>> Task 3");

            Console.Write("Enter value: ");
            double price = double.TryParse(Console.ReadLine(), out double price1) ? price1 : 404.0;
            Magazine magazine;

            try { magazine = new Magazine("RandomAuthor", 123, price); }
            catch (MyException ex) {
                Console.WriteLine($"Wrong value exception caught: {ex.Message}");
                magazine = new Magazine("RandomAuthor", 123, 1);
            }

      //                                         wont throw exeption even if overflow happends :(
      //    try { magazine.Show(); }
      //    catch (StackOverflowException ex) { Console.WriteLine($"Stack overflow exception caught");}

            try { Console.WriteLine(magazine.Show1()); }
            catch { Console.WriteLine($"Exception caught"); }

        }
    }
}
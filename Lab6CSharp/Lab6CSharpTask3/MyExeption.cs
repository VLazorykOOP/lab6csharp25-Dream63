namespace Lab6CSharp.Lab6CSharpTask3
{
    public class MyException : ApplicationException {
        public MyException () {}
        public MyException (string message): base (message) {} 
        public MyException (string message, Exception ex): base (message) {} 
    }
}
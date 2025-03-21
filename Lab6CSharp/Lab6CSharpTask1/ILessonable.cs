namespace Lab6CSharp.Lab6CSharpTask1
    {
    public interface ILessonable {

        string Lesson { get; }

        protected void SetLesson(int lesson) {}

        public string ShowSchoolBook();

    }
}
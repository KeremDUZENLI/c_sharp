using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();

            Teacher t = new Teacher(mediator);
            t.Name = "Kerem";

            Student s1 = new Student(mediator);
            s1.Name = "XXX";

            Student s2 = new Student(mediator);
            s2.Name = "YYY";

            mediator.T = t;
            mediator.S = new List<Student>() {s1, s2};


            t.SendNewImageUrl("slide1.jpg");
            t.ReceiveQuestion("A verdadeiro?", s1);
            t.AnswerQuestion("As vezes...", s1);



            Console.ReadLine();
        }
    }

    abstract class CourseMember
    {
        protected Mediator Mediator;

        protected CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }

    class Teacher : CourseMember
    {
        public string Name { get; set; }

        public Teacher(Mediator tM) : base(tM)
        {
        }

        public void ReceiveQuestion(string question, Student st)
        {
            Console.WriteLine("Teacher received question from {0}, {1}", st.Name, question);
        }

        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine("Teacher answered question to {0}, {1}", student.Name, answer);
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine("Teacher changed slide : {0}", url);
            Mediator.UpdateImage(url);
        }
    }

    class Student : CourseMember
    {
        public string Name { get; set; }

        public Student(Mediator sM) : base(sM)
        {
        }

        public void ReceiveAnswer(string answer)
        {
            Console.WriteLine("{1} received answer {0}", answer, Name);
        }

        public void ReceiveImage(string url)
        {
            Console.WriteLine("{1} received image : {0}", url, Name);
        }
    }

    class Mediator
    {
        public Teacher T { get; set; }
        public List<Student> S { get; set; }

        public void SendQuestion(string question, Student st)
        {
            T.ReceiveQuestion(question, st);
        }

        public void SendAnswer(string answer, Student st)
        {
            st.ReceiveAnswer(answer);
        }

        public void UpdateImage(string url)
        {
            foreach (var student in S)
            {
                student.ReceiveImage(url);
            }
        }
    }
}

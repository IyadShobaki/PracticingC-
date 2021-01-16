using System;
using System.Threading;

namespace LinkedListImplementation
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Vote { get; private set; }

        public Post(string title, string description, DateTime createdDate)
        {
            Title = title;
            Description = description;
            CreatedDate = createdDate;

        }
        public void UpVote()
        {
            Vote++;
        }
        public void DownVote()
        {
            Vote--;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Post post = new Post("Moon", "This post about the moon", DateTime.Now);
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine(post.Vote);


            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //Thread.Sleep(3000);
            //stopwatch.Stop();
            //Console.WriteLine("Duration: " + stopwatch.TimeSpan);


            //HttpCookie cookie = new HttpCookie();
            //cookie["name"] = "Iyad";
            //Console.WriteLine(cookie["name"]);

            //Employee janeJones = new Employee("Jane", "Jones");
            //Employee johnDoe = new Employee("John", "Doe");
            //Employee marySmith = new Employee("Mary", "Smith");
            //Employee mikeWilson = new Employee("Mike", "Wilson");

            //Calculator calculator = new Calculator();
            //var arr = calculator.Add(1, 2, 3, 4);
            //Console.WriteLine(String.Join(',', arr));

            Console.ReadLine();
        }
    }
}

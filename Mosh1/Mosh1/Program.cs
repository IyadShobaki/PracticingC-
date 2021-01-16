using System;
using System.Collections.Generic;
using System.Linq;

namespace Mosh1
{
    partial class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
        }
        static void Main(string[] args)
        {
            // *****************
            //var number = new Nullable<DateTime>();
            //Console.WriteLine(number.GetValueOrDefault());

            // *****************
            //PhotoProcessor processor = new PhotoProcessor();
            //processor.Process("photo.jpg");

            //PhotoProcessor processor = new PhotoProcessor();
            //var filters = new PhotoFilters();
            ////PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            //Action<Photo> filterHandler = filters.ApplyBrightness;
            //filterHandler += filters.ApplyContrast;
            //filterHandler += RemoveRedEyeFilter;

            //var anotherFilters = new AnotherFilters();

            //filterHandler += anotherFilters.ChangePhotoToYellowFilter;

            //processor.Process("photo.jpg", filterHandler);

            // *************
            // args => expression
            // () => ..
            // x => ..
            // (x,y,z) => ...
            //Func<int, int> sqaure = number => number * number;
            //Console.WriteLine(sqaure(5));

            //var books = new BookRepository().GetBooks();
            ////var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            //var cheapBooks = books.FindAll(b => b.Price < 10);
            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine(book.Title);
            //}

            // Events
            //var video = new Video() { Title = "Video 1" };
            //var videoEncoder = new VideoEncoder(); // Publisher
            //var mailService = new MailService(); // Subscriber
            //MessageService messageService = new MessageService(); //Subscriber

            //videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            //videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            //videoEncoder.Encode(video);


            Random randomNumber = new Random();
            //var number = randomNumber.Next(11); // [0,11)
            var number = randomNumber.Next(1, 10); // [1,10)
            var doubleNumber = randomNumber.NextDouble() * 10;
            Console.WriteLine(doubleNumber);
            Console.WriteLine(number);

            List<Person> people = new List<Person>
            {
                new Person(){FirstName = "Iyad"},
                new Person(){FirstName = "Amjad"},
                new Person(){FirstName = "Ahmad"},
                new Person(){FirstName = "Tim"},
                new Person(){FirstName = "Sue"}
            };

            var sortedPeople = people.OrderBy(x => randomNumber.Next());
            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);
            }


            Console.ReadLine();
        }
        public class MessageService
        {
            public void OnVideoEncoded(object sender, VideoEventArgs args)
            {
                Console.WriteLine("MessageService: Sending a text message..." + args.Video.Title);
            }
        }
        public class MailService
        {
            public void OnVideoEncoded(object sender, VideoEventArgs args)
            {
                Console.WriteLine("MailService: Sending an email..." + args.Video.Title);
            }
        }
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply remove red eye");
        }
    }
}

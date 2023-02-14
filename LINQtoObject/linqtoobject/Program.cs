using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;

namespace LINQtoObject
{
    class Program
    {
        static void Main(string[] args)
        {


            var group = SampleData.Books.ToLookup(x=>x.Authors);
            foreach (var item in group)
            {
                Console.WriteLine(item.Key);
                item.Display();
                Console.WriteLine("-------------------");

            }

            //1
            var Book_tytle_and_isbn = SampleData.Books.Select(x => new { x.Title, x.Isbn });
            // Book_tytle_and_isbn.Display();

            //2
            var book_with_price_more_than25 =
                 SampleData.Books.Where(x => x.Price > 25).Take(3);
            //  book_with_price_more_than25.Display();   


            //3 
            var publish_data = from pub in SampleData.Publishers
                               select new
                               {
                                   pub.Name,
                                   own_books = (from c in SampleData.Books.Where(z => z.Publisher.Name == pub.Name)
                                                select c.Title)
                               };


            //foreach (var pub in publish_data)
            //{
            //    Console.WriteLine(pub.Name);
            //    Console.WriteLine("------------------");
            //    pub.own_books.Display();
            //    Console.WriteLine("-----------------");
            //}


            //4
            var numbers_of_books_with_cost_more_than_20 =
                SampleData.Books.Count(x => x.Price > 20);
            //Console.WriteLine(numbers_of_books_with_cost_more_than_20);

            //5
            var book_title_and_price_and_subject =
                SampleData.Books.Select(x => new { x.Title, x.Subject.Name, x.Price }).OrderBy(x => x.Name).ThenBy(x => x.Price);
            //book_title_and_price_and_subject.Display();

            //6
            var All_subject_releted_with_books =
                from subject in SampleData.Subjects
                select new
                {
                    subject.Name,
                    book_related = from book in SampleData.Books.Where(b => b.Subject.Name == subject.Name)
                                   select book
                };

            //foreach (var item in All_subject_releted_with_books)
            //{
            //    Console.WriteLine("------------------------------------------");
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine("------------------");
            //    item.book_related.Display();
            //}

            //7
            var arr = SampleData.GetBooks();

            //foreach (Book item in arr)
            //{
            //    Console.WriteLine(item.Title + ">>" + item.Price);
            //}            
        } 
    }
}
public static class show
{
    public static void Display<T>(this IEnumerable<T>Source)
    {
        foreach (var item in Source)
        {
            Console.WriteLine(item);
        }
    }
}
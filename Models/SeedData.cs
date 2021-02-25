using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder book)
        {
            BooksDbContext context = book.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BooksDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        ClassificationCategory = "Fiction, Classic",
                        Price = 9.95F,
                        Pages = 1488

                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        ClassificationCategory = "Non-Fiction, Biography",
                        Price = 14.58F,
                        Pages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        ClassificationCategory = "Non-Fiction, Biography",
                        Price = 21.54F,
                        Pages = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        ClassificationCategory = "Non-Fiction, Biography",
                        Price = 11.61F,
                        Pages = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        ClassificationCategory = "Non-Fiction, Historical",
                        Price = 13.33F,
                        Pages = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        ClassificationCategory = "Fiction, Historical Fiction",
                        Price = 15.95F,
                        Pages = 288
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        ClassificationCategory = "Non-Fiction, Self-Help",
                        Price = 14.99F,
                        Pages = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        ClassificationCategory = "Non-Fiction, Self-Help",
                        Price = 21.66F,
                        Pages = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        ClassificationCategory = "Non-Fiction, Business",
                        Price = 29.16F,
                        Pages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        ClassificationCategory = "Fiction, Thrillers",
                        Price = 15.03F,
                        Pages = 642
                    },

                    new Book
                    {
                        Title = "Harry Potter",
                        Author = "JK Rolling",
                        ISBN = "978-0451419439",
                        Publisher = "Pottermore",
                        ClassificationCategory = "Fiction",
                        Price = 18.95F,
                        Pages = 297
                    },

                    new Book
                    {
                        Title = "Fable Haven",
                        Author = "Brandon Mull",
                        ISBN = "978-0451419439",
                        Publisher = "Cool Publishing",
                        ClassificationCategory = "Fiction",
                        Price = 15.95F,
                        Pages = 345
                    },

                    new Book
                    {
                        Title = "Percy Jackson",
                        Author = "Rick Riordan",
                        ISBN = "978-0451419439",
                        Publisher = "Print Company",
                        ClassificationCategory = "Fiction",
                        Price = 22.95F,
                        Pages = 430
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
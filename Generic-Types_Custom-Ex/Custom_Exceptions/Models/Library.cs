using System;
using System.Collections.Generic;
using Custom_Exceptions.Exceptions;

namespace Custom_Exceptions.Models
{
    internal class Library

    {
        public int BookLimit { get; set; }

        private List<Book> books = new List<Book>();

        public Library(int bookLimit)

        {
            BookLimit = bookLimit;

        }
        public void AddBook(Book book)

        { 
            if (books.Count < BookLimit)

            {
                books.Add(book);

                return;
            }

            throw new CapacityLimitexception("CapacityLimitException");

        }

        public Book GetBookByld(int? id)

        {

            if (id != null)

            {

                foreach (var item in books)

                {

                    if (item.Id == id)
                    {
                        return item;
                    }

                    return null;
                }

            }

            throw new NullReferenceException("Id tapilmadi");

        }

        public void RemoveByld(int? id)

        {

            if (id != null)

            {

                foreach (var item in books)

                {

                    if (item.Id == id)

                    {

                        books.Remove(item);

                        return;

                    }

                    throw new NotFoundException("NotFoundException");

                }

            }

            throw new NullReferenceException("NullReferenceException");

        }




    }

}

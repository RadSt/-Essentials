using System;

namespace Class3
{
    public class Book
    {
        public Book(string title, string author, string content)
        {
            Title titleInst = new Title(title);
            titleInst.Show();
            Author authorInst = new Author(author);
            authorInst.Show();
            Content contentInst=new Content(content);
            contentInst.Show();
        }


    }
}
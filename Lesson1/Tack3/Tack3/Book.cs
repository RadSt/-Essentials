namespace Tack3
{
    public class Book
    {
       Title title=new Title();
       Content content=new Content();
       Author author=new Author();

        public Book(string bookTitle,string bookContent, string bookAuthor)
        {
            title.BookTitle = bookTitle;
            content.BookContent = bookContent;
            author.BookAuthor = bookAuthor;
        }

        public void Show()
        {
            title.Show();
            content.Show();
            author.Show();
        }
    }
}
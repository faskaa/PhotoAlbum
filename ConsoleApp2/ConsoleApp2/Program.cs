namespace ConsoleApp2
{
  public class PhotoBook
    {
        public int numPages { get; set; }

        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int number)
        {
            numPages = number;
        }
        public int GetNumberPages()
        {
            return numPages;
        }

    }
    
   public class BigPhotoBook
    {
        public int numPages { get; set; }

        public BigPhotoBook()
        {
            numPages = 64;
        }
        public BigPhotoBook(int number)
        {
            numPages = number;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    } 
    
    
    
    
    
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var album1 = new BigPhotoBook();
            Console.WriteLine(album1.GetNumberPages());
            var album2 = new PhotoBook();
            Console.WriteLine(album2.GetNumberPages());
            var album3 = new PhotoBook(24);
            Console.WriteLine(album3.GetNumberPages());
        }
    }
}
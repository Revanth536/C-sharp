using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.basics
{
    abstract class Books{
     protected   string title;
   public abstract void setTiltle(String a);
    public String getTitle()
    {
        return title;
    }
    }
    class MyBook :Books
    {
        public override void setTiltle(string a)
        {
            throw new NotImplementedException();
        }

        
    internal class Basics
    {
        public static void Main(string[] args)
        {
           
            string title=Console.ReadLine();
            MyBook book = new MyBook();
            book.setTiltle(title);
                Console.WriteLine("The Tiltle is :"+book.getTitle();



        }
    }
}

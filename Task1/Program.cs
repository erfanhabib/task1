using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
         public class Element
        {
             public int Key1;
            public  Element [] key2;
        }

        public  static void printDepth(Element[] e)
        {
            if (e != null && e.Length > 0) //Code should not crash for null element
            {
                for (int i = 0; i < e.Length; i++)
                {
                    Console.WriteLine("Key" + e[i].Key1 + " " + e[i].Key1);
                    if (e[i].key2 != null)
                    {
                        Console.WriteLine("Key" + (e[i].Key1 + 1) + " " + e[i].Key1);
                        printDepth(e[i].key2);
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }



        public static void Main(string[] args)
        {
            Element a = new Element();
            a.Key1 = 1;
            a.key2 = new Element[] { new Element(){
                                         Key1 = 2,
                                         key2 = new Element[] { new Element(){
                Key1 = 1
            }}
            }
            };

            Element[] arr = new Element[1] {a };

            printDepth(arr);



        }




    }
}

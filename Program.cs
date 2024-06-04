namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region example1
            /*   
             *   Example 1
                  
                int sum = 0;
                 for (int i = 1; i <= 100; i++)
                 {
                     sum += i;
                 }
                 Console.WriteLine(sum);
            */
            #endregion

            #region example 2
            /*          
                Example 2
               int sum = 0;
                for (int i = 2; i <= 1000; i += 2)
                {
                     sum += i;
                }
                Console.WriteLine(sum);
            */
            #endregion

            #region example 3 

            /*          
                        Example 3

                        for (char i ='A' ;i <= 'Z' ; i++)
                        {
                            Console.Write(i + " ");
                        }
            */

            #endregion

            #region example 4
            /*
                        for (int i = 1945 ;i <= DateTime.Now.Year; i++)
                        {
                            if(i == 1990 || i == 1992)
                            {
                                continue;
                            }
                            Console.WriteLine(i);
                        }


                        for (int i = 1945; i <= DateTime.Now.Year; i++)
                        {
                          switch (i) {
                                case int x when x != 1990 && x != 1992:
                                    {
                                        Console.WriteLine(x);
                                        break;
                                    }
                                default:
                                    {
                                        continue ;
                                    }
                        }*/

            #endregion

            #region example 5

            /*

                        // dizi icerisinde yer alan datalari ekrana yazdiriniz
                        string[] takimlar = { "Real Madrid", "Qarabag", "Juventus", "Sporting", "Bayern Munih", "Dortmunt" };

                        for (int i = 0; i < takimlar.Length; i++)
                        {
                            Console.WriteLine(takimlar[i]);
                        }
            */
            #endregion

            #region foreach example 1

            /* string[] takimlar = { "Real Madrid", "Qarabag", "Juventus", "Sporting", "Bayern Munih", "Dortmunt" };

             foreach (string item in takimlar)
             {
                 Console.Write(item);
             }

             Console.WriteLine(new String('-', 50));*/

            #endregion

            #region While
            // while -> for dongusunun parcalanmis halidir.

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new String('-', 50));

            int j = 1;
            while (j <= 100)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine(new String('-', 50));


            int x = 1;
            while (true)
            {
                if (x == 100)
                {
                    Console.WriteLine(x);
                    x++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(new String('-', 50));

            for ( ; ; ) //infinity loop
            {
                Console.WriteLine("a");
            }

            #endregion
        }
    }
}

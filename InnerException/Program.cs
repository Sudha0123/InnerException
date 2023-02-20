using System;

class InnerException
{
    public static void Main(String[] args)
    {
        try
        {
            try
            {
                Console.WriteLine("Enter your  first num");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your second  num");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x % y;
                Console.WriteLine("the num {0}", z);
            }
            catch (Exception ex)
            {
                string filepath = @"D:\C#\InnerException\InnerException\log.txt";
                if (File.Exists(filepath))
                {
                    StreamWriter sw = new StreamWriter(filepath);
                    sw.Write(ex.GetType().Name);
                    Console.WriteLine();
                    sw.Write(ex.Message);
                    sw.Close();

                    Console.WriteLine("there is problem try again later");

                }

                else
                {
                   throw new FileNotFoundException(filepath + "is not present",ex); //if ex not written  then inner exception not found

                }


            }
        }
        catch (Exception exc)
        {
            Console.WriteLine("current exception ={0}", exc.GetType().Name);
            Console.WriteLine("inner exception={0}", exc.InnerException.GetType().Name);

        }

        
        }
}

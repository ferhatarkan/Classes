using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Matemetik matemetik = new Matemetik();

            Console.WriteLine(matemetik.Bol(20, 5));
        }
    }
    class Matemetik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi2 + sayi1;
        }
        public decimal Bol(int sayi1, int sayi2)
        {
            try
            {
                return sayi1 / sayi2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Catch Çalıştı.Bir hata oluştu ");
                //throw new DivideByZeroException("Sıfıra bölünemez");
                return 0;
            }
            catch (DllNotFoundException)
            {
                Console.WriteLine("Catch Çalıştı.Bambaşka bir hata oluştu. ");
                throw new DllNotFoundException("Dll Bulunamadı");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Catch çalıştı.Hiç öngörmrdiğim bir hata oluştu.Yöneticimize bildiriniz.");
                Console.WriteLine(exception.InnerException);
                throw;    
            }
            finally
            {
                Console.WriteLine("Finally çalıştı");
            }

        }
    }
}

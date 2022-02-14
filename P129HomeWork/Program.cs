using System;

namespace P129HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String
            //string word = "Test";//{'T','e','s','t'}
            #endregion

            #region Home Work - 1
            //FindCharIndex metodu - pramater olaraq 1 string ve 1 char value qebul edir ve gonderilmis char deyeri
            //gonderilmis string deyerinde necenci indexde yerlesirse hemin indexi geri qaytarir, eger tapilmasa -1
            //qaytarir. Misal ucun metodu call ederken "alama" ve 'c' deyerlerini gondersek metod bize -1, "alma"
            //ve 'a' deyerlerini gondersek 0 qaytarmalidir Bu metodu Main metodunda call edib isledeceksiniz.Metodu
            //call ederken gondereceyiniz deyerleri Main metodunda console-dan istifadeci daxil etmelidir.

            //Console.WriteLine("Metn daxil edin");
            //string str = Console.ReadLine();

            //Console.WriteLine("Herf  daxil edin");
            //string simvol = Console.ReadLine();
            //char ch = char.Parse(simvol);

            //Console.WriteLine(FindCharIndex(str, ch));
            #endregion

            #region Home Work - 2
            //IsPrime metodu - parametr olaraq ineteger value qebul edir. Gonderilims integer deyerin sade
            //olub olmadigini qaytarir.Eded sadedirse true, deyilse false qayitmalidir
            #endregion
        }

        #region Home Work - 1
        //FindCharIndex metodu - pramater olaraq 1 string ve 1 char value qebul edir ve gonderilmis char deyeri
        //gonderilmis string deyerinde necenci indexde yerlesirse hemin indexi geri qaytarir, eger tapilmasa -1
        //qaytarir. Misal ucun metodu call ederken "alama" ve 'c' deyerlerini gondersek metod bize -1, "alma"
        //ve 'a' deyerlerini gondersek 0 qaytarmalidir Bu metodu Main metodunda call edib isledeceksiniz.Metodu
        //call ederken gondereceyiniz deyerleri Main metodunda console-dan istifadeci daxil etmelidir.

        static int FindCharIndex(string str , char ch)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                    return i;
            }
            return -1;
        }
        #endregion

        #region Home Work - 2
        //IsPrime metodu - parametr olaraq ineteger value qebul edir. Gonderilims integer deyerin sade
        //olub olmadigini qaytarir.Eded sadedirse true, deyilse false qayitmalidir
        static bool IsPrime(int a)
        {
            int b = 0;

            if (a <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= a; i++)
                {
                    if (a % i == 0)
                    {
                        b++;
                    }
                }
            }
            return b > 1 ? true : false;
        }
        #endregion
    }
}

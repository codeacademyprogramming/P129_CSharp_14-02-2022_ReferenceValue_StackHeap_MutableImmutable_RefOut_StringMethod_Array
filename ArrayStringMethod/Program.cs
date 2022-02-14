using System;

namespace ArrayStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Methods
            //string word = "      Hello Wlorld Hello      ";
            //int strLength = word.Length;

            //Console.WriteLine(word[word.Length-1]);
            //Console.WriteLine(word.StartsWith('H'));
            //Console.WriteLine(word.StartsWith("World"));
            //Console.WriteLine(word.EndsWith("World"));
            //Console.WriteLine(word.EndsWith('d'));
            //Console.WriteLine(word.Contains('o'));
            //Console.WriteLine(word.Contains("ll w"));

            //int FirstOIndex = word.IndexOf('o');
            //FirstOIndex++;
            //int SecondOIndex = word.IndexOf('o', FirstOIndex);

            //Console.WriteLine(word.IndexOf('o', word.IndexOf('o')+1));
            //Console.WriteLine(word.IndexOf("llo"));

            //Console.WriteLine(word.IndexOf("llo", word.IndexOf("llo") + 1));
            //Console.WriteLine(word.IndexOf('o', word.IndexOf('o',word.IndexOf('o')+1) + 1,9));

            //Console.WriteLine(word.LastIndexOf('o'));
            //Console.WriteLine(word.LastIndexOf('o', word.LastIndexOf('o') - 1));
            //Console.WriteLine(word.LastIndexOf("oll"));

            //Console.WriteLine(word.LastIndexOf("llo", word.LastIndexOf("llo") - 1));
            //Console.WriteLine(word.LastIndexOf('o', word.LastIndexOf('o', word.LastIndexOf('o') - 1) - 1, 8));

            //char[] symbols = { 'H', 't', 'l' };
            //Console.WriteLine(word.IndexOfAny(symbols));
            //Console.WriteLine(word.Substring(7,7));
            //string[] arr = { word, "P129","Code","Academy","Hello" };
            //Console.WriteLine(String.Join(' ', arr, 1, 4));
            //Console.WriteLine(word.Remove(5));
            //Console.WriteLine(word.Remove(5,5));
            //Console.WriteLine(word.Replace('l','z'));
            //Console.WriteLine(word.Replace("Hello","Salam"));
            //Console.WriteLine(word.Replace("Hello",null));
            //foreach (string item in word.Split('l'))
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(word.ToLower());
            //Console.WriteLine(word.ToUpper());
            //Console.WriteLine(word);
            //Console.WriteLine(word.Trim());
            //Console.WriteLine(word.TrimEnd());
            //Console.WriteLine(word.TrimStart());
            //int a = 5;
            //Console.WriteLine(a.GetType());

            //Console.WriteLine(a.ToString().GetType());
            #endregion

            #region Array Method
            int[] arr1 = { 5, 7, 15, 12 };
            //arr1[0] = 5;
            //arr1[1] = 7;
            //arr1[2] = 15;
            //arr1[3] = 20;
            //arr1[4] = 33;

            //int[] arr2 = new int[5];
            //arr2[0] = 5;
            //arr2[1] = 7;
            //arr2[2] = 15;
            //arr2[3] = 20;
            //arr2[4] = 33;
            //arr2[5] = 66;

            //int[] arr3 = new int[] { };
            //Console.WriteLine(arr1.Length);
            //Array.Resize(ref arr1, 9);
            //Console.WriteLine(arr1.Length);
            //int i = arr1.Length;
            while (true)
            {
                Console.WriteLine("Deyer Daxil Edin");
                string str = Console.ReadLine();
                int num = int.Parse(str);
                Array.Resize(ref arr1, arr1.Length+1);
                arr1[arr1.Length-1] = num;
                Console.WriteLine("Davam Etmek Isdeyirsenmi  y/n");
                string changed = Console.ReadLine();
                
                if (changed != "y")
                {
                    break;
                }
                //i++;
            }

            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}

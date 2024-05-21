namespace Task_6___21._05._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. ValidatePassword(string password) - methodunuz olur, parameter olaraq qebul etdiyi stringin uzunlugu minimum 8,
             * böyük hərflə başlamalı, tərkibində minimum 1 rəqəm olmalı
             * və minimum 1 karakter (hərf və ya rəqəm olmayan: misal  ?, !, @) olmalıdır.
             * Bu hallar ödənirsə true, ödənmirsə false qaytarmalıdır.

            2. String`in Replace(), Substring(),Trim() methodlarını custom şəkildə yazmaq.
            Yəni sizin custom yazdığınız methodlarla stringin methodları eyni işi görməlidir.*/

            #region Task 1
            //Console.Write("Parolu daxil edin: ");
            //string password = Console.ReadLine();
            //Console.WriteLine(ValidatePassword(password));
            #endregion

            #region Task 2

            #region Replace
            //Console.Write("Sözü daxil edin: ");
            //string word = Console.ReadLine();

            //Console.Write("Evez etmek istediyiniz herfi yazin: ");
            //char ch = Convert.ToChar(Console.ReadLine());

            //Console.Write("Ne ile evez etmek istediyinizi yazin: ");
            //char newCh = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine(Replacee(word,ch,newCh));
            #endregion

            #region Substring
            //Console.Write("Sözü daxil edin: ");
            //string word = Console.ReadLine();

            //Console.Write("Baslamaq istediyiniz indexi yazin: ");
            //int startIndex = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Uzunlugu yazin: ");
            //int length = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Substringg(word, startIndex, length));
            #endregion

            #region Trim
            string word = "   Hello, World   ";
            string afterTrim = Trimm(word);

            Console.WriteLine(word);
            Console.WriteLine(afterTrim);
            #endregion

            #endregion
        }


        #region Task 1

        static bool ValidatePassword(string password)
        {
            if(password.Length < 8)
                return false;

            if (!char.IsUpper(password[0]))
                return false;
            
            bool flag = false;
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                    flag = true;
            }
            if (flag == false)
                return false;

            bool flag2  = false;
            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                    flag2 = true;
            }
            if(flag2 == false) 
                return false;

            return true;
        }

        #endregion

        #region Task 2

        #region Replace
        static string Replacee(string word, char ch, char newCh)
        {

            string result = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ch)
                    result += newCh;
                else
                    result += word[i];
            }

            return result;
        }
        #endregion

        #region Substring
        static string Substringg(string word, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex >= word.Length)
                Console.WriteLine("startIndex duzgun deyil!");

            if (length < 0 || startIndex + length > word.Length)
                Console.WriteLine("Uzunluq duzgun deyil!");

            string result = string.Empty;
            for (int i = 0; i < length; i++)
            {
                result += word[startIndex + i];
            }

            return result;
        }
        #endregion

        #region Trim

        static string Trimm(string word)
        {
            int startIndex = 0;
            int endIndex = word.Length - 1;

            while (startIndex <= endIndex && char.IsWhiteSpace(word[startIndex]))
                startIndex++;

            while (endIndex >= startIndex && char.IsWhiteSpace(word[endIndex]))
                endIndex--;

            int length = endIndex - startIndex + 1;
            return Substringg(word, startIndex, length);
        }

        #endregion

        #endregion

    }
}
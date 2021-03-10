using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSwapperArEn
{
    /// <summary>
    /// helper class to swap KeyboardLayout <see cref="LayoutEnToAr"/> , <see cref="LayoutArToEn"/>
    /// </summary>
    internal static class ConvertKeyboardLayout
    {

        #region -   En to Ar    -

        /// <summary>
        /// Converting text:<see cref="String"/> from wrong typing within a English KeyboardLayout to an Arabic KeyboardLayout
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string LayoutEnToAr(this string text)
        {
            StringBuilder s = new StringBuilder();
            foreach (char c in text)
            {
                switch (c)
                {
                    case 'a': s.Append('ش'); break;
                    case 'b':
                        s.Append('ل');
                        s.Append('ا'); break;
                    case 'c': s.Append('ؤ'); break;
                    case 'd': s.Append('ي'); break;
                    case 'e': s.Append('ث'); break;
                    case 'f': s.Append('ب'); break;
                    case 'g': s.Append('ل'); break;
                    case 'h': s.Append('ا'); break;
                    case 'i': s.Append('ه'); break;
                    case 'j': s.Append('ت'); break;
                    case 'k': s.Append('ن'); break;
                    case 'l': s.Append('م'); break;
                    case 'm': s.Append('ة'); break;
                    case 'n': s.Append('ى'); break;
                    case 'o': s.Append('خ'); break;
                    case 'p': s.Append('ح'); break;
                    case 'q': s.Append('ض'); break;
                    case 'r': s.Append('ق'); break;
                    case 's': s.Append('س'); break;
                    case 't': s.Append('ف'); break;
                    case 'u': s.Append('ع'); break;
                    case 'v': s.Append('ر'); break;
                    case 'w': s.Append('ص'); break;
                    case 'x': s.Append('ء'); break;
                    case 'y': s.Append('غ'); break;
                    case 'z': s.Append('ئ'); break;



                    case '`': s.Append('ذ'); break;
                    case ']': s.Append('د'); break;
                    case '[': s.Append('ج'); break;
                    case '\'': s.Append('ط'); break;
                    case ';': s.Append('ك'); break;
                    case '/': s.Append('ظ'); break;
                    case '.': s.Append('ز'); break;
                    case ',': s.Append('و'); break;



                    case 'H': s.Append('أ'); break;
                    case 'Y': s.Append('إ'); break;
                    case '?': s.Append('؟'); break;
                    case '>': s.Append('.'); break;
                    case 'N': s.Append('آ'); break;
                    case 'T':
                        s.Append('ل');
                        s.Append('إ'); break;
                    case 'G':
                        s.Append('ل');
                        s.Append('أ'); break;



                    case 'R': s.Append('ٌ'); break;
                    case 'E': s.Append('ُ'); break;
                    case 'W': s.Append('ً'); break;
                    case 'Q': s.Append('َ'); break;
                    case 'S': s.Append('ٍ'); break;
                    case 'A': s.Append('ِ'); break;
                    case 'X': s.Append('ْ'); break;
                    case 'Z': s.Append('~'); break;


                    default:
                        s.Append(c);
                        break;
                }
            }
            return s.ToString();
        }

     

        /// <summary>
        /// Converting character:<see cref="char"/> from wrong typing within a English KeyboardLayout to an Arabic KeyboardLayout
        /// <para> out char if  <param name="character"></param>  swap to two character  other return <see cref="null"/> </para>
        /// </summary>
        /// <param name="character"></param>
        /// <param name="Secoundcharacter"></param>
        /// <returns> char </returns>
        public static char LayoutEnToAr(this char character, out char? Secoundcharacter)
        {
            char first;
            Secoundcharacter = null;
            switch (character)
                {
                    case 'a': first='ش'; break;
                    case 'b':
                            first='ل';
                    Secoundcharacter = 'ا'; break;
                    case 'c': first='ؤ'; break;
                    case 'd': first='ي'; break;
                    case 'e': first='ث'; break;
                    case 'f': first='ب'; break;
                    case 'g': first='ل'; break;
                    case 'h': first='ا'; break;
                    case 'i': first='ه'; break;
                    case 'j': first='ت'; break;
                    case 'k': first='ن'; break;
                    case 'l': first='م'; break;
                    case 'm': first='ة'; break;
                    case 'n': first='ى'; break;
                    case 'o': first='خ'; break;
                    case 'p': first='ح'; break;
                    case 'q': first='ض'; break;
                    case 'r': first='ق'; break;
                    case 's': first='س'; break;
                    case 't': first='ف'; break;
                    case 'u': first='ع'; break;
                    case 'v': first='ر'; break;
                    case 'w': first='ص'; break;
                    case 'x': first='ء'; break;
                    case 'y': first='غ'; break;
                    case 'z': first='ئ'; break;



                    case '`': first='ذ'; break;
                    case ']': first='د'; break;
                    case '[': first='ج'; break;
                    case '\'': first='ط'; break;
                    case ';': first='ك'; break;
                    case '/': first='ظ'; break;
                    case '.': first='ز'; break;
                    case ',': first='و'; break;



                    case 'H': first='أ'; break;
                    case 'Y': first='إ'; break;
                    case '?': first='؟'; break;
                    case '>': first='.'; break;
                    case 'N': first='آ'; break;
                    case 'T':
                    first='ل';
                    Secoundcharacter = 'إ'; break;
                    case 'G':
                    first = 'ل';
                    Secoundcharacter = 'أ'; break;



                    case 'R': first='ٌ'; break;
                    case 'E': first='ُ'; break;
                    case 'W': first='ً'; break;
                    case 'Q': first='َ'; break;
                    case 'S': first='ٍ'; break;
                    case 'A': first='ِ'; break;
                    case 'X': first='ْ'; break;
                    case 'Z': first='~'; break;


                    default:
                    first=character;
                    Secoundcharacter = null;
                        break;
                }

            return first;
        }



        /// <summary>
        /// Converting character:<see cref="char"/> from wrong typing within a English KeyboardLayout to an Arabic KeyboardLayout
        /// <para> out two param fisrt and secound well be <see cref="null"/> if <see cref="false"/> </para>
        /// </summary>
        /// <param name="character"></param>
        /// <param name="Secoundcharacter"></param>
        /// <returns> bool is Secoundcharacter not null </returns>
        public static bool TryLayoutEnToAr(char character ,out char Firstcharacter, out char? Secoundcharacter)
        {
            Secoundcharacter = null;
            switch (character)
            {
                case 'a': Firstcharacter = 'ش'; break;
                case 'b':
                    Firstcharacter = 'ل';
                    Secoundcharacter = 'ا'; break;
                case 'c': Firstcharacter = 'ؤ'; break;
                case 'd': Firstcharacter = 'ي'; break;
                case 'e': Firstcharacter = 'ث'; break;
                case 'f': Firstcharacter = 'ب'; break;
                case 'g': Firstcharacter = 'ل'; break;
                case 'h': Firstcharacter = 'ا'; break;
                case 'i': Firstcharacter = 'ه'; break;
                case 'j': Firstcharacter = 'ت'; break;
                case 'k': Firstcharacter = 'ن'; break;
                case 'l': Firstcharacter = 'م'; break;
                case 'm': Firstcharacter = 'ة'; break;
                case 'n': Firstcharacter = 'ى'; break;
                case 'o': Firstcharacter = 'خ'; break;
                case 'p': Firstcharacter = 'ح'; break;
                case 'q': Firstcharacter = 'ض'; break;
                case 'r': Firstcharacter = 'ق'; break;
                case 's': Firstcharacter = 'س'; break;
                case 't': Firstcharacter = 'ف'; break;
                case 'u': Firstcharacter = 'ع'; break;
                case 'v': Firstcharacter = 'ر'; break;
                case 'w': Firstcharacter = 'ص'; break;
                case 'x': Firstcharacter = 'ء'; break;
                case 'y': Firstcharacter = 'غ'; break;
                case 'z': Firstcharacter = 'ئ'; break;



                case '`': Firstcharacter = 'ذ'; break;
                case ']': Firstcharacter = 'د'; break;
                case '[': Firstcharacter = 'ج'; break;
                case '\'':Firstcharacter = 'ط'; break;
                case ';': Firstcharacter = 'ك'; break;
                case '/': Firstcharacter = 'ظ'; break;
                case '.': Firstcharacter = 'ز'; break;
                case ',': Firstcharacter = 'و'; break;



                case 'H': Firstcharacter = 'أ'; break;
                case 'Y': Firstcharacter = 'إ'; break;
                case '?': Firstcharacter = '؟'; break;
                case '>': Firstcharacter = '.'; break;
                case 'N': Firstcharacter = 'آ'; break;
                case 'T':
                    Firstcharacter = 'ل';
                    Secoundcharacter = 'إ'; break;
                case 'G':
                    Firstcharacter = 'ل';
                    Secoundcharacter = 'أ'; break;



                case 'R': Firstcharacter = 'ٌ'; break;
                case 'E': Firstcharacter = 'ُ'; break;
                case 'W': Firstcharacter = 'ً'; break;
                case 'Q': Firstcharacter = 'َ'; break;
                case 'S': Firstcharacter = 'ٍ'; break;
                case 'A': Firstcharacter = 'ِ'; break;
                case 'X': Firstcharacter = 'ْ'; break;
                case 'Z': Firstcharacter = '~'; break;


                default:
                    Firstcharacter = character;
                    Secoundcharacter = null;
                    break;
            }

            return Secoundcharacter !=null;
        }

        #endregion


        #region -   Ar to En   -


        /// <summary>
        /// Converting text:<see cref="String"/> from wrong typing within a Arabic KeyboardLayout to an English KeyboardLayout
        /// </summary>
        /// <param name="text"></param>
        /// <returns> string  </returns>
        public static string LayoutArToEn(this string text)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'ش': s.Append('a'); break;

                    case 'ل' when (i + 1) != text.Length && text[i + 1] == 'ا': s.Append('b'); break;
                    case 'ل' when (i + 1) != text.Length && text[i + 1] == 'إ': s.Append('T'); break;
                    case 'ل' when (i + 1) != text.Length && text[i + 1] == 'أ': s.Append('G'); break;
                    case 'ل': s.Append('g'); break;


                    case 'ؤ': s.Append('c'); break;
                    case 'ي': s.Append('d'); break;
                    case 'ث': s.Append('e'); break;
                    case 'ب': s.Append('f'); break;

                    case 'ا' when (i != 0 && text[i - 1] != 'ل') || i == 0: s.Append('h'); break;

                    case 'ا' when (i != 0 && text[i - 1] == 'ل'): break;

                    case 'ه': s.Append('i'); break;
                    case 'ت': s.Append('j'); break;
                    case 'ن': s.Append('k'); break;
                    case 'م': s.Append('l'); break;
                    case 'ة': s.Append('m'); break;
                    case 'ى': s.Append('n'); break;
                    case 'خ': s.Append('o'); break;
                    case 'ح': s.Append('p'); break;
                    case 'ض': s.Append('q'); break;
                    case 'ق': s.Append('r'); break;
                    case 'س': s.Append('s'); break;
                    case 'ف': s.Append('t'); break;
                    case 'ع': s.Append('u'); break;
                    case 'ر': s.Append('v'); break;
                    case 'ص': s.Append('w'); break;
                    case 'ء': s.Append('x'); break;
                    case 'غ': s.Append('y'); break;
                    case 'ئ': s.Append('z'); break;



                    case 'ذ': s.Append('`'); break;
                    case 'د': s.Append(']'); break;
                    case 'ج': s.Append('['); break;
                    case 'ط': s.Append('\''); break;
                    case 'ك': s.Append(';'); break;
                    case 'ظ': s.Append('/'); break;
                    case 'ز': s.Append('.'); break;
                    case 'و': s.Append(','); break;



                    case 'أ': s.Append('H'); break;
                    case 'إ': s.Append('Y'); break;
                    case '؟': s.Append('?'); break;
                    case '.': s.Append('>'); break;
                    case 'آ': s.Append('N'); break;

                    case 'ٌ': s.Append('R'); break;
                    case 'ُ': s.Append('E'); break;
                    case 'ً': s.Append('W'); break;
                    case 'َ': s.Append('Q'); break;
                    case 'ٍ': s.Append('S'); break;
                    case 'ِ': s.Append('A'); break;
                    case 'ْ': s.Append('X'); break;
                    case '~': s.Append('Z'); break;


                    default:
                        s.Append(text[i]);
                        break;
                }
            }
            return s.ToString();
        }



        /// <summary>
        /// Converting character:<see cref="char"/> from wrong typing within a Arabic KeyboardLayout to an English KeyboardLayout
        /// <para> in char <param name="character"></param>  swap to two character is allow </para>
        /// </summary>
        /// <param name="character"></param>
        /// <param name="Secoundcharacter"></param>
        /// <returns> char </returns>
        public static char LayoutArToEn(this char character, in char? Secoundcharacter=null , in char? Previouscharacter = null )
        {
            char first= character;
            switch (character)
            {
                case 'ش': first='a'; break;

                case 'ل' when Secoundcharacter == 'ا':first='b'; break;
                case 'ل' when Secoundcharacter == 'إ':first='T'; break;
                case 'ل' when Secoundcharacter == 'أ':first='G'; break;
                case 'ل': first='g'; break;


                case 'ؤ': first='c'; break;
                case 'ي': first='d'; break;
                case 'ث': first='e'; break;
                case 'ب': first='f'; break;

                case 'ا' when (Previouscharacter != 'ل') || Previouscharacter==null: first='h'; break;

                case 'ا' when ( Previouscharacter == 'ل'): break;

                case 'ه': first='i'; break;
                case 'ت': first='j'; break;
                case 'ن': first='k'; break;
                case 'م': first='l'; break;
                case 'ة': first='m'; break;
                case 'ى': first='n'; break;
                case 'خ': first='o'; break;
                case 'ح': first='p'; break;
                case 'ض': first='q'; break;
                case 'ق': first='r'; break;
                case 'س': first='s'; break;
                case 'ف': first='t'; break;
                case 'ع': first='u'; break;
                case 'ر': first='v'; break;
                case 'ص': first='w'; break;
                case 'ء': first='x'; break;
                case 'غ': first='y'; break;
                case 'ئ': first='z'; break;



                case 'ذ': first='`'; break;
                case 'د': first=']'; break;
                case 'ج': first='['; break;
                case 'ط': first='\''; break;
                case 'ك': first=';'; break;
                case 'ظ': first='/'; break;
                case 'ز': first='.'; break;
                case 'و': first=','; break;



                case 'أ': first='H'; break;
                case 'إ': first='Y'; break;
                case '؟': first='?'; break;
                case '.': first='>'; break;
                case 'آ': first='N'; break;
                        
                case 'ٌ': first='R'; break;
                case 'ُ': first='E'; break;
                case 'ً': first='W'; break;
                case 'َ': first='Q'; break;
                case 'ٍ': first='S'; break;
                case 'ِ': first='A'; break;
                case 'ْ': first='X'; break;
                case '~': first = 'Z'; break;


                default:
                    first=character;
                    break;
            }

            return first;
        }



        /// <summary>
        /// Converting character:<see cref="char"/> from wrong typing within a Arabic KeyboardLayout to an English KeyboardLayout
        /// <para> out two param fisrt and secound well be <see cref="null"/> if <see cref="false"/> </para>
        /// </summary>
        /// <param name="character"></param>
        /// <param name="Secoundcharacter"></param>
        /// <returns> bool is Secoundcharacter not null </returns>
        public static bool TryLayoutArToEn(char character, char? Previouscharacter, out char Firstcharacter, out char? Secoundcharacter)
        {
            Secoundcharacter = null;
            switch (character)
            {
                case 'ش': Firstcharacter = 'a'; break;

                case 'ل' when Secoundcharacter == 'ا': Firstcharacter = 'b'; break;
                case 'ل' when Secoundcharacter == 'إ': Firstcharacter = 'T'; break;
                case 'ل' when Secoundcharacter == 'أ': Firstcharacter = 'G'; break;
                case 'ل': Firstcharacter = 'g'; break;


                case 'ؤ': Firstcharacter = 'c'; break;
                case 'ي': Firstcharacter = 'd'; break;
                case 'ث': Firstcharacter = 'e'; break;
                case 'ب': Firstcharacter = 'f'; break;

                case 'ا' when (Previouscharacter != 'ل') || Previouscharacter == null: Firstcharacter = 'h'; break;

                case 'ا' when (Previouscharacter == 'ل'): Firstcharacter = char.MinValue; break;

                case 'ه': Firstcharacter = 'i'; break;
                case 'ت': Firstcharacter = 'j'; break;
                case 'ن': Firstcharacter = 'k'; break;
                case 'م': Firstcharacter = 'l'; break;
                case 'ة': Firstcharacter = 'm'; break;
                case 'ى': Firstcharacter = 'n'; break;
                case 'خ': Firstcharacter = 'o'; break;
                case 'ح': Firstcharacter = 'p'; break;
                case 'ض': Firstcharacter = 'q'; break;
                case 'ق': Firstcharacter = 'r'; break;
                case 'س': Firstcharacter = 's'; break;
                case 'ف': Firstcharacter = 't'; break;
                case 'ع': Firstcharacter = 'u'; break;
                case 'ر': Firstcharacter = 'v'; break;
                case 'ص': Firstcharacter = 'w'; break;
                case 'ء': Firstcharacter = 'x'; break;
                case 'غ': Firstcharacter = 'y'; break;
                case 'ئ': Firstcharacter = 'z'; break;



                case 'ذ': Firstcharacter = '`'; break;
                case 'د': Firstcharacter = ']'; break;
                case 'ج': Firstcharacter = '['; break;
                case 'ط': Firstcharacter = '\''; break;
                case 'ك': Firstcharacter = ';'; break;
                case 'ظ': Firstcharacter = '/'; break;
                case 'ز': Firstcharacter = '.'; break;
                case 'و': Firstcharacter = ','; break;



                case 'أ': Firstcharacter = 'H'; break;
                case 'إ': Firstcharacter = 'Y'; break;
                case '؟': Firstcharacter = '?'; break;
                case '.': Firstcharacter = '>'; break;
                case 'آ': Firstcharacter = 'N'; break;

                case 'ٌ': Firstcharacter = 'R'; break;
                case 'ُ': Firstcharacter = 'E'; break;
                case 'ً': Firstcharacter = 'W'; break;
                case 'َ': Firstcharacter = 'Q'; break;
                case 'ٍ': Firstcharacter = 'S'; break;
                case 'ِ': Firstcharacter = 'A'; break;
                case 'ْ': Firstcharacter = 'X'; break;
                case '~': Firstcharacter = 'Z'; break;


                default:
                    Firstcharacter = character;
                    Secoundcharacter = null;
                    break;
            }

            return Secoundcharacter != null;
        }

        #endregion

    }
}

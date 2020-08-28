using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSwapperArEn
{
    internal static class ConvertKeyboardLayout
    {
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

                    case 'ا' when (i != 0 && text[i - 1] != 'ل') || i==0: s.Append('h'); break;

                    case 'ا' when (i != 0 && text[i - 1] == 'ل'):  break;

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
    }
}

using System;
using System.Linq;

namespace IntroOOP_7
{
    public class ACoder : ICoder
    {

        // DRY нервно круит в сторонке

        public string Encode(string input)
        {
            char[] arr = input.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {


                    case 'a':
                        arr[i] = 'b';
                        break;
                    case 'b':
                        arr[i] = 'c';
                        break;
                    case 'c':
                        arr[i] = 'd';
                        break;
                    case 'd':
                        arr[i] = 'e';
                        break;
                    case 'e':
                        arr[i] = 'f';
                        break;
                    case 'f':
                        arr[i] = 'g';
                        break;
                    case 'g':
                        arr[i] = 'h';
                        break;
                    case 'h':
                        arr[i] = 'i';
                        break;
                    case 'i':
                        arr[i] = 'j';
                        break;
                    case 'j':
                        arr[i] = 'k';
                        break;
                    case 'k':
                        arr[i] = 'l';
                        break;
                    case 'l':
                        arr[i] = 'm';
                        break;
                    case 'm':
                        arr[i] = 'n';
                        break;
                    case 'n':
                        arr[i] = 'o';
                        break;
                    case 'o':
                        arr[i] = 'p';
                        break;
                    case 'p':
                        arr[i] = 'q';
                        break;
                    case 'q':
                        arr[i] = 'r';
                        break;
                    case 'r':
                        arr[i] = 's';
                        break;
                    case 's':
                        arr[i] = 't';
                        break;
                    case 't':
                        arr[i] = 'u';
                        break;
                    case 'u':
                        arr[i] = 'v';
                        break;
                    case 'v':
                        arr[i] = 'w';
                        break;
                    case 'w':
                        arr[i] = 'x';
                        break;
                    case 'x':
                        arr[i] = 'y';
                        break;
                    case 'y':
                        arr[i] = 'z';
                        break;
                    case 'z':
                        arr[i] = 'a';
                        break;
                    case 'A':
                        arr[i] = 'B';
                        break;
                    case 'B':
                        arr[i] = 'C';
                        break;
                    case 'C':
                        arr[i] = 'D';
                        break;
                    case 'D':
                        arr[i] = 'E';
                        break;
                    case 'E':
                        arr[i] = 'F';
                        break;
                    case 'F':
                        arr[i] = 'G';
                        break;
                    case 'G':
                        arr[i] = 'H';
                        break;
                    case 'H':
                        arr[i] = 'I';
                        break;
                    case 'I':
                        arr[i] = 'J';
                        break;
                    case 'J':
                        arr[i] = 'K';
                        break;
                    case 'K':
                        arr[i] = 'L';
                        break;
                    case 'L':
                        arr[i] = 'M';
                        break;
                    case 'M':
                        arr[i] = 'N';
                        break;
                    case 'N':
                        arr[i] = 'O';
                        break;
                    case 'O':
                        arr[i] = 'P';
                        break;
                    case 'P':
                        arr[i] = 'Q';
                        break;
                    case 'Q':
                        arr[i] = 'R';
                        break;
                    case 'R':
                        arr[i] = 'S';
                        break;
                    case 'S':
                        arr[i] = 'T';
                        break;
                    case 'T':
                        arr[i] = 'U';
                        break;
                    case 'U':
                        arr[i] = 'V';
                        break;
                    case 'V':
                        arr[i] = 'W';
                        break;
                    case 'W':
                        arr[i] = 'X';
                        break;
                    case 'X':
                        arr[i] = 'Y';
                        break;
                    case 'Y':
                        arr[i] = 'Z';
                        break;
                    case 'Z':
                        arr[i] = 'A';
                        break;
                    default:
                        ;
                        break;
                }
            }
            return new string(arr);
        }

        public string Decode(string input)
        {
            char[] arr = input.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 'z':
                        arr[i] = 'y';
                        break;
                    case 'y':
                        arr[i] = 'x';
                        break;
                    case 'x':
                        arr[i] = 'w';
                        break;
                    case 'w':
                        arr[i] = 'v';
                        break;
                    case 'v':
                        arr[i] = 'u';
                        break;
                    case 'u':
                        arr[i] = 't';
                        break;
                    case 't':
                        arr[i] = 's';
                        break;
                    case 's':
                        arr[i] = 'r';
                        break;
                    case 'r':
                        arr[i] = 'q';
                        break;
                    case 'q':
                        arr[i] = 'p';
                        break;
                    case 'p':
                        arr[i] = 'o';
                        break;
                    case 'o':
                        arr[i] = 'n';
                        break;
                    case 'n':
                        arr[i] = 'm';
                        break;
                    case 'm':
                        arr[i] = 'l';
                        break;
                    case 'l':
                        arr[i] = 'k';
                        break;
                    case 'k':
                        arr[i] = 'j';
                        break;
                    case 'j':
                        arr[i] = 'i';
                        break;
                    case 'i':
                        arr[i] = 'h';
                        break;
                    case 'h':
                        arr[i] = 'g';
                        break;
                    case 'g':
                        arr[i] = 'f';
                        break;
                    case 'f':
                        arr[i] = 'e';
                        break;
                    case 'e':
                        arr[i] = 'd';
                        break;
                    case 'd':
                        arr[i] = 'c';
                        break;
                    case 'c':
                        arr[i] = 'b';
                        break;
                    case 'b':
                        arr[i] = 'a';
                        break;
                    case 'a':
                        arr[i] = 'z';
                        break;
                    case 'Z':
                        arr[i] = 'Y';
                        break;
                    case 'Y':
                        arr[i] = 'X';
                        break;
                    case 'X':
                        arr[i] = 'W';
                        break;
                    case 'W':
                        arr[i] = 'V';
                        break;
                    case 'V':
                        arr[i] = 'U';
                        break;
                    case 'U':
                        arr[i] = 'T';
                        break;
                    case 'T':
                        arr[i] = 'S';
                        break;
                    case 'S':
                        arr[i] = 'R';
                        break;
                    case 'R':
                        arr[i] = 'Q';
                        break;
                    case 'Q':
                        arr[i] = 'P';
                        break;
                    case 'P':
                        arr[i] = 'O';
                        break;
                    case 'O':
                        arr[i] = 'N';
                        break;
                    case 'N':
                        arr[i] = 'M';
                        break;
                    case 'M':
                        arr[i] = 'L';
                        break;
                    case 'L':
                        arr[i] = 'K';
                        break;
                    case 'K':
                        arr[i] = 'J';
                        break;
                    case 'J':
                        arr[i] = 'I';
                        break;
                    case 'I':
                        arr[i] = 'H';
                        break;
                    case 'H':
                        arr[i] = 'G';
                        break;
                    case 'G':
                        arr[i] = 'F';
                        break;
                    case 'F':
                        arr[i] = 'E';
                        break;
                    case 'E':
                        arr[i] = 'D';
                        break;
                    case 'D':
                        arr[i] = 'C';
                        break;
                    case 'C':
                        arr[i] = 'B';
                        break;
                    case 'B':
                        arr[i] = 'A';
                        break;
                    case 'A':
                        arr[i] = 'Z';
                        break;
                    default:
                        ;
                        break;
                }

            }
            return new string(arr);
        }
    }
}


using System;
namespace IntroOOP_7
{
    public class BCoder : ICoder
    {
        public string Encode(string input)
        {
            char[] arr = input.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 'a':
                        arr[i] = 'z';
                        break;
                    case 'b':
                        arr[i] = 'y';
                        break;
                    case 'c':
                        arr[i] = 'x';
                        break;
                    case 'd':
                        arr[i] = 'w';
                        break;
                    case 'e':
                        arr[i] = 'v';
                        break;
                    case 'f':
                        arr[i] = 'u';
                        break;
                    case 'g':
                        arr[i] = 't';
                        break;
                    case 'h':
                        arr[i] = 's';
                        break;
                    case 'i':
                        arr[i] = 'r';
                        break;
                    case 'j':
                        arr[i] = 'q';
                        break;
                    case 'k':
                        arr[i] = 'p';
                        break;
                    case 'l':
                        arr[i] = 'o';
                        break;
                    case 'm':
                        arr[i] = 'n';
                        break;
                    case 'n':
                        arr[i] = 'm';
                        break;
                    case 'o':
                        arr[i] = 'l';
                        break;
                    case 'p':
                        arr[i] = 'k';
                        break;
                    case 'q':
                        arr[i] = 'j';
                        break;
                    case 'r':
                        arr[i] = 'i';
                        break;
                    case 's':
                        arr[i] = 'h';
                        break;
                    case 't':
                        arr[i] = 'g';
                        break;
                    case 'u':
                        arr[i] = 'f';
                        break;
                    case 'v':
                        arr[i] = 'e';
                        break;
                    case 'w':
                        arr[i] = 'd';
                        break;
                    case 'x':
                        arr[i] = 'c';
                        break;
                    case 'y':
                        arr[i] = 'b';
                        break;
                    case 'z':
                        arr[i] = 'a';
                        break;
                    case 'A':
                        arr[i] = 'Z';
                        break;
                    case 'B':
                        arr[i] = 'Y';
                        break;
                    case 'C':
                        arr[i] = 'X';
                        break;
                    case 'D':
                        arr[i] = 'W';
                        break;
                    case 'E':
                        arr[i] = 'V';
                        break;
                    case 'F':
                        arr[i] = 'U';
                        break;
                    case 'G':
                        arr[i] = 'T';
                        break;
                    case 'H':
                        arr[i] = 'S';
                        break;
                    case 'I':
                        arr[i] = 'R';
                        break;
                    case 'J':
                        arr[i] = 'Q';
                        break;
                    case 'K':
                        arr[i] = 'P';
                        break;
                    case 'L':
                        arr[i] = 'O';
                        break;
                    case 'M':
                        arr[i] = 'N';
                        break;
                    case 'N':
                        arr[i] = 'M';
                        break;
                    case 'O':
                        arr[i] = 'L';
                        break;
                    case 'P':
                        arr[i] = 'K';
                        break;
                    case 'Q':
                        arr[i] = 'J';
                        break;
                    case 'R':
                        arr[i] = 'I';
                        break;
                    case 'S':
                        arr[i] = 'H';
                        break;
                    case 'T':
                        arr[i] = 'G';
                        break;
                    case 'U':
                        arr[i] = 'F';
                        break;
                    case 'V':
                        arr[i] = 'E';
                        break;
                    case 'W':
                        arr[i] = 'D';
                        break;
                    case 'X':
                        arr[i] = 'C';
                        break;
                    case 'Y':
                        arr[i] = 'B';
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
                    case 'a':
                        arr[i] = 'z';
                        break;
                    case 'b':
                        arr[i] = 'y';
                        break;
                    case 'c':
                        arr[i] = 'x';
                        break;
                    case 'd':
                        arr[i] = 'w';
                        break;
                    case 'e':
                        arr[i] = 'v';
                        break;
                    case 'f':
                        arr[i] = 'u';
                        break;
                    case 'g':
                        arr[i] = 't';
                        break;
                    case 'h':
                        arr[i] = 's';
                        break;
                    case 'i':
                        arr[i] = 'r';
                        break;
                    case 'j':
                        arr[i] = 'q';
                        break;
                    case 'k':
                        arr[i] = 'p';
                        break;
                    case 'l':
                        arr[i] = 'o';
                        break;
                    case 'm':
                        arr[i] = 'n';
                        break;
                    case 'n':
                        arr[i] = 'm';
                        break;
                    case 'o':
                        arr[i] = 'l';
                        break;
                    case 'p':
                        arr[i] = 'k';
                        break;
                    case 'q':
                        arr[i] = 'j';
                        break;
                    case 'r':
                        arr[i] = 'i';
                        break;
                    case 's':
                        arr[i] = 'h';
                        break;
                    case 't':
                        arr[i] = 'g';
                        break;
                    case 'u':
                        arr[i] = 'f';
                        break;
                    case 'v':
                        arr[i] = 'e';
                        break;
                    case 'w':
                        arr[i] = 'd';
                        break;
                    case 'x':
                        arr[i] = 'c';
                        break;
                    case 'y':
                        arr[i] = 'b';
                        break;
                    case 'z':
                        arr[i] = 'a';
                        break;
                    case 'A':
                        arr[i] = 'Z';
                        break;
                    case 'B':
                        arr[i] = 'Y';
                        break;
                    case 'C':
                        arr[i] = 'X';
                        break;
                    case 'D':
                        arr[i] = 'W';
                        break;
                    case 'E':
                        arr[i] = 'V';
                        break;
                    case 'F':
                        arr[i] = 'U';
                        break;
                    case 'G':
                        arr[i] = 'T';
                        break;
                    case 'H':
                        arr[i] = 'S';
                        break;
                    case 'I':
                        arr[i] = 'R';
                        break;
                    case 'J':
                        arr[i] = 'Q';
                        break;
                    case 'K':
                        arr[i] = 'P';
                        break;
                    case 'L':
                        arr[i] = 'O';
                        break;
                    case 'M':
                        arr[i] = 'N';
                        break;
                    case 'N':
                        arr[i] = 'M';
                        break;
                    case 'O':
                        arr[i] = 'L';
                        break;
                    case 'P':
                        arr[i] = 'K';
                        break;
                    case 'Q':
                        arr[i] = 'J';
                        break;
                    case 'R':
                        arr[i] = 'I';
                        break;
                    case 'S':
                        arr[i] = 'H';
                        break;
                    case 'T':
                        arr[i] = 'G';
                        break;
                    case 'U':
                        arr[i] = 'F';
                        break;
                    case 'V':
                        arr[i] = 'E';
                        break;
                    case 'W':
                        arr[i] = 'D';
                        break;
                    case 'X':
                        arr[i] = 'C';
                        break;
                    case 'Y':
                        arr[i] = 'B';
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
    }
}

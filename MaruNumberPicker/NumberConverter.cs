using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaruNumberPicker
{
    public class NumberConverter
    {
        static public string GetMaruNumber(int num)
        {
            var res = "";
            switch (num)
            {
                case 1:
                    res = "①";
                    break;
                case 2:
                    res = "②";
                    break;
                case 3:
                    res = "③";
                    break;
                case 4:
                    res = "④";
                    break;
                case 5:
                    res = "⑤";
                    break;
                case 6:
                    res = "⑥";
                    break;
                case 7:
                    res = "⑦";
                    break;
                case 8:
                    res = "⑧";
                    break;
                case 9:
                    res = "⑨";
                    break;
                case 10:
                    res = "⑩";
                    break;
                case 11:
                    res = "⑪";
                    break;
                case 12:
                    res = "⑫";
                    break;
                case 13:
                    res = "⑬";
                    break;
                case 14:
                    res = "⑭";
                    break;
                case 15:
                    res = "⑮";
                    break;
                case 16:
                    res = "⑯";
                    break;
                case 17:
                    res = "⑰";
                    break;
                case 18:
                    res = "⑱";
                    break;
                case 19:
                    res = "⑲";
                    break;
                case 20:
                    res = "⑳";
                    break;
                case 21:
                    res = "㉑";
                    break;
                case 22:
                    res = "㉒";
                    break;
                case 23:
                    res = "㉓";
                    break;
                case 24:
                    res = "㉔";
                    break;
                case 25:
                    res = "㉕";
                    break;
                case 26:
                    res = "㉖";
                    break;
                case 27:
                    res = "㉗";
                    break;
                case 28:
                    res = "㉘";
                    break;
                case 29:
                    res = "㉙";
                    break;
                case 30:
                    res = "㉚";
                    break;
                case 31:
                    res = "㉛";
                    break;
                case 32:
                    res = "㉜";
                    break;
                case 33:
                    res = "㉝";
                    break;
                case 34:
                    res = "㉞";
                    break;
                case 35:
                    res = "㉟";
                    break;
                case 36:
                    res = "㊱";
                    break;
                case 37:
                    res = "㊲";
                    break;
                case 38:
                    res = "㊳";
                    break;
                case 39:
                    res = "㊴";
                    break;
                case 40:
                    res = "㊵";
                    break;
                case 41:
                    res = "㊶";
                    break;
                case 42:
                    res = "㊷";
                    break;
                case 43:
                    res = "㊸";
                    break;
                case 44:
                    res = "㊹";
                    break;
                case 45:
                    res = "㊺";
                    break;
                case 46:
                    res = "㊻";
                    break;
                case 47:
                    res = "㊼";
                    break;
                case 48:
                    res = "㊽";
                    break;
                case 49:
                    res = "㊾";
                    break;
                case 50:
                    res = "㊿";
                    break;
                default:
                    break;
            }

            return res;
        }

        static public string GetLargeAlphabet(int num)
        {
            var res = "";
            switch (num)
            {
                case 1:
                    res = "A";
                    break;
                case 2:
                    res = "B";
                    break;
                case 3:
                    res = "C";
                    break;
                case 4:
                    res = "D";
                    break;
                case 5:
                    res = "E";
                    break;
                case 6:
                    res = "F";
                    break;
                case 7:
                    res = "G";
                    break;
                case 8:
                    res = "H";
                    break;
                case 9:
                    res = "I";
                    break;
                case 10:
                    res = "J";
                    break;
                case 11:
                    res = "K";
                    break;
                case 12:
                    res = "L";
                    break;
                case 13:
                    res = "M";
                    break;
                case 14:
                    res = "N";
                    break;
                case 15:
                    res = "O";
                    break;
                case 16:
                    res = "P";
                    break;
                case 17:
                    res = "Q";
                    break;
                case 18:
                    res = "R";
                    break;
                case 19:
                    res = "S";
                    break;
                case 20:
                    res = "T";
                    break;
                case 21:
                    res = "U";
                    break;
                case 22:
                    res = "V";
                    break;
                case 23:
                    res = "W";
                    break;
                case 24:
                    res = "X";
                    break;
                case 25:
                    res = "Y";
                    break;
                case 26:
                    res = "Z";
                    break;
                default:
                    break;
            }
            return res + ".";
        }

        static public string GetSmallAlphabet(int num)
        {
            var res = "";
            switch (num)
            {
                case 1:
                    res = "a";
                    break;
                case 2:
                    res = "b";
                    break;
                case 3:
                    res = "c";
                    break;
                case 4:
                    res = "d";
                    break;
                case 5:
                    res = "e";
                    break;
                case 6:
                    res = "f";
                    break;
                case 7:
                    res = "g";
                    break;
                case 8:
                    res = "h";
                    break;
                case 9:
                    res = "i";
                    break;
                case 10:
                    res = "j";
                    break;
                case 11:
                    res = "k";
                    break;
                case 12:
                    res = "l";
                    break;
                case 13:
                    res = "m";
                    break;
                case 14:
                    res = "n";
                    break;
                case 15:
                    res = "o";
                    break;
                case 16:
                    res = "p";
                    break;
                case 17:
                    res = "q";
                    break;
                case 18:
                    res = "r";
                    break;
                case 19:
                    res = "s";
                    break;
                case 20:
                    res = "t";
                    break;
                case 21:
                    res = "u";
                    break;
                case 22:
                    res = "v";
                    break;
                case 23:
                    res = "w";
                    break;
                case 24:
                    res = "x";
                    break;
                case 25:
                    res = "y";
                    break;
                case 26:
                    res = "z";
                    break;
                default:
                    break;
            }
            return res + ".";
        }

        static public string GetKakkoNumber(int num)
        {
            return "(" + num.ToString() + ")";
        }

        static public string GetZenkakuKakkoNumber(int num)
        {
            return "（" + GetZenkakuNumber(num) + "）";
        }

        static private string GetZenkakuNumber(int num)
        {
            var res = "";
            switch (num)
            {
                case 1:
                    res = "１";
                    break;
                case 2:
                    res = "２";
                    break;
                case 3:
                    res = "３";
                    break;
                case 4:
                    res = "４";
                    break;
                case 5:
                    res = "５";
                    break;
                case 6:
                    res = "６";
                    break;
                case 7:
                    res = "７";
                    break;
                case 8:
                    res = "８";
                    break;
                case 9:
                    res = "９";
                    break;
                case 10:
                    res = "１０";
                    break;
                case 11:
                    res = "１１";
                    break;
                case 12:
                    res = "１２";
                    break;
                case 13:
                    res = "１３";
                    break;
                case 14:
                    res = "１４";
                    break;
                case 15:
                    res = "１５";
                    break;
                case 16:
                    res = "１６";
                    break;
                case 17:
                    res = "１７";
                    break;
                case 18:
                    res = "１８";
                    break;
                case 19:
                    res = "１９";
                    break;
                case 20:
                    res = "２０";
                    break;
                case 21:
                    res = "２１";
                    break;
                case 22:
                    res = "２２";
                    break;
                case 23:
                    res = "２３";
                    break;
                case 24:
                    res = "２４";
                    break;
                case 25:
                    res = "２５";
                    break;
                case 26:
                    res = "２６";
                    break;
                case 27:
                    res = "２７";
                    break;
                case 28:
                    res = "２８";
                    break;
                case 29:
                    res = "２９";
                    break;
                case 30:
                    res = "３０";
                    break;
                case 31:
                    res = "３１";
                    break;
                case 32:
                    res = "３２";
                    break;
                case 33:
                    res = "３３";
                    break;
                case 34:
                    res = "３４";
                    break;
                case 35:
                    res = "３５";
                    break;
                case 36:
                    res = "３６";
                    break;
                case 37:
                    res = "３７";
                    break;
                case 38:
                    res = "３８";
                    break;
                case 39:
                    res = "３９";
                    break;
                case 40:
                    res = "４０";
                    break;
                case 41:
                    res = "４１";
                    break;
                case 42:
                    res = "４２";
                    break;
                case 43:
                    res = "４３";
                    break;
                case 44:
                    res = "４４";
                    break;
                case 45:
                    res = "４５";
                    break;
                case 46:
                    res = "４６";
                    break;
                case 47:
                    res = "４７";
                    break;
                case 48:
                    res = "４８";
                    break;
                case 49:
                    res = "４９";
                    break;
                case 50:
                    res = "５０";
                    break;
                case 51:
                    res = "５１";
                    break;
                case 52:
                    res = "５２";
                    break;
                case 53:
                    res = "５３";
                    break;
                case 54:
                    res = "５４";
                    break;
                case 55:
                    res = "５５";
                    break;
                case 56:
                    res = "５６";
                    break;
                case 57:
                    res = "５７";
                    break;
                case 58:
                    res = "５８";
                    break;
                case 59:
                    res = "５９";
                    break;
                case 60:
                    res = "６０";
                    break;
                case 61:
                    res = "６１";
                    break;
                case 62:
                    res = "６２";
                    break;
                case 63:
                    res = "６３";
                    break;
                case 64:
                    res = "６４";
                    break;
                case 65:
                    res = "６５";
                    break;
                case 66:
                    res = "６６";
                    break;
                case 67:
                    res = "６７";
                    break;
                case 68:
                    res = "６８";
                    break;
                case 69:
                    res = "６９";
                    break;
                case 70:
                    res = "７０";
                    break;
                case 71:
                    res = "７１";
                    break;
                case 72:
                    res = "７２";
                    break;
                case 73:
                    res = "７３";
                    break;
                case 74:
                    res = "７４";
                    break;
                case 75:
                    res = "７５";
                    break;
                case 76:
                    res = "７６";
                    break;
                case 77:
                    res = "７７";
                    break;
                case 78:
                    res = "７８";
                    break;
                case 79:
                    res = "７９";
                    break;
                case 80:
                    res = "８０";
                    break;
                case 81:
                    res = "８１";
                    break;
                case 82:
                    res = "８２";
                    break;
                case 83:
                    res = "８３";
                    break;
                case 84:
                    res = "８４";
                    break;
                case 85:
                    res = "８５";
                    break;
                case 86:
                    res = "８６";
                    break;
                case 87:
                    res = "８７";
                    break;
                case 88:
                    res = "８８";
                    break;
                case 89:
                    res = "８９";
                    break;
                case 90:
                    res = "９０";
                    break;
                case 91:
                    res = "９１";
                    break;
                case 92:
                    res = "９２";
                    break;
                case 93:
                    res = "９３";
                    break;
                case 94:
                    res = "９４";
                    break;
                case 95:
                    res = "９５";
                    break;
                case 96:
                    res = "９６";
                    break;
                case 97:
                    res = "９７";
                    break;
                case 98:
                    res = "９８";
                    break;
                case 99:
                    res = "９９";
                    break;
                default:
                    break;
            }
            return res;

        }
    }
}

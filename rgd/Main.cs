using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgd.main
{
    class Main
    {
        Dictionary<char, string> alphabet = new Dictionary<char, string>()
        {
            {'а',"a" },
            {'б',"b"},
            {'в',"v" },
            {'г',"g" },
            {'д',"d" },
            {'е',"e" },
            {'ё',"e" },
            {'ж',"zh" },
            {'з',"z" },
            {'и',"i" },
            {'й',"i" },
            {'к',"k" },
            {'л',"l" },
            {'м',"m" },
            {'н',"n" },
            {'о',"o" },
            {'п',"p" },
            {'р',"r" },
            {'с',"s" },
            {'т',"t" },
            {'у',"u" },
            {'ф',"f" },
            {'х',"kh" },
            {'ц',"ts" },
            {'ч',"ch" },
            {'ш',"sh" },
            {'щ',"shch" },
            {'ы',"y" },
            {'ъ',"ie" },
            {'э',"e" },
            {'ю',"iu" },
            {'я',"ia" },
            {'А',"A" },
            {'Б',"B"},
            {'В',"V" },
            {'Г',"G" },
            {'Д',"D" },
            {'Е',"E" },
            {'Ё',"E" },
            {'Ж',"Zh" },
            {'З',"Z" },
            {'И',"I" },
            {'Й',"I" },
            {'К',"K" },
            {'Л',"L" },
            {'М',"M" },
            {'Н',"N" },
            {'О',"O" },
            {'П',"P" },
            {'Р',"R" },
            {'С',"S" },
            {'Т',"T" },
            {'У',"U" },
            {'Ф',"F" },
            {'Х',"Kh" },
            {'Ц',"Ts" },
            {'Ч',"Ch" },
            {'Ш',"Sh" },
            {'Щ',"Shch" },
            {'Э',"E" },
            {'Ю',"Iu" },
            {'Я',"Ia" },
            {'ь',"" },
            {' '," " }
        };

        public Dictionary<char, string> Alphabet { get => alphabet; }
        public string Translate(string str)
        {
            string transl = "";
            foreach(char c in str)
            {
                if (alphabet.ContainsKey(c)) transl += alphabet[c];
                else transl += c;
            }
            return transl;
        }
    }
}

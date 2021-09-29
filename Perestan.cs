using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perestanovka
{
    class Perestan
    {
        string Alfa = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string Number = "0123456789";
        public string Simple(string key, string text)
        {
            text = text.ToLower();
            char[] value = new char[text.Length];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = text[i];
            }
            int[] k = new int[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                k[i] = Number.IndexOf(key[i]);
            }
            for (int i = 0; i < text.Length; i++)
            {
                value[k[i]-1] = text[i];
            }
            string v = null;
            for (int i = 0; i < value.Length; i++)
            {
                v += value[i];
            }
            return v;
        }

        public string BlockSimple(string key, string text)
        {
            text = text.ToLower();
            char[] value = new char[text.Length];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = text[i];
            }
            while (value.Length % key.Length != 0)
            {
                char[] tem = new char[value.Length + 1];
                for (int i = 0; i < value.Length; i++)
                {
                    tem[i] = value[i];
                }
                tem[tem.Length - 1] = 'а';
                value = tem;
            }

            string temp = null;
            string v = null;
            for (int i = 0; i < value.Length; i++)
            {
                temp += value[i];
                if (temp.Length % key.Length == 0) 
                { 
                    v += Simple(key, temp);
                    temp = null;
                }           
            }
            return v;
        }

        public string Table(string text, int nextx, int nexty, int count)
        {
            text = text.ToLower();
            char[] value = new char[text.Length];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = text[i];
            }
            while (value.Length % count != 0)
            {
                char[] tem = new char[value.Length + 1];
                for (int i = 0; i < value.Length; i++)
                {
                    tem[i] = value[i];
                }
                tem[tem.Length - 1] = 'а';
                value = tem;
            }
            char[,] table = new char[count, value.Length / count];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                { 
                    if(nextx == 1)
                    {
                        table[i, j] = value[i + (j * table.GetLength(0))];
                    }
                    else if (nextx == 2)
                    {
                        table[table.GetLength(0) - i - 1, j] = value[i + (j * table.GetLength(0))];
                    }
                }
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (nexty == 1)
                    {
                        value[j + (i * table.GetLength(1))] = table[i, j];
                    }
                    else if (nexty == 2)
                    {
                        value[j + (i * table.GetLength(1))] = table[i, table.GetLength(1) - j - 1];
                    }
                }
            }
            string v = null;
            for (int i = 0; i < value.Length; i++)
            {
                v += value[i];
            }
            return v;
        }

        public string Vertical(string key, string text)
        {
            text = text.ToLower();
            char[] value = new char[text.Length];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = text[i];
            }
            while (value.Length % key.Length != 0)
            {
                char[] tem = new char[value.Length + 1];
                for (int i = 0; i < value.Length; i++)
                {
                    tem[i] = value[i];
                }
                tem[tem.Length - 1] = 'а';
                value = tem;
            }
            char[,] table = new char[key.Length, value.Length / key.Length];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                        table[i, j] = value[i + (j * table.GetLength(0))];
                }
            }
            int[] k = new int[key.Length];
            
            for (int i = 0; i < key.Length; i++)
            {
                int min = 0;
                while (k[min] != 0)
                    min++;
                for (int j = 0; j < key.Length; j++)
                {
                    if (key[min] > key[j] && k[j] == 0)
                        min = j;
                }
                k[min] = i + 1; 
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {
                int min = 0;
                for (int j = 0; j < key.Length; j++)
                {
                    if (k[j] < k[min])
                        min = j;
                }
                k[min] = k.Length+2;
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    value[j + (i * table.GetLength(1))] = table[min, j];
                }
            }
            string v = null;
            for (int i = 0; i < value.Length; i++)
            {
                v += value[i];
            }
            return v;
        }

        public string Rotate(string text)
        {
            int[,] grid = new int[4, 4] {
                { 1,0,1,0},
                { 0,0,0,0},
                { 0,1,0,1},
                { 0,0,0,0} };

            text = text.ToLower();
            char[] value = new char[text.Length];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = text[i];
            }
            while (value.Length % 16 != 0)
            {
                char[] tem = new char[value.Length + 1];
                for (int i = 0; i < value.Length; i++)
                {
                    tem[i] = value[i];
                }
                tem[tem.Length - 1] = 'а';
                value = tem;
            }

            char[,] table = new char[4,4];
            string v = null;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = value[i + (j * table.GetLength(0))];
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        v += table[i, j];
                    }
                }
            }

            grid = new int[4, 4] {
                { 0,1,0,1},
                { 0,0,0,0},
                { 1,0,1,0},
                { 0,0,0,0} };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        v += table[i, j];
                    }
                }
            }
            grid = new int[4, 4] {
                { 0,0,0,0},
                { 1,0,1,0},
                { 0,0,0,0},
                { 0,1,0,1} };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        v += table[i, j];
                    }
                }
            }
            grid = new int[4, 4] {
                { 0,0,0,0},
                { 0,1,0,1},
                { 0,0,0,0},
                { 1,0,1,0} };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        v += table[i, j];
                    }
                }
            }

            return v;
        }

        public string Magical(string text)
        {
            int[,] grid = new int[4, 4] {
                { 16,3,2,13},
                { 5,10,11,8},
                { 9,6,7,12},
                { 4,15,14,1} };

            text = text.ToLower();
            char[] value = new char[text.Length];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = text[i];
            }
            while (value.Length % 16 != 0)
            {
                char[] tem = new char[value.Length + 1];
                for (int i = 0; i < value.Length; i++)
                {
                    tem[i] = value[i];
                }
                tem[tem.Length - 1] = '.';
                value = tem;
            }

            char[,] table = new char[4, 4];
            string v = null;
            for (int l = 0; l < 16; l++)
            {
                int minx = 0;
                int miny = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (grid[i, j] < grid[minx, miny])
                        {
                            minx = i;
                            miny = j;
                        }
                    }
                }
                grid[minx, miny] = 34;
                table[minx, miny] = value[l];
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    v += table[i, j];
                }
            }

            return v;
        }

        public string Double(string keyx, string keyy, string text)
        {
            text = text.ToLower();
            char[] value = new char[text.Length];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = text[i];
            }
            while (value.Length % (keyx.Length * keyy.Length) != 0)
            {
                char[] tem = new char[value.Length + 1];
                for (int i = 0; i < value.Length; i++)
                {
                    tem[i] = value[i];
                }
                tem[tem.Length - 1] = 'а';
                value = tem;
            }
            char[,] table = new char[keyx.Length, keyy.Length];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = value[i + (j * table.GetLength(0))];
                }
            }
            int[] kx = new int[keyx.Length];
            int[] ky = new int[keyy.Length];

            for (int i = 0; i < keyx.Length; i++)
            {
                int min = 0;
                while (kx[min] != 0)
                    min++;
                for (int j = 0; j < keyx.Length; j++)
                {
                    if (keyx[min] > keyx[j] && kx[j] == 0)
                        min = j;
                }
                kx[min] = i + 1;
            }

            for (int i = 0; i < keyy.Length; i++)
            {
                int min = 0;
                while (ky[min] != 0)
                    min++;
                for (int j = 0; j < keyy.Length; j++)
                {
                    if (keyy[min] > keyy[j] && ky[j] == 0)
                        min = j;
                }
                ky[min] = i + 1;
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {
                int min = i;
                for (int j = min; j < keyx.Length; j++)
                {
                    if (kx[j] < kx[min])
                        min = j;
                }
                int t = kx[i];
                kx[i] = kx[min];
                kx[min] = t;
                //kx[min] = kx.Length + 2;
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    var temp = table[i, j];
                    table[i, j] = table[min, j];
                    table[min, j] = temp;

                    //value[j + (i * table.GetLength(1))] = table[min, j];
                }
            }

            for (int i = 0; i < table.GetLength(1); i++)
            {
                int min = 0;
                for (int j = min; j < keyy.Length; j++)
                {
                    if (ky[j] < ky[min])
                        min = j;
                }
                ky[min] = ky.Length + 2;
                for (int j = 0; j < table.GetLength(0); j++)
                {
                    value[j + (i * table.GetLength(0))] = table[j, min];
                }
            }

            string v = null;
            for (int i = 0; i < value.Length; i++)
            {
                v += value[i];
            }
            return v;
        }
    }
}

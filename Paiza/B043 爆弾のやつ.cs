//初めて例外処理を使ってみたよ
//見事１００点クリア！

using System;
public class Bomb 
{
    public void Start()
    {

        string[] line2 = Console.ReadLine().Split(' ');
        int h = int.Parse(line2[0]);
        int w = int.Parse(line2[1]);
        char[, ] map = new char[h, w];

        for (int i = 0; i < h; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < w; j++)
            {

                map[i, j] = line[j];
                //Console.WriteLine(map[i,j]);
            }
        }


        //ここまでで設定

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                try
                {
                    int a = int.Parse(map[i, j].ToString());
                    for (int k = 1; k < a + 1; k++)
                    {
                        if (map[i, j + k] == '#')
                        {
                            break;
                        }
                        else if (map[i, j + k] == 'X')
                        {
                            map[i, j + k] = '.';
                        }
                    }
                    for (int k = 1; k < a + 1; k++)
                    {
                        if (map[i, j - k] == '#')
                        {
                            break;
                        }
                        else if (map[i, j - k] == 'X')
                        {
                            map[i, j - k] = '.';
                        }
                    }
                    for (int k = 1; k < a + 1; k++)
                    {
                        if (map[i + k, j] == '#')
                        {
                            break;
                        }
                        else if (map[i + k, j] == 'X')
                        {
                            map[i + k, j] = '.';
                        }
                    }
                    for (int k = 1; k < a + 1; k++)
                    {
                        if (map[i - k, j] == '#')
                        {
                            break;
                        }
                        else if (map[i - k, j] == 'X')
                        {
                            map[i - k, j] = '.';
                        }
                    }
                }
                catch { }
            }
        }
        string clear = "YES";
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                if (map[i, j] == 'X')
                {
                    clear = "No";
                    goto finish;
                }
            }
        }
        finish:
            Console.WriteLine(clear);


    }
}
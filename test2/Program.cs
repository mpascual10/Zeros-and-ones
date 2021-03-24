using System;
using System.Collections.Generic;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "111000";
            string r = "01010";
            string v = "111*000";

            Console.WriteLine(zerosAndOnes(r));
            Console.WriteLine(zerosAndOnes(s));
            Console.WriteLine(zerosAndOnes(v));




            int zerosAndOnes(string s)
            {
                
                List<char> dataList = new List<char>();

                dataList.AddRange(s);

                //2 pointer forloop

                if (dataList.Count != 0)
                {
                    for (int i = 0, j = 1; j < dataList.Count;)
                    {

                        if (dataList.Count > 1)
                        {
                            if (dataList[i] == '0' && dataList[j] == '1' || dataList[i] == '1' && dataList[j] == '0')
                            {
                                dataList.RemoveAt(j);
                                dataList.RemoveAt(i);

                                if (i != 0)
                                {
                                    i--;
                                    j--;
                                }
                            }
                            else
                            {

                                i++;
                                j++;

                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                    int answer = dataList.Count;
                

                return answer;

            }





        }

        

    }


}

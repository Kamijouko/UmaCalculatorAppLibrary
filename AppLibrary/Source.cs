using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary
{
    public class Source   
    {
        public string name;

        public SubData a1;
        public SubData a2;
        public SubData a3;
        public SubData a4;
        public SubData a5;
        public SubData a6;
        public SubData a7;
        public SubData a8;
        public SubData a9;
        public SubData a10;
        public SubData a11;
        public SubData a12;
        public SubData a13;
        public SubData a14;
        public SubData a15;
        public SubData a16;
        public SubData a17;
        public SubData a18;
        public SubData a19;
        public SubData a20;
        public SubData a21;
        public SubData a22;
        public SubData a23;
        public SubData a24;
        public SubData a25;
        public SubData a26;
        public SubData a27;
        public SubData a28;
        public SubData a29;
        public SubData a30;
        public SubData a31;

        public List<SubData> listA = new List<SubData>();

        public string Source_name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = Source_name;
            }
        }

        public Source()
        {

        }

        public Source(string n, int? i = null)
        {
            this.name = n;

            if (i == null || i == 0)
            {
                this.SourceA();
            }
            if (i == 1)
            {
                this.SourceA();
            }
            if (i == 2)
            {
                this.SourceB();
            }
            if (i == 3)
            {
                this.SourceC();
            }
        }

        public void SourceA()
        {
            a1 = new SubData("爱丽速子", 1);
            a2 = new SubData("胜利奖券", 2);
            a3 = new SubData("伏特加", 3);
            a4 = new SubData("气槽", 4);
            a5 = new SubData("神鹰", 5);
            a6 = new SubData("小栗帽", 6);
            a7 = new SubData("帝王光环", 7);
            a8 = new SubData("草上飞", 8);
            a9 = new SubData("黄金船", 9);
            a10 = new SubData("无声铃鹿", 10);
            a11 = new SubData("樱花暴进王", 11);
            a12 = new SubData("象征鲁道夫(皇帝)", 12);
            a13 = new SubData("超级小海湾", 13);
            a14 = new SubData("特别周", 14);
            a15 = new SubData("大树快车", 15);
            a16 = new SubData("大和赤骥", 16);
            a17 = new SubData("好歌剧", 17);
            a18 = new SubData("东海帝王", 18);
            a19 = new SubData("优秀素质", 19);
            a20 = new SubData("春麗", 20);
            a21 = new SubData("待兼福来", 21);
            a22 = new SubData("重炮", 22);
            a23 = new SubData("丸善斯基", 23);
            a24 = new SubData("美浦波旁", 24);
            a25 = new SubData("目白麦昆", 25);
            a26 = new SubData("目白赖恩", 26);
            a27 = new SubData("米浴", 27);

            a1.value.valueList = new List<int> { 0, 26, 27, 20, 18, 26, 21, 25, 20, 20, 11, 20, 20, 27, 11, 19, 21, 23, 28, 3, 27, 19, 12, 21, 21, 26, 18 };
            a2.value.valueList = new List<int> { 0, 26, 19, 18, 28, 19, 24, 22, 20, 12, 20, 21, 29, 11, 19, 20, 21, 27, 3, 27, 22, 12, 20, 21, 25, 18 };
            a3.value.valueList = new List<int> { 0, 22, 25, 33, 20, 31, 18, 18, 10, 19, 19, 28, 18, 34, 20, 24, 26, 3, 25, 18, 17, 27, 21, 24, 17 };
            a4.value.valueList = new List<int> { 0, 25, 18, 14, 18, 19, 20, 19, 27, 27, 20, 18, 29, 26, 28, 19, 3, 19, 18, 11, 19, 27, 17, 24 };
            a5.value.valueList = new List<int> { 0, 25, 15, 35, 19, 19, 19, 29, 25, 25, 29, 32, 26, 26, 17, 2, 18, 18, 19, 24, 24, 19, 28 };
            a6.value.valueList = new List<int> { 0, 19, 32, 22, 20, 11, 19, 26, 27, 20, 26, 22, 20, 28, 3, 27, 22, 18, 26, 20, 27, 18 };
            a7.value.valueList = new List<int> { 0, 23, 13, 13, 18, 12, 12, 24, 19, 13, 12, 15, 20, 13, 20, 12, 18, 20, 16, 18, 11 };
            a8.value.valueList = new List<int> { 0, 19, 20, 12, 21, 17, 31, 21, 25, 19, 19, 24, 3, 25, 20, 19, 25, 18, 27, 20 };
            a9.value.valueList = new List<int> { 0, 21, 11, 30, 30, 28, 11, 20, 31, 22, 28, 13, 21, 32, 11, 20, 33, 19, 27 };
            a10.value.valueList = new List<int> { 0, 13, 18, 22, 25, 14, 19, 21, 20, 21, 3, 27, 28, 19, 26, 22, 20, 17 };
            a11.value.valueList = new List<int> { 0, 19, 19, 11, 29, 17, 18, 19, 14, 12, 13, 11, 18, 19, 20, 16, 21 };
            a12.value.valueList = new List<int> { 0, 33, 28, 22, 26, 37, 30, 24, 3, 18, 28, 11, 19, 33, 19, 38 };
            a13.value.valueList = new List<int> { 0, 31, 18, 27, 35, 26, 27, 3, 23, 29, 11, 19, 36, 18, 34 };
            a14.value.valueList = new List<int> { 0, 11, 19, 31, 22, 35, 7, 30, 28, 13, 20, 29, 26, 25 };
            a15.value.valueList = new List<int> { 0, 24, 19, 19, 11, 9, 15, 11, 26, 24, 18, 13, 21 };
            a16.value.valueList = new List<int> { 0, 26, 30, 18, 4, 19, 19, 19, 25, 28, 16, 24 };
            a17.value.valueList = new List<int> { 0, 29, 26, 3, 19, 31, 10, 20, 35, 18, 34 };
            a18.value.valueList = new List<int> { 0, 23, 3, 19, 22, 11, 22, 31, 19, 27 };
            a19.value.valueList = new List<int> { 0, 3, 27, 27, 10, 20, 29, 27, 26 };
            a20.value.valueList = new List<int> { 0, 3, 3, 9, 11, 4, 3, 4 };
            a21.value.valueList = new List<int> { 0, 21, 12, 19, 21, 25, 19 };
            a22.value.valueList = new List<int> { 0, 17, 26, 30, 19, 27 };
            a23.value.valueList = new List<int> { 0, 32, 10, 10, 12 };
            a24.value.valueList = new List<int> { 0, 20, 18, 18 };
            a25.value.valueList = new List<int> { 0, 24, 35 };
            a26.value.valueList = new List<int> { 0, 21 };
            a27.value.valueList = new List<int> { 0 };

            listA.Add(a1);
            listA.Add(a2);
            listA.Add(a3);
            listA.Add(a4);
            listA.Add(a5);
            listA.Add(a6);
            listA.Add(a7);
            listA.Add(a8);
            listA.Add(a9);
            listA.Add(a10);
            listA.Add(a11);
            listA.Add(a12);
            listA.Add(a13);
            listA.Add(a14);
            listA.Add(a15);
            listA.Add(a16);
            listA.Add(a17);
            listA.Add(a18);
            listA.Add(a19);
            listA.Add(a20);
            listA.Add(a21);
            listA.Add(a22);
            listA.Add(a23);
            listA.Add(a24);
            listA.Add(a25);
            listA.Add(a26);
            listA.Add(a27);
        }

        public void SourceB()
        {
            a1 = new SubData("爱丽速子", 1);
            a2 = new SubData("胜利奖券", 2);
            a3 = new SubData("伏特加", 3);
            a4 = new SubData("气槽", 4);
            a5 = new SubData("神鹰", 5);
            a6 = new SubData("小栗帽", 6);
            a7 = new SubData("帝王光环", 7);
            a8 = new SubData("草上飞", 8);
            a9 = new SubData("黄金船", 9);
            a10 = new SubData("无声铃鹿", 10);
            a11 = new SubData("樱花暴进王", 11);
            a12 = new SubData("象征鲁道夫(皇帝)", 12);
            a13 = new SubData("超级小海湾", 13);
            a14 = new SubData("特别周", 14);
            a15 = new SubData("大树快车", 15);
            a16 = new SubData("大和赤骥", 16);
            a17 = new SubData("好歌剧", 17);
            a18 = new SubData("东海帝王", 18);
            a19 = new SubData("优秀素质", 19);
            a20 = new SubData("春麗", 20);
            a21 = new SubData("琵琶晨光", 21);
            a22 = new SubData("待兼福来", 22);
            a23 = new SubData("重炮", 23);
            a24 = new SubData("丸善斯基", 24);
            a25 = new SubData("美浦波旁", 25);
            a26 = new SubData("目白麦昆", 26);
            a27 = new SubData("目白赖恩", 27);
            a28 = new SubData("米浴", 28);


            a1.value.valueList = new List<int> { 0,24,25,18,16,24,19,23,18,20,11,18,18,25,11,17,19,21,26,3,17,27,17,10,21,19,24,18 };
            a2.value.valueList = new List<int> { 0,24,19,16,26,17,22,22,18,10,18,19,27,9,17,18,19,25,3,26,25,20,10,18,19,25,16 };
            a3.value.valueList = new List<int> { 0,20,23,31,18,29,16,16,8,17,17,26,16,34,18,24,24,3,16,23,16,15,25,21,22,15 };
            a4.value.valueList = new List<int> { 0,23,16,12,16,19,18,17,25,25,18,16,27,24,26,17,3,25,17,16,9,17,25,17,22 };
            a5.value.valueList = new List<int> { 0,23,15,35,17,17,17,27,23,25,27,30,26,24,17,2,23,16,16,17,22,22,17,26 };
            a6.value.valueList = new List<int> { 0,17,30,20,18,9,19,26,25,18,24,20,18,26,3,18,25,20,18,24,18,25,16 };
            a7.value.valueList = new List<int> { 0,23,11,11,16,10,10,24,17,11,12,13,20,13,10,18,10,16,18,14,16,9 };
            a8.value.valueList = new List<int> { 0,17,18,10,19,15,31,19,23,19,17,24,3,16,23,18,17,23,16,25,18 };
            a9.value.valueList = new List<int> { 0,19,9,28,28,26,9,18,29,20,26,11,31,19,30,9,18,31,19,25 };
            a10.value.valueList = new List<int> { 0,13,16,20,23,14,17,19,18,19,3,18,27,26,17,26,20,18,17 };
            a11.value.valueList = new List<int> { 0,17,17,9,29,15,16,17,12,10,16,13,9,16,19,18,14,21 };
            a12.value.valueList = new List<int> { 0,33,26,20,24,35,28,22,1,33,16,26,11,17,31,17,36 };
            a13.value.valueList = new List<int> { 0,29,16,25,33,24,25,3,34,21,27,11,17,34,16,32 };
            a14.value.valueList = new List<int> { 0,9,17,31,20,35,7,25,28,26,11,18,27,24,23 };
            a15.value.valueList = new List<int> { 0,22,17,17,9,7,16,15,9,24,24,16,11,21 };
            a16.value.valueList = new List<int> { 0,24,30,16,4,24,17,17,17,23,28,14,22 };
            a17.value.valueList = new List<int> { 0,27,26,5,36,17,29,8,18,33,16,32 };
            a18.value.valueList = new List<int> { 0,21,3,25,17,20,9,20,31,17,25 };
            a19.value.valueList = new List<int> { 0,5,24,25,25,8,18,27,25,24 };
            a20.value.valueList = new List<int> { 0,2,3,3,7,9,4,1,2 };
            a21.value.valueList = new List<int> { 0,18,28,9,17,35,18,32 };
            a22.value.valueList = new List<int> { 0,19,10,19,19,23,19 };
            a23.value.valueList = new List<int> { 0,15,24,28,17,25 };
            a24.value.valueList = new List<int> { 0,30,8,8,10 };
            a25.value.valueList = new List<int> { 0,18,16,18 };
            a26.value.valueList = new List<int> { 0,22,33 };
            a27.value.valueList = new List<int> { 0,19 };
            a28.value.valueList = new List<int> { 0 };

            listA.Add(a1);
            listA.Add(a2);
            listA.Add(a3);
            listA.Add(a4);
            listA.Add(a5);
            listA.Add(a6);
            listA.Add(a7);
            listA.Add(a8);
            listA.Add(a9);
            listA.Add(a10);
            listA.Add(a11);
            listA.Add(a12);
            listA.Add(a13);
            listA.Add(a14);
            listA.Add(a15);
            listA.Add(a16);
            listA.Add(a17);
            listA.Add(a18);
            listA.Add(a19);
            listA.Add(a20);
            listA.Add(a21);
            listA.Add(a22);
            listA.Add(a23);
            listA.Add(a24);
            listA.Add(a25);
            listA.Add(a26);
            listA.Add(a27);
            listA.Add(a28);
        }

        public void SourceC()
        {
            a1 = new SubData("特别周", 1);
            a2 = new SubData("无声铃鹿", 2);
            a3 = new SubData("东海帝王", 3);
            a4 = new SubData("丸善斯基", 4);
            a5 = new SubData("小栗帽", 5);
            a6 = new SubData("黄金船", 6);
            a7 = new SubData("伏特加", 7);
            a8 = new SubData("大和赤骥", 8);
            a9 = new SubData("大树快车", 9);
            a10 = new SubData("草上飞", 10);
            a11 = new SubData("目白麦昆", 11);
            a12 = new SubData("神鹰", 12);
            a13 = new SubData("好歌剧", 13);
            a14 = new SubData("象征鲁道夫(皇帝)", 14);
            a15 = new SubData("气槽", 15);
            a16 = new SubData("琵琶晨光", 16);
            a17 = new SubData("重炮", 17);
            a18 = new SubData("美浦波旁", 18);
            a19 = new SubData("目白赖恩", 19);
            a20 = new SubData("米浴", 20);
            a21 = new SubData("爱丽速子", 21);
            a22 = new SubData("胜利奖券", 22);
            a23 = new SubData("真机伶", 23);
            a24 = new SubData("樱花暴进王", 24);
            a25 = new SubData("超级小海湾", 25);
            a26 = new SubData("醒目飞鹰", 26);
            a27 = new SubData("成田大进", 27);
            a28 = new SubData("春麗", 28);
            a29 = new SubData("待兼福来", 29);
            a30 = new SubData("优秀素质", 30);
            a31 = new SubData("帝王光环", 31);

            a1.value.valueList = new List<int> { 00,23,20,11,25,26,26,17,09,31,27,25,31,26,18,25,26,18,24,23,25,27,10,09,29,10,17,07,28,35,24 };
               a2.value.valueList = new List<int> { 00,18,17,18,19,16,17,14,18,20,17,19,16,18,18,26,26,18,17,20,18,10,13,20,17,17,03,27,19,11 };
                  a3.value.valueList = new List<int> { 00,09,18,20,24,30,17,17,31,24,27,28,26,25,20,20,17,25,21,19,18,17,24,12,19,03,17,21,13 };
                     a4.value.valueList = new List<int> { 00,18,09,15,17,24,17,08,17,08,11,09,09,15,30,08,10,10,10,14,16,11,16,09,07,10,08,16 };
                        a5.value.valueList = new List<int> { 00,20,31,24,18,30,18,23,20,19,16,18,20,24,25,16,24,26,10,09,26,17,17,03,25,26,17 };
                           a6.value.valueList = new List<int> { 00,16,18,09,17,31,17,29,28,19,31,30,18,19,25,18,22,09,09,28,13,27,11,19,26,11 };
                              a7.value.valueList = new List<int> { 00,34,16,29,21,23,18,17,20,16,16,25,22,15,25,24,12,08,17,18,16,03,23,24,18 };
                                 a8.value.valueList = new List<int> { 00,22,23,28,30,24,24,27,24,17,23,14,22,17,17,19,15,25,17,16,04,17,16,11 };
                                    a9.value.valueList = new List<int> { 00,19,16,27,17,20,16,16,09,24,11,21,11,09,23,29,16,08,08,07,15,09,17 };
                                      a10.value.valueList = new List<int> { 00,16,35,19,19,16,16,18,23,25,18,23,22,07,10,15,15,15,03,23,24,23 };
                                         a11.value.valueList = new List<int> { 00,22,33,31,25,35,28,18,22,33,19,19,18,18,34,12,18,04,19,27,14 };
                                            a12.value.valueList = new List<int> { 00,26,27,23,23,16,22,17,26,16,16,14,17,23,16,15,02,16,17,15 };
                                               a13.value.valueList = new List<int> { 00,35,24,36,29,18,16,32,19,18,16,16,33,10,19,05,17,26,12 };
                                                  a14.value.valueList = new List<int> { 00,25,33,26,17,17,36,18,18,14,17,33,09,17,01,16,22,10 };
                                                     a15.value.valueList = new List<int> { 00,25,16,17,17,22,18,19,17,17,25,13,18,03,17,17,12 };
                                                        a16.value.valueList = new List<int> { 00,28,17,18,32,17,26,16,16,34,13,25,02,18,24,10 };
                                                           a17.value.valueList = new List<int> { 00,24,17,25,17,20,09,09,27,17,17,03,19,25,10 };
                                                              a18.value.valueList = new List<int> { 00,16,18,21,18,16,19,17,25,18,09,19,18,18 };
                                                                 a19.value.valueList = new List<int> { 00,19,24,25,07,14,16,11,18,01,23,25,16 };
                                                                    a20.value.valueList = new List<int> { 00,18,16,15,21,32,08,15,02,19,24,09 };
                                                                       a21.value.valueList = new List<int> { 00,24,10,11,18,11,18,03,27,26,19 };
                                                                          a22.value.valueList = new List<int> { 00,09,10,19,13,25,03,25,25,17 };
                                                                             a23.value.valueList = new List<int> { 00,23,16,02,10,10,09,09,17 };
                                                                                a24.value.valueList = new List<int> { 00,17,02,08,10,13,12,16 };
                                                                                   a25.value.valueList = new List<int> { 00,11,20,03,21,25,10 };
                                                                                      a26.value.valueList = new List<int> { 00,12,10,10,11,05 };
                                                                                         a27.value.valueList = new List<int> { 00,10,17,18,11 };
                                                                                            a28.value.valueList = new List<int> { 00,03,05,13 };
                                                                                               a29.value.valueList = new List<int> { 00,25,18 };
                                                                                                  a30.value.valueList = new List<int> { 00,20 };
                                                                                                     a31.value.valueList = new List<int> { 00 };


            listA.Add(a1);
            listA.Add(a2);
            listA.Add(a3);
            listA.Add(a4);
            listA.Add(a5);
            listA.Add(a6);
            listA.Add(a7);
            listA.Add(a8);
            listA.Add(a9);
            listA.Add(a10);
            listA.Add(a11);
            listA.Add(a12);
            listA.Add(a13);
            listA.Add(a14);
            listA.Add(a15);
            listA.Add(a16);
            listA.Add(a17);
            listA.Add(a18);
            listA.Add(a19);
            listA.Add(a20);
            listA.Add(a21);
            listA.Add(a22);
            listA.Add(a23);
            listA.Add(a24);
            listA.Add(a25);
            listA.Add(a26);
            listA.Add(a27);
            listA.Add(a28);
            listA.Add(a29);
            listA.Add(a30);
            listA.Add(a31);
        }
    }
}

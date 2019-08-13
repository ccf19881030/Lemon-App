﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LemonLibrary
{
    class MainClass
    {
        /// <summary>
        /// API调试台
        /// </summary>
        static async System.Threading.Tasks.Task Main() {
            Settings.LoadUSettings("2728578956");
            string id = "k00242mjco0";
            var d = await MusicLib.GetRadioMusicAsync("99");
            Console.WriteLine(d[0].MusicName);
            Console.ReadLine();
        }

        #region #DEBUG 评论获取/点赞测试:
        /*
            Settings.LoadUSettings("2728578956");
            MusicLib ml = new MusicLib();
            List<InfoHelper.MusicPL> a = ml.GetPLByQQAsync("003FuStf1pEQxm").GetAwaiter().GetResult();
            int i = 0;
            foreach (var b in a)
            {
                Console.WriteLine($"[{i}]  {b.text}  Like:{b.like}");
                i++;
            }
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(MusicLib.PraiseMusicPLAsync("003FuStf1pEQxm", a[index]).GetAwaiter().GetResult());
            Console.ReadLine();
        */
        #endregion
    }
}

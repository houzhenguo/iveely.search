﻿/*==========================================
 *创建人：刘凡平
 *邮  箱：liufanping@iveely.com
 *世界上最快乐的事情，莫过于为理想而奋斗！
 *版  本：0.1.0
 *Iveely=I void everything,except love you!
 *========================================*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Iveely.CloudComputing.Client;
using Iveely.Framework.Algorithm.AI;
using Iveely.Framework.Algorithm.AI.Library;
using Iveely.Framework.DataStructure;
using Iveely.Framework.Network;
using Iveely.Framework.Network.Synchronous;
using Iveely.Framework.NLP;
using Iveely.Framework.Text;
using Iveely.Framework.Text.Segment;
using System.Collections;

namespace Iveely.SearchEngine
{
    public partial class Host : Application
    {
        private Library library = new Library();

        public class Temp
        {
            public string Name;

            public override int GetHashCode()
            {
                Name = "123";
                int val = Name.GetHashCode();
                return val;
            }
        }

        public static void Main(string[] args)
        {
            MetastasisSegment segment = new MetastasisSegment();
            while (true)
            {
                Console.Write("==>");
                string data = Console.ReadLine();
                Console.WriteLine(segment.SplitWithSemantic(data, "/"));

            }

            //if (args.Length > 0)
            //{
            //    Host host = new Host();
            //    host.Run(null);
            //}
            //else
            //{
            //    Backstage backstage = new Backstage();
            //    backstage.Run(new object[] { 8001, 8001, 8001, 8001, 8001, 8001 });
            //}
            Console.ReadKey();
        }

        public override void Run(object[] args)
        {
            DicSplit.GetInstance();
            //while (true)
            //{
            //    Console.Write("Text Query Words:");
            //    string query = Console.ReadLine();
            //    Console.WriteLine(library.TextQuery(query));

            //    Console.Write("Relative Query Word:");
            //    query = Console.ReadLine();
            //    Console.WriteLine(library.RelativeQuery(query));
            //}
        }
    }
}

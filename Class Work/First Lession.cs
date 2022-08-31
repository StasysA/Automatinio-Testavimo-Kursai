using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work
{
    internal class First_Lession
    {
        private static object currentTime;

        // 4 yra lyginis skaicius
        // dabar yra 19 valanda

        [Test]
        public static void Testif4iseven()
        {
            int leftover = 4 % 2;
            //Assert.AreEqual(0, leftover, "4 is not even");
            Assert.IsTrue(leftover.Equals(0), "4 isn ot even");
        }

        [Test]

        public static void TestNowIs19()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(19, currentTime.Hour, "Now is not 19");

        }
        //Testas 1 --> “žalias” jeigu 995 dalijasi iš 3 (be liekanos)
        //Testas 2 --> “žalias” jeigu šiandien penktadienis(DayOfWeek.Friday)
        //Testas 3 --> “žalias” po to kai “palaukia” 5 sekundes

        [Test]

        public static void Test995DivideBy3()
        {
            double leftover = 995 % 3;
            Assert.AreEqual(0, leftover.Equals(0), "Divides by 3");
        }

        [Test]

        public static void TestNowIsFriday()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Friday, currentTime.DayOfWeek, "Today is Fraiday");
        }

        [Test]

        public static void TestWait5Seconds()
        {
            System.Threading.Thread.Sleep(5000);
        }
    }
}

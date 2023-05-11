using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace PasswordGenerator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingRefresh1()
        {
            Form1 form = new Form1();
            string actual = form.GeneratePassword(true, true, true, true, 16);
            bool really = true;
            int smallAZ = 0;
            int AZ = 0;
            int zeroNine = 0;
            int privateSymbol = 0;
            for(int i = 0; i < 16; i++)
            {
                if(smallAZ == 0)
                {
                    string smallAZ1 = "abcdefghijklmnopqrstuvwxyz";
                    for (int j = 0; j < smallAZ1.Length; j++)
                    {
                        if (actual[i] == smallAZ1[j]) smallAZ = 1;
                    }
                }
                if(AZ == 0)
                {
                    string AZ1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    for (int j = 0; j < AZ1.Length; j++)
                    {
                        if (actual[i] == AZ1[j]) AZ = 1;
                    }
                }
                if (zeroNine == 0)
                {
                    string zeroNine1 = "0123456789";
                    for (int j = 0; j < zeroNine1.Length; j++)
                    {
                        if (actual[i] == zeroNine1[j]) zeroNine = 1;
                    }
                }
                if (privateSymbol == 0)
                {
                    string privateSymbol1 = "~!@#$%^&*+-/.,\\{}[]();:?";
                    for (int j = 0; j < privateSymbol1.Length; j++)
                    {
                        if (actual[i] == privateSymbol1[j]) privateSymbol = 1;
                    }
                }
            }
            if (privateSymbol == 0 || zeroNine == 0 || AZ == 0 || smallAZ == 0) really = false;
            Assert.AreEqual(true, really);
        }
        [TestMethod]
        public void TestingRefresh2()
        {
            Form1 form = new Form1();
            string actual = form.GeneratePassword(true, true, true, false, 16);
            bool really = true;
            int smallAZ = 0;
            int AZ = 0;
            int zeroNine = 0;
            int privateSymbol = 0;
            for (int i = 0; i < 16; i++)
            {
                if (smallAZ == 0)
                {
                    string smallAZ1 = "abcdefghijklmnopqrstuvwxyz";
                    for (int j = 0; j < smallAZ1.Length; j++)
                    {
                        if (actual[i] == smallAZ1[j]) smallAZ = 1;
                    }
                }
                if (AZ == 0)
                {
                    string AZ1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    for (int j = 0; j < AZ1.Length; j++)
                    {
                        if (actual[i] == AZ1[j]) AZ = 1;
                    }
                }
                if (zeroNine == 0)
                {
                    string zeroNine1 = "0123456789";
                    for (int j = 0; j < zeroNine1.Length; j++)
                    {
                        if (actual[i] == zeroNine1[j]) zeroNine = 1;
                    }
                }
                if (privateSymbol == 0)
                {
                    string privateSymbol1 = "~!@#$%^&*+-/.,\\{}[]();:?";
                    for (int j = 0; j < privateSymbol1.Length; j++)
                    {
                        if (actual[i] == privateSymbol1[j]) privateSymbol = 1;
                    }
                }
            }
            if (privateSymbol == 1 || zeroNine == 0 || AZ == 0 || smallAZ == 0) really = false;
            Assert.AreEqual(true, really);
        }
        [TestMethod]
        public void TestingRefresh3()
        {
            Form1 form = new Form1();
            string actual = form.GeneratePassword(true, true, false, false, 16);
            bool really = true;
            int smallAZ = 0;
            int AZ = 0;
            int zeroNine = 0;
            int privateSymbol = 0;
            for (int i = 0; i < 16; i++)
            {
                if (smallAZ == 0)
                {
                    string smallAZ1 = "abcdefghijklmnopqrstuvwxyz";
                    for (int j = 0; j < smallAZ1.Length; j++)
                    {
                        if (actual[i] == smallAZ1[j]) smallAZ = 1;
                    }
                }
                if (AZ == 0)
                {
                    string AZ1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    for (int j = 0; j < AZ1.Length; j++)
                    {
                        if (actual[i] == AZ1[j]) AZ = 1;
                    }
                }
                if (zeroNine == 0)
                {
                    string zeroNine1 = "0123456789";
                    for (int j = 0; j < zeroNine1.Length; j++)
                    {
                        if (actual[i] == zeroNine1[j]) zeroNine = 1;
                    }
                }
                if (privateSymbol == 0)
                {
                    string privateSymbol1 = "~!@#$%^&*+-/.,\\{}[]();:?";
                    for (int j = 0; j < privateSymbol1.Length; j++)
                    {
                        if (actual[i] == privateSymbol1[j]) privateSymbol = 1;
                    }
                }
            }
            if (privateSymbol == 1 || zeroNine == 0 || AZ == 0 || smallAZ == 1) really = false;
            Assert.AreEqual(true, really);
        }
        [TestMethod]
        public void TestingRefresh4()
        {
            Form1 form = new Form1();
            string actual = form.GeneratePassword(true, false, false, false, 16);
            bool really = true;
            int smallAZ = 0;
            int AZ = 0;
            int zeroNine = 0;
            int privateSymbol = 0;
            for (int i = 0; i < 16; i++)
            {
                if (smallAZ == 0)
                {
                    string smallAZ1 = "abcdefghijklmnopqrstuvwxyz";
                    for (int j = 0; j < smallAZ1.Length; j++)
                    {
                        if (actual[i] == smallAZ1[j]) smallAZ = 1;
                    }
                }
                if (AZ == 0)
                {
                    string AZ1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    for (int j = 0; j < AZ1.Length; j++)
                    {
                        if (actual[i] == AZ1[j]) AZ = 1;
                    }
                }
                if (zeroNine == 0)
                {
                    string zeroNine1 = "0123456789";
                    for (int j = 0; j < zeroNine1.Length; j++)
                    {
                        if (actual[i] == zeroNine1[j]) zeroNine = 1;
                    }
                }
                if (privateSymbol == 0)
                {
                    string privateSymbol1 = "~!@#$%^&*+-/.,\\{}[]();:?";
                    for (int j = 0; j < privateSymbol1.Length; j++)
                    {
                        if (actual[i] == privateSymbol1[j]) privateSymbol = 1;
                    }
                }
            }
            if (privateSymbol == 1 || zeroNine == 0 || AZ == 1 || smallAZ == 1) really = false;
            Assert.AreEqual(true, really);
        }
        [TestMethod]
        public void TestingRefresh5()
        {
            Form1 form = new Form1();
            string actual = form.GeneratePassword(false, false, false, true, 16);
            bool really = true;
            int smallAZ = 0;
            int AZ = 0;
            int zeroNine = 0;
            int privateSymbol = 0;
            for (int i = 0; i < 16; i++)
            {
                if (smallAZ == 0)
                {
                    string smallAZ1 = "abcdefghijklmnopqrstuvwxyz";
                    for (int j = 0; j < smallAZ1.Length; j++)
                    {
                        if (actual[i] == smallAZ1[j]) smallAZ = 1;
                    }
                }
                if (AZ == 0)
                {
                    string AZ1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    for (int j = 0; j < AZ1.Length; j++)
                    {
                        if (actual[i] == AZ1[j]) AZ = 1;
                    }
                }
                if (zeroNine == 0)
                {
                    string zeroNine1 = "0123456789";
                    for (int j = 0; j < zeroNine1.Length; j++)
                    {
                        if (actual[i] == zeroNine1[j]) zeroNine = 1;
                    }
                }
                if (privateSymbol == 0)
                {
                    string privateSymbol1 = "~!@#$%^&*+-/.,\\{}[]();:?";
                    for (int j = 0; j < privateSymbol1.Length; j++)
                    {
                        if (actual[i] == privateSymbol1[j]) privateSymbol = 1;
                    }
                }
            }
            if (privateSymbol == 0 || zeroNine == 1 || AZ == 1 || smallAZ == 1) really = false;
            Assert.AreEqual(true, really);
        }
        [TestMethod]
        public void TestingRefresh6()
        {
            Form1 form = new Form1();
            string actual = form.GeneratePassword(false, true, true, true, 16);
            bool really = true;
            int smallAZ = 0;
            int AZ = 0;
            int zeroNine = 0;
            int privateSymbol = 0;
            for (int i = 0; i < 16; i++)
            {
                if (smallAZ == 0)
                {
                    string smallAZ1 = "abcdefghijklmnopqrstuvwxyz";
                    for (int j = 0; j < smallAZ1.Length; j++)
                    {
                        if (actual[i] == smallAZ1[j]) smallAZ = 1;
                    }
                }
                if (AZ == 0)
                {
                    string AZ1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    for (int j = 0; j < AZ1.Length; j++)
                    {
                        if (actual[i] == AZ1[j]) AZ = 1;
                    }
                }
                if (zeroNine == 0)
                {
                    string zeroNine1 = "0123456789";
                    for (int j = 0; j < zeroNine1.Length; j++)
                    {
                        if (actual[i] == zeroNine1[j]) zeroNine = 1;
                    }
                }
                if (privateSymbol == 0)
                {
                    string privateSymbol1 = "~!@#$%^&*+-/.,\\{}[]();:?";
                    for (int j = 0; j < privateSymbol1.Length; j++)
                    {
                        if (actual[i] == privateSymbol1[j]) privateSymbol = 1;
                    }
                }
            }
            if (privateSymbol == 0 || zeroNine == 1 || AZ == 0 || smallAZ == 0) really = false;
            Assert.AreEqual(true, really);
        }
        [TestMethod]
        public void TestingRefresh7()
        {
            Form1 form = new Form1();
            string actual = form.GeneratePassword(true, true, true, true, 16);
            bool really = true;
            if(actual.Length != 16) really = false;
            Assert.AreEqual(true, really);
        }
        [TestMethod]
        public void TestingRefresh8()
        {
            Form1 form = new Form1();
            string actual = form.GeneratePassword(true, true, true, true, 10);
            bool really = true;
            if (actual.Length != 10) really = false;
            Assert.AreEqual(true, really);
        }
        [TestMethod]
        public void TestingRefresh9()
        {
            Form1 form = new Form1();
            string actual = form.GeneratePassword(true, true, true, true, 4);
            bool really = true;
            if (actual.Length != 4) really = false;
            Assert.AreEqual(true, really);
        }
        [TestMethod]
        public void TestingRefresh10()
        {
            Form1 form = new Form1();
            string actual = form.ReliabilityPassword(true, true, true, true, 16);
            Assert.AreEqual("надежный", actual);
        }
        [TestMethod]
        public void TestingRefresh11()
        {
            Form1 form = new Form1();
            string actual = form.ReliabilityPassword(true, true, false, true, 13);
            Assert.AreEqual("слабый", actual);
        }
        [TestMethod]
        public void TestingRefresh12()
        {
            Form1 form = new Form1();
            string actual = form.ReliabilityPassword(true, false, true, false, 16);
            Assert.AreEqual("надежный", actual);
        }
        [TestMethod]
        public void TestingRefresh13()
        {
            Form1 form = new Form1();
            string actual = form.ReliabilityPassword(true, false, true, false, 4);
            Assert.AreEqual("слабый", actual);
        }
        [TestMethod]
        public void TestingRefresh14()
        {
            Form1 form = new Form1();
            string actual = form.ReliabilityPassword(true, false, true, false, 11);
            Assert.AreEqual("слабый", actual);
        }
        [TestMethod]
        public void TestingRefresh15()
        {
            Form1 form = new Form1();
            string actual = form.ReliabilityPassword(true, true, true, true, 12);
            Assert.AreEqual("средний", actual);
        }
    }
}

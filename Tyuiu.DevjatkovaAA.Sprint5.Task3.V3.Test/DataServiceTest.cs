using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint5.Task3.V3.Lib;
using System.IO;

namespace Tyuiu.DevjatkovaAA.Sprint5.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\ДНС\source\repos\Tyuiu.DevjatkovaAA.Sprint5\Tyuiu.DevjatkovaAA.Sprint5.Task3.V3\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}

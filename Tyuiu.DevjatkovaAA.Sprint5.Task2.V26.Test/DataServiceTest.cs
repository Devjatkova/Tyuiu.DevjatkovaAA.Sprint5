using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint5.Task2.V26.Lib;
using System.IO;

namespace Tyuiu.DevjatkovaAA.Sprint5.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\ДНС\source\repos\Tyuiu.DevjatkovaAA.Sprint5\Tyuiu.DevjatkovaAA.Sprint5.Task2.V26\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}

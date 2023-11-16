using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint5.Task0.V25.Lib;
using System.IO;

namespace Tyuiu.DevjatkovaAA.Sprint5.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\ДНС\source\repos\Tyuiu.DevjatkovaAA.Sprint5\Tyuiu.DevjatkovaAA.Sprint5.Task0.V25\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}

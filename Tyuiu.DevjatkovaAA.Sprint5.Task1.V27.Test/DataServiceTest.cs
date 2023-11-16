using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint5.Task1.V27.Lib;
using System.IO;

namespace Tyuiu.DevjatkovaAA.Sprint5.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\ДНС\source\repos\Tyuiu.DevjatkovaAA.Sprint5\Tyuiu.DevjatkovaAA.Sprint5.Task1.V27\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}

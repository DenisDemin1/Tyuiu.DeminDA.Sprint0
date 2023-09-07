using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DeminDA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DeminDA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Денис";
            var res = DataService.GetMessage(name);
            //Вызывается класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Денис", res);
        }
    }
}

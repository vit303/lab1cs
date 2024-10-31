using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab1;

namespace UnitTestLab1
{
    [TestClass]
    public class CompEquipmentTests
    {
        private CompEquipment _compEquipment;

        [TestInitialize]
        public void Setup()
        {
            _compEquipment = new CompEquipment();
        }

        [TestMethod]
        public void DefaultConstructor_ShouldInitializeWithDefaultValues()
        {
            Assert.AreEqual("Неизвестный", _compEquipment.GetBrand());
            Assert.AreEqual("Неизвестный", _compEquipment.GetCpuBrand());
            Assert.AreEqual(0, _compEquipment.GetRam());
            Assert.AreEqual(0, _compEquipment.GetPrice());
        }

        [TestMethod]
        public void ParameterizedConstructor_ShouldInitializeWithGivenValues()
        {
            var compEquipment = new CompEquipment("Dell", "Intel", 16, 1200);

            Assert.AreEqual("Dell", compEquipment.GetBrand());
            Assert.AreEqual("Intel", compEquipment.GetCpuBrand());
            Assert.AreEqual(16, compEquipment.GetRam());
            Assert.AreEqual(1200, compEquipment.GetPrice());
        }

        [TestMethod]
        public void SetBrand_ShouldUpdateBrand()
        {
            _compEquipment.SetBrand("HP");
            Assert.AreEqual("HP", _compEquipment.GetBrand());
        }

        [TestMethod]
        public void SetCpuBrand_ShouldUpdateCpuBrand()
        {
            _compEquipment.SetCpuBrand("AMD");
            Assert.AreEqual("AMD", _compEquipment.GetCpuBrand());
        }

        [TestMethod]
        public void SetRam_ShouldUpdateRam()
        {
            _compEquipment.SetRam(32);
            Assert.AreEqual(32, _compEquipment.GetRam());
        }

        [TestMethod]
        public void SetPrice_ShouldUpdatePrice()
        {
            _compEquipment.SetPrice(1500);
            Assert.AreEqual(1500, _compEquipment.GetPrice());
        }
    }
}

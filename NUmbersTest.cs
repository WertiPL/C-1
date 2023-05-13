using NUnit.Framework;
using System;
using RPNCalulator;
using RPNCalulator.Numbers;

namespace NumTest
{
    [TestFixture]
    public class NumTest
    {
        private Bin _sut;
        private Hex _hex;
        private Dec _dec;


        [SetUp]
        public void Setup()
        {
            _sut = new Bin();
        }
        [SetUp]
        public void SetupHex()
        {
            _hex = new Hex();
        }
        [SetUp]
        public void SetupDec()
        {
            _dec = new Dec();
        }
        [Test]
        public void CheckIfTestWorks()
        {
            Assert.Pass();
        }

        [Test]
        public void CheckIfCanCreateSut()
        {
            Assert.That(_sut, Is.Not.Null);
        }
        [Test]
        public void CheckIsItHex()
        {
            var result = _hex.isItHex("#12345");

            Assert.That(result, Is.EqualTo(true));

        }
        [Test]
        public void CheckIsItDec()
        {
            var result = _dec.isItDec("100");

            Assert.That(result, Is.EqualTo(true));

        }
        [Test]
        public void CheckIsItBin()
        {
            
            var result = _sut.TryNum("101b", out var r);

            Assert.That(r, Is.EqualTo(5));

        }
    }
}
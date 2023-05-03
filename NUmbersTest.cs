using NUnit.Framework;
using System;
using RPNCalulator;
using RPNCalulator.Numbers;

namespace NumTest
{
    [TestFixture]
    public class NumTest
    {
        private Binary _sut;
        private Hex _hex;


        [SetUp]
        public void Setup()
        {
            _sut = new Binary();
        }
        [SetUp]
        public void SetupHex()
        {
            _hex = new Hex();
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
        public void CheckIsItBin()
        {
            var result = _sut.isItbin("1101b");

            Assert.That(result, Is.EqualTo(true));

        }
        [Test]
        public void CheckIsItHex()
        {
            var result = _hex.isItHex("#12345");

            Assert.That(result, Is.EqualTo(true));

        }
        [Test]
        public void ChangeBintoDec()
        {
            var result = _sut.BintoDec("101b");

            Assert.That(result, Is.EqualTo(5));

        }
        [Test]
        public void ChangeHextoDec()
        {
            var result = _hex.hextoDec("#10");

            Assert.That(result, Is.EqualTo(16));

        }
        [Test]
        public void ChangeBintoDec2()
        {
            var result = _sut.BintoDec("100b");

            Assert.That(result, Is.EqualTo(4));

        }


    }
}
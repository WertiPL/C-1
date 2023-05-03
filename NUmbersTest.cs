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



        [SetUp]
        public void Setup()
        {
            _sut = new Binary();
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
        public void ChangeBintoDec()
        {
            var result = _sut.BintoDec("101b");

            Assert.That(result, Is.EqualTo(5));

        }
        [Test]
        public void ChangeBintoDec2()
        {
            var result = _sut.BintoDec("100b");

            Assert.That(result, Is.EqualTo(4));

        }
    }
}
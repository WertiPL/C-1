using NUnit.Framework;
using System;
using RPNCalulator;

namespace RPNTest
{
    [TestFixture]
    public class RPNTest : RPN
    {
        private RPN _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new RPN();
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
        public void TwoNumbersGivenWithoutOperator_ThrowsExcepton()
        {
            Assert.Throws<InvalidOperationException>(() => _sut.EvalRPN("1 2"));
        }

        [Test]
        public void OperatorPlus_AddingTwoNumbers_ReturnCorrectResult()
        {
            var result = _sut.EvalRPN("1 2 +");

            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void OperatorTimes_AddingTwoNumbers_ReturnCorrectResult()
        {
            var result = _sut.EvalRPN("2 2 *");

            Assert.That(result, Is.EqualTo(4));
        }
        [Test]
        public void OperatorMinus_SubstractingTwoNumbers_ReturnCorrectResult()
        {
            var result = _sut.EvalRPN("2 1 -");

            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void ComplexExpression()
        {
            var result = _sut.EvalRPN("15 7 1 1 + - / 3 * 2 1 1 + + -");

            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void Operatordivision_SubstractingTwoNumbers_ReturnCorrectResult()
        {
            var result = _sut.EvalRPN("4 2 /");

            Assert.That(result, Is.EqualTo(2));
        }
             [Test]
              public void decFactrial()
              {
                  var result = _sut.EvalRPN("4 !");

                  Assert.That(result, Is.EqualTo(24));
              }
        [Test]
        public void BinaryFactrial()
        {
            var result = _sut.EvalRPN("100b !");

            Assert.That(result, Is.EqualTo(24));
        }
        [Test]
        public void BinaryModulo()
        {
            var result = _sut.EvalRPN("110b 100b %");

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void hexsMultiplybin()
        {
            var result = _sut.EvalRPN("110b #140 *");

            Assert.That(result, Is.EqualTo(1920));

        }
    }
}
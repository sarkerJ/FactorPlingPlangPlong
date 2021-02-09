using NUnit.Framework;

namespace Factors
{
    public class PlingPlangPlongTests
    {

        [TestCase(34, "34")]
        [TestCase(1, "1")]
        [TestCase(-1, "-1")]
        public void Given_AValueOf_WithNoneOfTheSpecifiedFactors_Returns_TheValueAsAString(int value, string expected)
        {
            var result = PlingPlangPlong.GetFactorResult(value);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(3, "Pling")]
        [TestCase(-3, "Pling")]
        public void GivenAValueWithA_FactorOf3_AndNotOf5And7_Returns_Pling(int value, string expected)
        {
            var result = PlingPlangPlong.GetFactorResult(value);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(5, "Plang")]
        [TestCase(-5, "Plang")]
        public void GivenAValueWithA_FactorOf5_AndNotOf3And7_Returns_Plang(int value, string expected)
        {
            var result = PlingPlangPlong.GetFactorResult(value);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(7, "Plong")]
        [TestCase(28, "Plong")]
        [TestCase(-28, "Plong")]
        public void GivenAValueWithA_FactorOf7_AndNotOf3And5_Returns_Plong(int value, string expected)
        {
            var result = PlingPlangPlong.GetFactorResult(value);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(30, "PlingPlang")]
        [TestCase(-30, "PlingPlang")]
        [TestCase(15, "PlingPlang")]
        public void GivenAValueWithA_FactorOf3AND5_BUTNotOf7_Returns_PlingPlang(int value, string expected)
        {
            var result = PlingPlangPlong.GetFactorResult(value);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(35, "PlangPlong")]
        [TestCase(-35, "PlangPlong")]
        public void GivenAValueWithA_FactorOf5AND7_ButNotOf3_Returns_PlangPlong(int value, string expected)
        {
            var result = PlingPlangPlong.GetFactorResult(value);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(21, "PlingPlong")]
        public void GivenAValueWithA_FactorOf3AND7_ButNotOf5_Returns_PlingPlong(int value, string expected)
        {
            var result = PlingPlangPlong.GetFactorResult(value);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0, "PlingPlangPlong")]
        [TestCase(105, "PlingPlangPlong")]
        [TestCase(-105, "PlingPlangPlong")]

        public void GivenAValueWithA_FactorOf3AND5_AND7_Returns_PlingPlangPlong(int value, string expected)
        {
            var result = PlingPlangPlong.GetFactorResult(value);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
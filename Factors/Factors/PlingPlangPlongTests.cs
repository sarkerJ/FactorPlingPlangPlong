using NUnit.Framework;

namespace Factors
{
    public class PlingPlangPlongTests
    {
        
        [TestCase(34, "34")]
        [TestCase(1, "1")]
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
        public void GivenAValueWithA_FactorOf5_AndNotOf3And7_Returns_Plang(int value, string expected)
        {
            var result = PlingPlangPlong.GetFactorResult(value);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(7, "Plong")]
        public void GivenAValueWithA_FactorOf7_AndNotOf3And5_Returns_Plong(int value, string expected)
        {
            var result = PlingPlangPlong.GetFactorResult(value);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
using NUnit.Framework;

namespace Factors
{
    public class PlingPlangPlongTests
    {
        
        [TestCase(34, "34")]
        public void Given_AValueOf_WithNoneOfTheSpecifiedFactors_Returns_TheValueAsAString(int value, string expected)
        {
            var result = PlingPlangPlong.GetFactorResult(value);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
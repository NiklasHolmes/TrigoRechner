using System;
using TechTalk.SpecFlow;
using Xunit;

namespace TrigoRechner
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double number, result;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(double p0)
        {
            //number = p0;
            if (p0 == 3.1415)
            {
                number = Math.PI;
            }
            else
                number = p0;
        }
        
        [When(@"the sinus is calculated")]
        public void WhenTheSinusIsCalculated()
        {
            result = Math.Sin(number);
        }
        
        [When(@"the cosinus is calculated")]
        public void WhenTheCosinusIsCalculated()
        {
            result = Math.Cos(number);
        }
        
        [When(@"the tangens is calculated")]
        public void WhenTheTangensIsCalculated()
        {
            result = Math.Tan(number);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            //  für bessere Lesbarkeit: 
            var expected = p0;
            var actual = result;
            Assert.Equal(expected, actual, 5);
        }
    }
}

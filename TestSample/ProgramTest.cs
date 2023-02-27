
namespace TestSample
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        [TestCategory("Unit")]
        [DataRow(new object[] { new char[] { 'a', 'b', 'd', 'b', 'a' }, 'b' })]
        [DataRow(new object[] { new char[] { 'a', 'a' }, 'a' })]
        [DataRow(new object[] { new char[] { 'a', 'b', 'c', 'd', 'd' }, 'd' })]
        public void FindFirstRepeatingCharacter_Should_Return_Expected_Characters(object[] testInputDataWithResult)
        {
            var charArray = testInputDataWithResult[0];
            var expectedResult = testInputDataWithResult[1];
            
            var firstRepeatingCharacter = ArrayMethods.FindFirstRepeatingCharacter((char[])charArray);
            
            Assert.AreEqual(expectedResult, firstRepeatingCharacter.result);
            Assert.AreEqual(expectedResult, firstRepeatingCharacter.result);
        }

        [TestMethod]
        [TestCategory("Unit")]
        [DataRow(new char[] { 'a', 'b' })]
        [DataRow(new char[] { })]
        public void FindFirstRepeatingCharacter_Should_Not_Return_Results(char[] testInputDataWithResult)
        {
            var firstRepeatingCharacter = ArrayMethods.FindFirstRepeatingCharacter(testInputDataWithResult);
            Assert.IsFalse(firstRepeatingCharacter.hasResult);
        }
    }
}
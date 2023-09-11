using NUnit.Framework;

namespace TestDateFormat
{
    [TestFixture]
    public class DateFormatterTests
    {
        [Test]
        public void TestValidDateFormat()
        {
            string inputDate = "12/09/2023";
            string expectedOutput = "2023-09-12";
            string actualOutput = DateFormatter.ChangeFormat(inputDate);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void TestInvalidDateFormat()
        {
            string inputDate = "2023-09-12"; // Formato incorrecto
            string expectedOutput = "9-12-3--20";
            string actualOutput = DateFormatter.ChangeFormat(inputDate);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void TestBlankDate()
        {
            string inputDate = ""; // Fecha en blanco
            string expectedOutput = ""; // El resultado debería ser el mismo (fecha en blanco)
            string actualOutput = DateFormatter.ChangeFormat(inputDate);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

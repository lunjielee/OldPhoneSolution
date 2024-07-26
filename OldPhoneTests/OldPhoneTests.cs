using OldPhoneNS;
namespace OldPhoneTests
{
    [TestClass]
    public class OldPhonePadTests
    {
        [TestMethod]
        public void Test_Output_E()
        {
            Assert.AreEqual("E", OldPhone.OldPhonePad("33#"));
        }
        [TestMethod]
        public void Test_Output_B()
        {
            Assert.AreEqual("B", OldPhone.OldPhonePad("227 *#"));
        }
        [TestMethod]
        public void Test_Output_HELLO()
        {
            Assert.AreEqual("HELLO", OldPhone.OldPhonePad("4433555 555666#"));
        }
        [TestMethod]
        public void Test_Output_TURING()
        {
            Assert.AreEqual("TURING", OldPhone.OldPhonePad("8 88777444666 * 664#"));
        }
    }
}
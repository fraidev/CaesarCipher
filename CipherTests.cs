using NUnit.Framework;

namespace CaesarCipher
{
    public class CipherTests
    {
        private Cipher _sut;
        
        [SetUp]
        public void SetUp()
        {
            _sut = new Cipher();
        }

        [Test]
        public void CipherMustEncrypt()
        {

            Assert.AreEqual("DEF", _sut.Encrypt("ABC"));
            Assert.AreEqual("ABC", _sut.Encrypt("XYZ"));
        }
        
        [Test]
        public void CipherMustDecrypt()
        {

            Assert.AreEqual("ABC", _sut.Decrypt("DEF"));
            Assert.AreEqual("XYZ", _sut.Decrypt("ABC"));
        }
    }
}
/*@author name: Prabin Siwakoti, 
 *@author email : developer.prabin@gmail.com,
 *@date : 2017-08-31
 * */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class EncryptStringSampleTests
    {
        [TestMethod]
        public void CanEncryptAndDecryptSampleStringCorrectly()
        {
            // Arrange
            var plainText = "I am prabin.";
            var passPhrase = "supersecretpassword";

            // Act
            var cipherText = PrabinEncryptionTool.EncryptDecrypt.Encrypt(plainText, passPhrase);
            var decryptedText = PrabinEncryptionTool.EncryptDecrypt.Decrypt(cipherText, passPhrase);

            // Assert
            Assert.AreEqual(plainText, decryptedText);
        }

        [TestMethod]
        public void EncryptingTheSamePlainTextWithTheSamePasswordMultipleTimesProducesDifferentCipherText()
        {
            // Arrange
            var plainText = "I am prabin.";
            var passPhrase = "supersecretpassword";

            // Act
            var cipherText1 = PrabinEncryptionTool.EncryptDecrypt.Encrypt(plainText, passPhrase);
            var cipherText2 = PrabinEncryptionTool.EncryptDecrypt.Encrypt(plainText, passPhrase);

            // Assert
            Assert.AreNotEqual(cipherText1, cipherText2);
        }

        [TestMethod]
        public void EncryptingTheSamePlainTextWithTheSamePasswordMultipleTimesProducesDifferentCipherTextButBothCanBeDecryptedCorrectly()
        {
            // Arrange
            var plainText = "This is my sample plain text message";
            var passPhrase = "supersecretpassword";

            // Act
            var cipherText1 = PrabinEncryptionTool.EncryptDecrypt.Encrypt(plainText, passPhrase);
            var cipherText2 = PrabinEncryptionTool.EncryptDecrypt.Encrypt(plainText, passPhrase);
            var decryptedText1 = PrabinEncryptionTool.EncryptDecrypt.Decrypt(cipherText1, passPhrase);
            var decryptedText2 = PrabinEncryptionTool.EncryptDecrypt.Decrypt(cipherText2, passPhrase);

            // Assert
            Assert.AreEqual(decryptedText1, plainText);
            Assert.AreEqual(decryptedText1, decryptedText2);

        }
    }
}

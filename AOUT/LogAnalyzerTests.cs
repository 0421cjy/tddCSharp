using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AOUT.LogAn.Tests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        private LogAnalyzer m_analyzer = null;

        [SetUp]
        public void SetUp()
        {
            m_analyzer = new LogAnalyzer();
        }

        [Test]
        public void IsValidFileName_validFileLowerCased_ReturnTrue()
        {
            bool result = m_analyzer.IsValidLogFileName("whaterver.slf");

            Assert.IsTrue(result, "invalid file Name!");
        }

        [Test]
        public void IsValidFileName_validFileUpperCased_ReturnTrue()
        {
            bool result = m_analyzer.IsValidLogFileName("whaterver.SLF");

            Assert.IsTrue(result, "invalid file Name!");
        }

        [TearDown]
        public void TearDown()
        {
            m_analyzer = null;
        }

        [Test]
        public void IsValidFileName_NameShorterThan6CharsButSupportedExtension_RetunsFalse()
        {
            StubExtensionManager myFakeManager = new StubExtensionManager();
            myFakeManager.ShouldExtensionBeValid = true;

            ExtensionManagerFactory.SetManager(myFakeManager);

            // Analyzer 생성 및 스텁 주입
            LogAnalyzer log = new LogAnalyzer();

            // 확장자 지원 확인 로직에 대한 assert 
            bool result = log.IsValidLogFileName("short.ext");
            Assert.IsFalse(result, "설사 지원하더라도 파일명이 다섯 글자 미만이면 안 됨");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Onj");

        }
    }
}

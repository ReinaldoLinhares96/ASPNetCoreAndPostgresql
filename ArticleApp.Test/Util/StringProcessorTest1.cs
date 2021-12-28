using System;
using ArticleApp.API.Util;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace ArticleApp.Test.Util
{
    [TestClass]
    public class StringProcessorTest1
    {
        [TestMethod]
        public void StringProcessorTesting1(){
            string sentence = "Programando meu primeiro teste unitario";
            string d = StringProcessor.ToUpperCase(sentence);

            foreach (char c in d)
            {
                if (c != ' ')
                {
                    Assert.IsTrue(char.IsUpper(c));   
                }   
            }
        }   
    }   
}
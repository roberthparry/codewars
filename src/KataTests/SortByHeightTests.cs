using Kata;

namespace KataTests
{
    using NUnit.Framework;
    using System;
    
    [TestFixture]
    public class myjinxin
    {
        
        [Test]
        public void BasicTests(){
            var kata=new SortedByHeight();

            Assert.AreEqual(new int[]{-1, 150, 160, 170, -1, -1, 180, 190},kata.SortByHeight(new int[]{-1, 150, 190, 170, -1, -1, 160, 180}));
            
            Assert.AreEqual(new int[]{-1, -1, -1, -1, -1},kata.SortByHeight(new int[]{-1, -1, -1, -1, -1}));
            
            Assert.AreEqual(new int[]{2, 2, 4, 9, 11, 16},kata.SortByHeight(new int[]{4, 2, 9, 11, 2, 16}));
            
                        
        }
                 
    }
}
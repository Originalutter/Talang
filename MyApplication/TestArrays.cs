using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace MyApplication
{
    [TestFixture]
    public class TestArrays
    {
        [Test]
        public void should_be_one_dimensional()
        {
            int[] arr = {1, 2, 3};

            Assert.AreEqual(arr[0], 1);
        }
        [Test]
        public void should_be_two_dimensional()
        {
            int[,] arr = {{1,2},{3,4}};

            Assert.That(arr[0, 0], Is.EqualTo(1));
            Assert.That(arr[0, 1], Is.EqualTo(2));
            Assert.That(arr[1, 0], Is.EqualTo(3));
            Assert.That(arr[1, 1], Is.EqualTo(4));
        }
        [Test]
        public void should_be_three_dimensional()
        {
            int[,,] arr = new int[53, 154, 78];
            arr[52, 153, 77] = 1;
            arr[33, 141, 20] = 2;

            Assert.That(arr[1, 1, 1], Is.EqualTo(0));
            Assert.That(arr[52, 153, 77], Is.EqualTo(1));
            Assert.That(arr[33, 141, 20], Is.EqualTo(2));
        }
        [Test]
        public void should_be_jagged()
        {
            int[][] arr = { new []{1,2}, new [] { 3,4,5} };

            Assert.That(arr[0][0], Is.EqualTo(1));
            Assert.That(arr[0][1], Is.EqualTo(2));
            Assert.That(arr[1][0], Is.EqualTo(3));
            Assert.That(arr[1][1], Is.EqualTo(4));
            Assert.That(arr[1][2], Is.EqualTo(5));
        }                
    }
    
}
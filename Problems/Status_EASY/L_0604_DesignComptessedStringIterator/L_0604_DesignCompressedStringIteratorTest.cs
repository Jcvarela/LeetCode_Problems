using Xunit;

namespace LeetCode_Problems.Problems.Status_EASY.L_0604_DesignCompressedStringIterator
{
    public class L_0604_DesignCompressedStringIteratorTest
    {
        [Fact]
        public void Test1()
        {
            var iterator = new L_0604_DesignCompressedStringIterator("a2b1c5a3");
            Assert.Equal('a', iterator.Next());
            Assert.Equal('a', iterator.Next());
            Assert.Equal('b', iterator.Next());
            Assert.Equal('c', iterator.Next());
            Assert.Equal('c', iterator.Next());
            Assert.Equal('c', iterator.Next());
            Assert.Equal('c', iterator.Next());
            Assert.Equal('c', iterator.Next());
            Assert.Equal('a', iterator.Next());
            Assert.Equal('a', iterator.Next());
            Assert.Equal('a', iterator.Next());
            Assert.Equal(' ', iterator.Next());
        }

        [Fact]
        public void Test2()
        {
            var iterator = new L_0604_DesignCompressedStringIterator("x1y2z3");
            Assert.Equal('x', iterator.Next());
            Assert.Equal('y', iterator.Next());
            Assert.Equal('y', iterator.Next());
            Assert.Equal('z', iterator.Next());
            Assert.Equal('z', iterator.Next());
            Assert.Equal('z', iterator.Next());
            Assert.Equal(' ', iterator.Next());
        }

        [Fact]
        public void Test3()
        {
            var iterator = new L_0604_DesignCompressedStringIterator("a10");
            for (int i = 0; i < 10; i++)
            {
                Assert.Equal('a', iterator.Next());
            }
            Assert.Equal(' ', iterator.Next());
        }

        [Fact]
        public void Test4()
        {
            var iterator = new L_0604_DesignCompressedStringIterator("");
            Assert.Equal(' ', iterator.Next());
        }

        [Fact]
        public void Test5()
        {
            var iterator = new L_0604_DesignCompressedStringIterator("a1b1c1");
            Assert.Equal('a', iterator.Next());
            Assert.Equal('b', iterator.Next());
            Assert.Equal('c', iterator.Next());
            Assert.Equal(' ', iterator.Next());
        }
    }
}
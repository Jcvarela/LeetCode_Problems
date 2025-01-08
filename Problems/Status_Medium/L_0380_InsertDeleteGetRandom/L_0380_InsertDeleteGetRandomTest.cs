using System.Collections.Generic;
using Xunit;

namespace LeetCode.Problems.Status_Medium.L_0380_InsertDeleteGetRandom
{
    public class L_0380_InsertDeleteGetRandomTest
    {
        [Fact]
        public void Insert_Test()
        {
            var randomSet = new L_0380_InsertDeleteGetRandom();
            Assert.True(randomSet.Insert(1));
            Assert.False(randomSet.Insert(1));
            Assert.True(randomSet.Insert(2));
        }

        [Fact]
        public void Remove_Test()
        {
            var randomSet = new L_0380_InsertDeleteGetRandom();
            randomSet.Insert(1);
            randomSet.Insert(2);
            Assert.True(randomSet.Remove(1));
            Assert.False(randomSet.Remove(1));
            Assert.True(randomSet.Remove(2));
        }

        [Fact]
        public void GetRandom_Test()
        {
            var randomSet = new L_0380_InsertDeleteGetRandom();
            randomSet.Insert(1);
            randomSet.Insert(2);
            var randomValue = randomSet.GetRandom();
            Assert.Contains(randomValue, new List<int> { 1, 2 });
        }

        [Fact]
        public void MixedOperations_Test()
        {
            var randomSet = new L_0380_InsertDeleteGetRandom();
            Assert.True(randomSet.Insert(1));
            Assert.True(randomSet.Insert(2));
            Assert.True(randomSet.Remove(1));
            Assert.False(randomSet.Remove(1));
            Assert.True(randomSet.Insert(2));
            Assert.True(randomSet.Insert(3));
            var randomValue = randomSet.GetRandom();
            Assert.Contains(randomValue, new List<int> { 2, 3 });
        }
    }
}
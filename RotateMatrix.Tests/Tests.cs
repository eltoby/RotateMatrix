using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RotateMatrix.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test4x4()
        {
            var matrix = new[]
            {
                new[]   { 5, 1, 9, 11 }
                , new[] { 2, 0, 0, 10 }
                , new[] { 13, 0, 0, 7 }
                , new[] { 15, 14, 12, 16}
            };

            var sut = new Solution();
            sut.Rotate(matrix);

            Assert.AreEqual(0, matrix[1][1]);
            // expected
            // [[15,13,2,5],[14,0,0,1],[12,0,0,9],[16,7,10,11]]
        }
    }
}

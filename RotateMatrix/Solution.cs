using System;

namespace RotateMatrix
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {

            var left = 0;
            var right = matrix.Length - 1;

            while (left < right)
            {
                for (var j = left; j < right; j++)
                    this.Rotate(matrix, left, j, left, right);

                left++;
                right--;
            }
        }

        private void Rotate(int[][] matrix, int i, int j, int left, int right)
        {
            var dist = right - left + 2 * left;

            var i2 = j;
            var j2 = dist - i;

            var i3 = j2;
            var j3 = dist - i2;

            var i4 = j3;
            var j4 = dist - i3;

            var aux = matrix[i][j];
            matrix[i][j] = matrix[i4][j4];
            matrix[i4][j4] = matrix[i3][j3];
            matrix[i3][j3] = matrix[i2][j2];
            matrix[i2][j2] = aux;
        }
    }
}

using System.Data;

namespace LeetCode_Problems.Problems.Status_EASY.L_0118_PascalTriangle
{
    public class L_118_PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>
            {
                new List<int> { 1 }
            };
            if(numRows == 1)
            {
                return result;
            }
            
            int rowPos = 1;
            while(rowPos++ < numRows){
                var newRow = new List<int>(rowPos);

                for(int i = 0; i < rowPos; i++){
                    if(i == 0  || i == rowPos - 1){
                        newRow.Add(1);
                    }
                    else{
                      newRow.Add(result[rowPos -2][i -1] + result[rowPos -2][i]);
                    }
                }
                result.Add(newRow);
            }

            return result;
        }
    }
}
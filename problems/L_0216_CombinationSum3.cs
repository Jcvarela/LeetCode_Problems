public class CombinationSum3_0219{
        public IList<IList<int>> CombinationSum3(int k, int n) {
        if(k*(k+1)/ 2 > n)
            return new List<IList<int>>();

        var result = new List<IList<int>>();
        RecursiveCombinationSum(0, n, 0, k, new List<int>(), result);

        return result; 

    }

    public void RecursiveCombinationSum(int sum, int expectedValue, int pos, int numsToAddLeft, List<int> addedNums, IList<IList<int>> result){
        if(sum > expectedValue || numsToAddLeft < 0){
            return;
        }

        if(sum == expectedValue && numsToAddLeft == 0){
            result.Add([.. addedNums]);
            return;
        }

        int x = (9 - numsToAddLeft)*(9 - numsToAddLeft + 1)/ 2;
        int maxPossibleSum = sum + ( 45 - x);
        if(numsToAddLeft == 0 || maxPossibleSum < expectedValue){
            return;
        }

        for(int i = pos + 1; i < 10; i++){
            addedNums.Add(i);
            RecursiveCombinationSum(sum + i, expectedValue, i, numsToAddLeft - 1, addedNums, result);
            addedNums.RemoveAt(addedNums.Count - 1);
        }
    }
}
// Find the sum of the elements in nums from the indices
// at queries[i][0] to queries[i][1] (inclusive) for each query,
// then add all of the sums for all the queries together.
// Return that number modulo (Math.pow(10, 9)) + 7)
// For nums = [3, 0, -2, 6, -3, 2] and queries = [[0, 2], [2, 5], [0, 5]],
// the output should be
// sumInRange(nums, queries) = 10.
//The array of results for queries is [1, 3, 6], so the answer is 1 + 3 + 6 = 10.

int sumInRange(int[] nums, int[][] queries) {
    
    int[] prefixSum = new int[nums.Length + 1];
    
    for(var i = 1; i <= nums.Length; i++) {
        prefixSum[i] = prefixSum[i-1] + nums[i-1];
        Console.Write(prefixSum[i] + " ");
    }
    
    
    var result = 0;
    foreach (var query in queries) {
        var start = query[0];
        result += prefixSum[query[1] + 1] - prefixSum[start];
        
    }
    
    var modVal = (Math.Pow(10, 9) + 7);
    
    if(result >= 0)
       return (result);
    else 
       return (int)(((result % modVal) + modVal) % modVal); 
}

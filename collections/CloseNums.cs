//Given an array of integers nums and an integer k, determine whether there are 
//two distinct indices i and j in the array where nums[i] = nums[j] and 
// the absolute difference between i and j is less than or equal to k.
//nums = [0, 1, 2, 3, 5, 2] and k = 3  output true
//nums = [0, 1, 2, 3, 5, 2] and k = 2  output false

bool ContainsCloseNums(int[] nums, int k) {
    var indexMap = new Dictionary<int, int>();
    for (var i=0; i<nums.Length; i++) {
        if(!indexMap.ContainsKey(nums[i])) {
            indexMap.Add(nums[i], i) ;
        }
        else {
            var diff = i - indexMap[nums[i]];
            if(diff <= k)
                    return true;
            
            indexMap[nums[i]] = i;
        }
    }
    return false;
}

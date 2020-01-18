//Given an array strings, determine whether it follows the sequence 
// given in the patterns array
//  strings = ["cat", "dog", "dog"] , patterns = ["a", "b", "b"]
// AreFollowingPatterns(strings, patterns) = true;

bool AreFollowingPatterns(string[] strings, string[] patterns) {
  
    var set1 = new HashSet<string>();
    var set2 = new HashSet<string>();
    
    for(var i = 0; i < strings.Length; i++) {
        var added1 = set1.Add(strings[i]);
        var added2 = set2.Add(patterns[i]);
        if (added1 != added2)
            return false;
    }
    return true;
}

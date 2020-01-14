char firstNotRepeatingCharacter(string s) {
    var charMap = new Dictionary<Char, int>();
    foreach(var ch in s) {
        if(charMap.ContainsKey(ch)) {
            charMap[ch] += 1;
        }
        else
            charMap[ch] = 1;
    }
    foreach(var kvp in charMap) {
        if(kvp.Value == 1) {
            return kvp.Key;
        }
    }
    return '_';
}
// If a string has 3 consecutive vowels or 5 consecutive consonants, or both, 
// then it is categorized as bad. Otherwise it is categorized as good.
//The string can also contain the character ?, which can be replaced by 
//either a vowel or a consonant. 
//This means that the string "?aa" can be bad if ? is a vowel or 
//good if it is a consonant. This kind of string is categorized as mixed

string ClassifyStrings(string s) {
    var vowels = new HashSet<char>(new char[] {'a', 'e', 'i', 'o', 'u'});
    var counter = new int[2];
    var mixed = false;
    
    for (var i=0; i < s.Length; i++) {
        var c = s[i];
        
        if (c == '?') {
            mixed = true;
            
            if(counter[1] < 2  && counter[0] < 4) {
                counter[0] = counter[1] = 0;
                continue;
            }
            c = counter[1] == 2 ? 'b' : 'a';
        }
        
        var index = vowels.Contains(c) ? 1 : 0;
        counter[index]++;
        counter[1-index] = 0;
        
        if(counter[0] == 5 || counter[1] == 3)
            return "bad";
    }
    
    if(mixed && s.Length > 2)
            return "mixed";
        
    return "good";
}    
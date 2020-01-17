//You have an array of strings crypt, the cryptarithm, and an an array containing the mapping
// of letters and digits, solution. The array crypt will contain three non-empty strings that follow
// the structure: [word1, word2, word3], which should be interpreted as the word1 + word2 = word3 cryptarithm.

//For crypt = ["SEND", "MORE", "MONEY"] and
// solution = [['O', '0'],
//             ['M', '1'],
//             ['Y', '2'],
//             ['E', '5'],
//             ['N', '6'],
//             ['D', '7'],
//             ['R', '8'],
//             ['S', '9']]
// the output should be - isCryptSolution(crypt, solution) = true
// No leading zeros in any of the words allowed.

bool isCryptSolution(string[] crypt, char[][] solution) {
    
    var mapping = new Dictionary<char, char>();
    
    foreach (var arr in solution) {
        mapping.Add(arr[0], arr[1]);
    }
    
    string[] result = new string[3];
    int index = 0;
    foreach (var word in crypt) {
        string wordVal = "";
        
        foreach (var ch in word) {
            char charValue;
            if (mapping.TryGetValue(ch, out charValue)) {
                wordVal += charValue.ToString();
            }
        }
        if (wordVal.Length > 1 && wordVal.StartsWith('0'))
            return false;
        
        result[index] = wordVal;
        Console.WriteLine(wordVal);
        index++;
    }
    return double.Parse(result[0]) + double.Parse(result[1]) == double.Parse(result[2]) ? true : false;
}

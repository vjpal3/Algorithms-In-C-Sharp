//find the first duplicate number for which the second occurrence has the minimal index.
int firstDuplicateNumber(int[] array) 
{
    var duplicates = new Dictionary<int, int>();
    
    for(int i = 0; i < array.Length; i++ )
    {
        if(duplicates.ContainsKey(array[i])) 
        {
            duplicates[array[i]] = i;
        }
        else 
        {
           duplicates.Add(array[i], array.Length);
        }
    }
    
    int min = array.Length;
    int minKey = 0;
    foreach(KeyValuePair<int, int> kvp in duplicates) 
    {
        if(kvp.Value < min) {
            min = kvp.Value;
            minKey = kvp.Key;
        }
    }
    
    return min >= array.Length ? -1 : minKey;
    
}

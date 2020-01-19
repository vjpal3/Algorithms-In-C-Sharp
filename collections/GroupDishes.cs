string[][] GroupingDishes(string[][] dishes) {
    
    var igMap = new Dictionary<String, string>(); 
    
    foreach(var dish in dishes) {
       for (var i = 1; i < dish.Length; i++) {
           if(igMap.ContainsKey(dish[i])) {
            igMap[dish[i]] += " " + dish[0];
        }
        else
            igMap[dish[i]] = dish[0];
       }       
    }
    
    List<List<string>> result = new List<List<string>>();
    
    foreach(var kvp in igMap) {
        
        if (kvp.Value.Contains(" ")) {
            List<string> inner = new List<string>();
            result.Add(inner);
            inner.Add(kvp.Key);
            inner.AddRange(kvp.Value.Split(" "));
            Console.WriteLine(string.Join(",", inner.ToArray()));
        }
    }
    return result.Select(a => a.ToArray()).ToArray();
}

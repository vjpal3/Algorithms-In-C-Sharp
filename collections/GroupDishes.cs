// You are given a list dishes, where each element consists of a list of strings 
// beginning with the name of the dish, followed by all the ingredients used in 
// preparing it. Return an array where each element is a list beginning with the 
// ingredient name, followed by the names of all the dishes that contain this 
// ingredient. The dishes inside each list should be sorted lexicographically, 
// and the result array should be sorted lexicographically by the names of 
// the ingredients.

// dishes = [["Salad", "Tomato", "Cucumber", "Salad", "Sauce"],
//             ["Pizza", "Tomato", "Sausage", "Sauce", "Dough"],
//             ["Quesadilla", "Chicken", "Cheese", "Sauce"],
//             ["Sandwich", "Salad", "Bread", "Tomato", "Cheese"]]

// GroupingDishes(dishes) = [["Cheese", "Quesadilla", "Sandwich"],
//                             ["Salad", "Salad", "Sandwich"],
//                             ["Sauce", "Pizza", "Quesadilla", "Salad"],
//                             ["Tomato", "Pizza", "Salad", "Sandwich"]]

string[][] GroupingDishes(string[][] dishes) {
    
    var igMap = new Dictionary<string, HashSet<string>>(); 
    
    foreach(var dish in dishes) {
        var dishName = dish.First();
        
        foreach (var ingredient in dish.Skip(1)) {
           if(!igMap.ContainsKey(ingredient)) 
                igMap[ingredient] = new HashSet<string>();
        
           igMap[ingredient].Add(dishName);
        }    
    }
    
    var ingredients = igMap
        .Where(kvp => kvp.Value.Count > 1)
        .OrderBy(kvp => kvp.Key, StringComparer.Ordinal)
        .Select(kvp => {
            List<string> inner = new List<string>() { kvp.Key };
            inner.AddRange(kvp.Value.OrderBy(x => x, StringComparer.Ordinal));
            return inner.ToArray();
                
        }).ToArray();
    
    return ingredients;
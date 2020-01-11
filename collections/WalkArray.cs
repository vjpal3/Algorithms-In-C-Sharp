public class Walk
{
    // Given an array of directions, determine if you can come to the sarting point in 10 minutes.
    //IsValidWalk(new string[] {"n","s","n","s","n","s","n","s","n","s"}) // true;
    // IsValidWalk(new string[] {"w","e","w","e","w","e","w","e","w","e","w","e"}) // false
    // IsValidWalk(new string[] {"n","n","n","s","n","s","n","s","n","s"})
    
  public static bool IsValidWalk(string[] walk)
  {
    if (walk.Length != 10) return false;
    
     int x = 0, y = 0;
     foreach (var direction in walk) 
     {
       if (direction == "n") x++;
       if (direction == "s") x--;
       if (direction == "e") y++;
       if (direction == "w") y--;
     }
     return x == 0 && y == 0;
  }
}
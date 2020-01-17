// Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, 
// otherwise returns false.   
 // scramble('rkqodlw', 'world') ==> True
using System;
using System.Linq;

public class Scramblies 
{
    public static bool Scramble(string str1, string str2) 
    {
      var possibleList = str1.ToList();
      foreach (var ch in str2) {
        if(!possibleList.Remove(ch))
          return false;
      }
      return true;
    }

}
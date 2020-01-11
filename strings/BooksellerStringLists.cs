using System;
using System.Collections.Generic;

public class StockList {

    // L = {"ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60"}
    // M = {"A", "B", "C", "W"} 
    // return (A : 20) - (B : 114) - (C : 50) - (W : 0)
    // If L or M are empty return string is ""

    public static string stockSummary(string[] lstOfArt, string[] lstOf1stLetter) {
      if (lstOfArt.Length == 0 || lstOf1stLetter.Length == 0)
        return "";
        
      var result = new List<string>();
      foreach (string category in lstOf1stLetter) {
        
        int sum = 0; int quantity;
        foreach( string art in lstOfArt) {
          
            if (art.StartsWith(category)) {
              quantity = Int32.Parse(art.Substring(art.IndexOf(" ")));
              sum += quantity;
            }
          }
          result.Add($"({category} : {sum})");
      
      }
      return string.Join(" - ", result.ToArray());
    }
}
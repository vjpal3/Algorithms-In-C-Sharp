// create a Tribonacci function that 
// given a signature array/list, returns the first n elements - signature included of the so seeded sequence.
// new Xbonacci().Tribonacci(new double []{1,1,1},10)  //=> new double []{1,1,1,3,5,9,17,31,57,105}
// new Xbonacci().Tribonacci(new double []{0,0,1},10)  //=> new double []{0,0,1,1,2,4,7,13,24,44}

using System;

public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
    if (n == 0) return new double[0];
        
    double[] result = new double[n];
    Array.Copy(signature, result, Math.Min(3, n));
    
    for (var i = 3; i < n; i++)
    {
      result[i] += result[i-1] + result[i-2] + result[i-3];
    }
    return result;
  }
}
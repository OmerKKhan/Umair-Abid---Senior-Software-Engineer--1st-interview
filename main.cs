using System;
using System.Collections.Generic;

// #Task 1 
//   Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

  // [1,9,2,19]  Target = 3, Answer = 0,2

// [2,4]  Target = 6, Answer =0,1
class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    var arr = new int[4]{1,9,2,19};
    var res = TwoSum(arr,3);

    foreach(var item in res){
      Console.WriteLine(item);
    }
  }

    public static int[] TwoSum(int[] nums, int target) {
      var dic = new Dictionary<int,int>();
      for(int i =0; i<nums.Length; i++){ 
        
      }
      var arr = new List<int>(); //cost 1 time 1
      for(int i =0; i<nums.Length; i++){ //cost 2 time n+1
        // cost 2 time n+1
          if(!dic.ContainsKey(target-nums[i])){
          // if(nums[i]+nums[j] == target){ //cost 2 time 1
          dic.Add(nums[i],i); 
            //return arr;
        }
        else{
          
          arr.Add(dic[i]);
        }
        
      }
      return arr.ToArray();  // cost 1 time 1
    }

  //sumt = 1 + 2(n+1) + 2 (n+1) + 2n + 1 + 1 + 1
        // = 2n + 2n +
    // o(n2)
}
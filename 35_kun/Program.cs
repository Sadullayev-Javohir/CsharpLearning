// ✅ 1. Takrorlanuvchi sonlarni o‘chirish

// Masala:
// Sizga nums nomli butun sonlardan iborat ro‘yxat berilgan. Ushbu ro‘yxatdan takroriy elementlarni olib tashlang va yagona (takrorlanmagan) sonlar ro‘yxatini, ularning ketma-ketligini saqlagan holda qaytaring.

// Input:

// nums = [1, 2, 2, 3, 4, 3, 5]

// Output:

// [1, 2, 3, 4, 5]

// Cheklovlar:

//     1 <= nums.Length <= 1000

//     -10^4 <= nums[i] <= 10^4


class Solution {
  public static List<int> RepeatNumsRemove(List<int> nums) {
    HashSet<int> seen = new HashSet<int>();
    List<int> result = new List<int>();

    foreach(var num in nums)
    {
      if(!seen.Contains(num))
      {
        seen.Add(num);
        result.Add(num);
      }
    }
    return result;
  }

  static void Main()
  {
    List<int> nums = new List<int>(){1, 2, 2, 3, 4, 3, 5};
    List<int> result = RepeatNumsRemove(nums);
    foreach(var i in result)
    {
      Console.WriteLine(i);
    }
  }
}


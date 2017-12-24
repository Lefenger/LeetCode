public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int sum = nums1.Length + nums2.Length;
            int target = sum / 2;
            int index1 = 0;
            int index2 = 0;
            double val1=0;
            double val2=0;
            
            int counttemp=0;
            int signal=0;
            if (nums1.Length == 0)
            {
                signal = 2;
                if (sum == 1)
                {
                    if (signal == 1)
                    {
                        return nums1[0];
                    }
                    if (signal == 2)
                    {
                        return nums2[0];
                    }
                }
            }
            else if (nums2.Length == 0)
            {
                signal = 1;
                if (sum == 1)
                {
                    if (signal == 1)
                    {
                        return nums1[0];
                    }
                    if (signal == 2)
                    {
                        return nums2[1];
                    }
                }
            }
            else
            {
                for (int i = 0; i < target - 1; i++)
                {
                    if (nums1[index1] <= nums2[index2])
                    {
                        index1++;
                        if (index1 == nums1.Length)
                        {
                            
                            signal = 2;
                            counttemp = i + 1;
                            break;
                        }
                    }
                    else
                    {
                        index2++;
                        if (index2 == nums2.Length)
                        {
                            
                            signal = 1;
                            counttemp = i + 1;
                            break;
                        }
                    }
                }
            }
            if (signal != 0)
            {
                if (signal == 1)
                {
                    index1 += target - 1 - counttemp;
                }
                else
                {
                    index2 += target - 1 - counttemp;                
                }

            }

            

            if (signal == 0)
            {
                if (nums1[index1] <= nums2[index2])
                {
                    val1 = nums1[index1];
                    index1++;
                }
                else
                {
                    val1 = nums2[index2];
                    index2++;
                }
                if ((index1 != nums1.Length) && (index2 != nums2.Length))
                {
                    if (nums1[index1] <= nums2[index2])
                    {
                        val2 = nums1[index1];
                        index1++;
                    }
                    else
                    {
                        val2 = nums2[index2];
                        index2++;
                    }
                }
                else if (index1 == nums1.Length)
                {
                    val2 = nums2[index2];
                }
                else
                {
                    val2 = nums1[index1];
                }


            }
            else if (signal == 1)
            {
                val1 = nums1[index1];
                val2 = nums1[index1+1];

            }
            else if (signal == 2)
            {
                val1 = nums2[index2];
                val2 = nums2[index2 + 1];

            }
            if (sum % 2 == 0)
            {
                return (val1 + val2) / 2;
            }
            else return val2;
    }
}
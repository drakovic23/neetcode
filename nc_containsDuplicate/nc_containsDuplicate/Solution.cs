using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nc_containsDuplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> integers = new HashSet<int>();

            foreach(int i in nums){

                if(integers.Add(i) == false){
                    return true;
                }
            }


            return false;
        }
    }
}

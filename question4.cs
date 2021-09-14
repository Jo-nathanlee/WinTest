public class Solution
  {
    public void SortCol(int[] nums){
        int red = 0, white = 0, blue = 0;
        for(int i = 0; i < nums.length; i++) {
            switch(nums[i]) {
            case 0:
                red++;
                break;
            case 1:
                white++;
                break;
            case 2:
                blue++;
                break;
            }
        }
    	for(int i = 0; i < nums.length; i++) {
            if(red > 0) {
                nums[i] = 0;
                red--;
            } else if(white > 0) {
                nums[i] = 1;
                white--;
            } else if(blue > 0) {
                nums[i] = 2;
                blue--;
            }
        }  
    }
    public static void Main(string[] args)
    {
    	int[] nums = { 2,0,1 };
        bool if_valid = true;
      	int n = nums.length;
        for(int i=0;i<n;i++){
        	if(nums[i] != 0 && nums[i] !=1 && nums[i] !=2){
            	if_valid = false;
            	break;
            }
        }
        if(n>=1&&n<=300&&if_valid){
        	SortCol();
        }
    }
    
  }
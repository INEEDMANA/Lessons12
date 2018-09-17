using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessson4 : MonoBehaviour {

    public int x;
    public int d;

    

    // Use this for initialization
    void Start () {

        int[] nums = new int[4] ;
        nums[0] = x;
        nums[1] = x+d;
        nums[2] = x + d * 2;
        nums[3] = x + d * 3;

        for (int i = 0; i < nums.Length; i++)
        {
            Debug.Log(nums[i]);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

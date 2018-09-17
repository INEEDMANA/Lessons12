using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour {
    int[] nums = new int[6] { 0, 1, 4, 9, 16, 25 };
  
    // Use this for initialization
    void Start () {
        for (int i = 0; i < nums.Length; i++)
        {
            Debug.Log(nums[i]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

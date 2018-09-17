using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour {
    int[] nums = new int[6] { 1, 1, 5, 1, 9, 23 };
    // Use this for initialization
    void Start () {
        for (int i = 0; i < nums.Length; i++)
        {
            //Array.Distinct().Count());  somehow
            Debug.Log(nums[i]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

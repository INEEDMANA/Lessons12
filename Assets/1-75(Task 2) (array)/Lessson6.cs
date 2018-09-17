using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessson6 : MonoBehaviour {
    //Сформировать убывающий массив из чисел, которые делятся на 3.

    int[] nums = new int[6] { 21, 18, 15, 12, 9, 6 };



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

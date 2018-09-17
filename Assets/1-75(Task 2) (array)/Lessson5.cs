using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessson5 : MonoBehaviour {
    //Сформировать возрастающий массив из четных чисел.



    int[] nums = new int[6] { 2, 4, 6, 8, 10, 12 };
   
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

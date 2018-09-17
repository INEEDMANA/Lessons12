using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Lessson1 : MonoBehaviour {

    //Заполнить массив нулями, кроме первого и последнего элементов, которые должны быть равны единице.

    int[] nums = new int[6] { 1, 0, 0, 0, 0, 1 };
    
    // Use this for initialization
    void Start () {

        for (int i=0; i<nums.Length; i++)
        {
               Debug.Log(nums[i]);
        }


       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

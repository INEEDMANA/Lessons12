using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessson3 : MonoBehaviour {

    //Заполнить массив последовательными нечетными числами, начиная с единицы.


    int[] nums = new int[6] { 1, 3, 5, 7, 9, 11 };
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

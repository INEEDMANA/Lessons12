using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessson2 : MonoBehaviour {

    //Заполнить массив нулями и единицами, при этом данные значения чередуются, начиная с нуля.


    int[] nums = new int[6] { 0, 1, 0, 1, 0, 1 };
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour {
    int[] arr = new int[6] { 1, 2, 3, 4, 5, 6 };
	// Use this for initialization
	void Start () {
        for (int i = 6 ; i <= arr.Length; i--)
        {
            int j = Random.Range(  i-5, i  );


            int tmp = arr[j];
            arr[j] = arr[i];
            arr[i] = tmp;

            Debug.Log(arr[i]);
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

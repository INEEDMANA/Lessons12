using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons80 : MonoBehaviour {
    //Вывести на экран ряд чисел 1001,  1004,  1007,  ... 1025.
   
        // Use this for initialization
    void Start () {
        for (int i = 1001; i <= 1025; i += 3)
        {
            Debug.Log(i);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

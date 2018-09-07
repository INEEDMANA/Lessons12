using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons90 : MonoBehaviour {
    //Найти сумму cos3/5+cos5/7+cos7/9+...+cos111/113.
  
        
        // Use this for initialization
    void Start () {
        float a = 3f;
        float b = 5f;
        float res = 0;
        for (int i = 0; i < 113; i++)
        {
            res += a / b;
            a += 2;
            b += 2;

        }
        Debug.Log("cos" + res);

    }

    // Update is called once per frame
    void Update () {
		
	}
}

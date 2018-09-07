using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons91 : MonoBehaviour {

    //Найти сумму 2/3+3/4+4/5+...+9/10.

    // Use this for initialization
    void Start () {
        float a = 2f;
        float b = 3f;
        float res = 0;
        for (int i = 0; i < 10; i++)
        {
            res += a / b;
            a++;
            b++;
            Debug.Log(res);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons94 : MonoBehaviour {

    //Найдите сумму 1+1/2+1/3+…+1/n.

    public int n;
    // Use this for initialization
    void Start () {
        float a = 1f;
        float b = 2f;
        float res = 1;
        for (int i = 0; i < n; i++)
        {
            res += a / b;
            Debug.Log(res);
            b++;

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons89 : MonoBehaviour {
    //Найти сумму  1+4+7+11+...+112.

    // Use this for initialization
    void Start () {
        int res = 0;
        int i = 1;
        while (i <= 112)
        {
            Debug.Log(i);
            res += i;
            i += 3;


        }
        Debug.Log(res);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

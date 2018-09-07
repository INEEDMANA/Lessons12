using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons88 : MonoBehaviour {

    //Найти произведение 5⋅6⋅7⋅...⋅13.

    // Use this for initialization
    void Start () {
        int res = 1;
        int i = 5;
        while (i <= 13)
        {
            Debug.Log(i);
            res *= i;

            i++;
            Debug.Log(res);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons95 : MonoBehaviour {
    public int a;
    public int n;

    //Даны a и n. Вычислите p=(a+1)2(a+2)2⋅…⋅(a+n)2  ====== (а+п)2 це тіпа (а+п)в квадраті
    // Use this for initialization
    void Start () {

        int p = 1;
        for (int i = 1; i <= n; i++)
        {
            p *= (a + i) * (a + i);
            Debug.Log(p);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

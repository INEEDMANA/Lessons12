using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons92 : MonoBehaviour {
    public int n;
    //Вывести на экран сто первых сумм вида 1+2+3+...+n.
    // Use this for initialization
    void Start () {

        int res = 0;
        for (int i = 1; i < n; i++)
        {
            res += i;

            Debug.Log(res + "+" + (i + 1));

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

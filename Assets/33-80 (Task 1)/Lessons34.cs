using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons34 : MonoBehaviour {

    public int x;
    private int res;
	// Use this for initialization
	void Start () {
        if (x>3)
        {
            res = x + 10;
            Debug.Log(res);
        }
        else
        {
            res = x - 10;
            Debug.Log(res);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

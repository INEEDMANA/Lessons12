using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons47 : MonoBehaviour {
    public int x;
    public int y;
    public int z;
	// Use this for initialization
	void Start () {

        if (x>y && x>z)
        {
            Debug.Log(x);
        }
		if(y>z && y>x)
        {
            Debug.Log(y);
        }
        if(z>y && z >x)
        {
            Debug.Log(z);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons41 : MonoBehaviour {

    public int x;
    // Use this for initialization
    void Start () {
        if (x > 100 || x < -100)
        {
            x *= 0;
        }
        else x += 1;
        Debug.Log(x);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

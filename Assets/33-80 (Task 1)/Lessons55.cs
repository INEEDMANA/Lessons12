using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons55 : MonoBehaviour {

    public int z;
    public int x;
    public int c;
    // Use this for initialization
    void Start () {
        if (z > 0 && x > 0 && c > 0)
        {
            Debug.Log("3");
        }
        if (x > 0 && z > 0 || x > 0 && c > 0 || z > 0 && c > 0)
        {
            Debug.Log("2");
        }
        if (c > 0 || x > 0 || z > 0)
        {
            Debug.Log("1");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

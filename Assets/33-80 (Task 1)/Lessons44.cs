using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons44 : MonoBehaviour {
    public int x;
    public int y;
    // Use this for initialization
    void Start () {
        if (x != 10 && y != 10 && x % 2 == 0)
        {
            x = x + y;
        }
        else x = x - y;
        Debug.Log(x);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

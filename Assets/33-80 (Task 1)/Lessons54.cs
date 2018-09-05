using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons54 : MonoBehaviour {
    public int x;

    public int z;
    public int y;
    // Use this for initialization
    void Start () {
        if (x < 5 && z < 5 || x < 5 && y < 5 || y < 5 && z < 5)
        {
            Debug.Log("yep");
        }
        else Debug.Log("nope");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons52 : MonoBehaviour {
    public int y;
    public int x;
    public int c;
    public int v;
    // Use this for initialization
    void Start () {
        if (y > 5 && x > 5 && c % 6 == 0 && v % 3 != 0)
        {

            Debug.Log("yes");
        }
        else Debug.Log("nope");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

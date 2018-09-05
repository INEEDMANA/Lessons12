using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons37 : MonoBehaviour {

    public int x;
    public int y;

    // Use this for initialization
    void Start () {
        if (x > y)
        {
            Debug.Log(x);
        }
        else Debug.Log(y);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

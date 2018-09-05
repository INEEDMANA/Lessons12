using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons38 : MonoBehaviour {
    public int x;
    public int y;
    // Use this for initialization
    void Start () {

        if (x - 100 >= y || x <= y - 100)
        {
            Debug.Log("yes");
        }
        else Debug.Log("No");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

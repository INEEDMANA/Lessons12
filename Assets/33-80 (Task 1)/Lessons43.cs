using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons43 : MonoBehaviour {
    public int x;

    // Use this for initialization
    void Start() {
        if (x <= 0)
        {
            Debug.Log("Roma ne lomay progu");
        }
        if (x <= 5 && x >= 3)
        {
            Debug.Log("spring");
        }
        if (x >= 6 && x <= 8)
        {
            Debug.Log("summer");
        }
        if (x >= 9 && x <= 11)
        {
            Debug.Log("autumn");
        }
        if (x == 1 || x == 2 || x==12)
        {
            Debug.Log("Winnter is coming");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

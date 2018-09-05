using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons42 : MonoBehaviour {
    public int x;
    // Use this for initialization
    void Start () {

        if (x >= 2 && x <= 5)
        {
            x = x * 10;
        }
        else if (x > 7 || x < 40)
        {
            x = x - 100;
        }
        else if (x <= 0 || x > 3000)
        {
            x = x * 3;
        }
        else x = x * 0;
        Debug.Log(x);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

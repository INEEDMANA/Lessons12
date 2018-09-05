using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons39 : MonoBehaviour {
    public int x;
    // Use this for initialization
    void Start () {
        int res;
        if (x > -10 && x < 10)
        {
            res = x * 5;

        }
        else res = x / 10;
        Debug.Log(res);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

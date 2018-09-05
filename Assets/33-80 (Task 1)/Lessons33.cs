using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons33 : MonoBehaviour {

    public int x;
    public int y;
    public float res;
	// Use this for initialization
	void Start () {
        if (x < 0 || y < 0)
        {
            Debug.Log("Error");
        }
        else
        {
            res = Mathf.Sqrt(x - Mathf.Sqrt(y));
            Debug.Log(res);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

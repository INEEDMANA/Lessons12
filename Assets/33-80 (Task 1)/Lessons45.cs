using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons45 : MonoBehaviour {
    public int x;
    public int y;
    public int z;
    // Use this for initialization
    void Start () {
        if (x > 10 && y > 10 && z > 10 && x % 3 == 0 && y % 3 == 0)
        {
            Debug.Log("yes");

        }
        else Debug.Log("no");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

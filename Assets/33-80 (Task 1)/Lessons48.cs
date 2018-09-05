using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons48 : MonoBehaviour {
    public int x;
    public int y;
    public int z;
    // Use this for initialization
    void Start () {
        if (x + y > x + z || x + y > y + z)
        {
            Debug.Log(x);
            Debug.Log(y);
        }
        else if (y + z > x + y || y + z > z + x)
        {
            Debug.Log(y);
            Debug.Log(z);
        }
        else if (z + x > y + x || z + x > y + z)
        {
            Debug.Log(x);
            Debug.Log(z);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons46 : MonoBehaviour {
    public int x;
    public int y;
    public int z;
    // Use this for initialization
    void Start () {

        if (x % 5 == 0 && y % 5 == 0 && z % 5 == 0)
        {
            x = x + y + z;
            Debug.Log(x);
        }
        else if (x % 5 == 0 && y % 5 == 0)
        {
            x = x + y;
            Debug.Log(x);

        }
        else if (x % 5 == 0 && z % 5 == 0)
        {
            x = x + z;
            Debug.Log(x);
        }
        else if (y % 5 == 0 && z % 5 == 0)
        {
            y = y + z;
            Debug.Log(y);

        }
        else Debug.Log("Error");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

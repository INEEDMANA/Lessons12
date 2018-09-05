using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons53 : MonoBehaviour {

    public int x;
    public int y;
    // Use this for initialization
    void Start () {
        {
            if (x > 30 || y > 30)
            {
                Debug.Log("yes");
            }
            else Debug.Log("no");

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

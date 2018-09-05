using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons35 : MonoBehaviour {

    public int x;
   

	// Use this for initialization
	void Start () {
        if (x<7)
        {
            Debug.Log("Yes");
        }
        if (x>10)
        {
            Debug.Log("No");

        }
        if (x == 9 )
        {
            Debug.Log("Error");
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

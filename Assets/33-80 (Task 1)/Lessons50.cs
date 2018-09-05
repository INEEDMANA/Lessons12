using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons50 : MonoBehaviour {
    public int x;
    public int y;
    public int z;
    // Use this for initialization
    void Start () {
       

            if (x == y || y == z || z == x)
            {
                Debug.Log("Yes");

            }
            else Debug.Log("Nope");
        }
    
	
	// Update is called once per frame
	void Update () {
		
	}
}

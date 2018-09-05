using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons51 : MonoBehaviour {
    public int x;
    public int z;
    public int y;
    // Use this for initialization
    void Start () {
        {
            if (x + y == z || y + z == x || z + x == y)
            {
                Debug.Log("yes");
            }
            else Debug.Log("nope ");


        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}

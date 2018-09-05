using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons49 : MonoBehaviour
{
    public int x;
    public int z;
    public int y;
    public int c;
    // Use this for initialization
    void Start()
    {
        if (x % 2 == 0 || c % 2 == 0 || y % 2 == 0 || z % 2 == 0)
        {
            if (x > c && x > y && x > z)
            {
                Debug.Log(x);
            }
            if (c > x && c > y && c > z)
            {
                Debug.Log(c);
            }
             if (y > z && y > c && y > x)
            {
                Debug.Log(y);
            }
           if (z > x && z > y && z > c)
            {
                Debug.Log(z);
            }
        }
        else Debug.Log("Not found");
        


    }
}

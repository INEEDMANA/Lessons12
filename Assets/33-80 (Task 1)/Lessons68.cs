using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons68 : MonoBehaviour {
    // Даны коэффициенты a,b,c уравнения ax2+bx+c=0. Найти решение.

    public int a;
    public int b;
    public int c;
    private float x1;
    private float x2;
    private float D;
	// Use this for initialization
	void Start () {
        // ax*x-bx+c =0
        D = b * b - 4 * a * c;
       if (D < 0)
        {
            Debug.Log("нет решений");
        }
       else
        {
            x1 = (-b + Mathf.Sqrt(D)) / 2 * a;
            x2 = (-b - Mathf.Sqrt(D)) / 2 * a;
            Debug.Log(x1);
            Debug.Log(x2);

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

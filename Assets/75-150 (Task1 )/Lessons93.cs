using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons93 : MonoBehaviour {
    public int n;

    //Найдите сумму квадратов первых n натуральных чисел

    // Use this for initialization
    void Start () {

        int res = 0;
        for (int i = 1; i <= n; i++)
        {
            res += i * i;

        }
        Debug.Log(res);

    }

    // Update is called once per frame
    void Update () {
		
	}
}

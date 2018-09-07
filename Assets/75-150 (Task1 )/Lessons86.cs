using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons86 : MonoBehaviour {
    //Для данного n найти сумму 1+2+3+...+n. Например, для n=10 ответ равен 55.

    public int n;
    
    
    // Use this for initialization
    void Start () {

        int res = 0;
        for (int i = 1; i <= n; i++)
        {
            int a = 0;
            a += i;
            res *= a;
        }
        Debug.Log(res);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessson87 : MonoBehaviour {

    //Найти сумму 10+11+12+13+...+88. Материал сайта www.itmathrepetitor.ru Ответ: 3871

    // Use this for initialization
    void Start () {
        int res = 0;
        for (int i = 10; i < 89; i++)
        {
            res += i;

        }
        Debug.Log(res);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

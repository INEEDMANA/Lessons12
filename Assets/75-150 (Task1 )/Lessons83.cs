using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons83 : MonoBehaviour {

    //Выведите следующие строки. Первая: 25  25.5  24.8. Вторая: 26 26.5 25.8.  И так далее. Последняя строка: 35 35.5 34.8.

    // Use this for initialization
    void Start () {
        int a = 25;
        float b = 25.5f;
        float c = 24.8f;

        for (int i = 0; i < 11; i++)
        {
            Debug.Log(a + " " + b + " " + c);
            a++;
            b++;
            c++;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

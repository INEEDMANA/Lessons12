using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons81 : MonoBehaviour {
    //Вывести на экран числа 100, 96, 92, ... до последнего положительного включительно
    
        // Use this for initialization
    void Start () {
        for (int i = 100; i >= 0; i -= 4)
        {
            Debug.Log(i);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

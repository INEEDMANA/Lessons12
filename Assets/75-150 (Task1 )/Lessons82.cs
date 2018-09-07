using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons82 : MonoBehaviour {
    //Выведите на экран числа 1.2, 1.4, 1.6, ..., 2.8.

    // Use this for initialization
    void Start () {
        for (float i = 1.2f; i < 3; i += 0.2f)
        {
            Debug.Log(i);

        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons76 : MonoBehaviour {

    //Выведите на экран n раз фразу "Silence is golden". Число n вводит пользователь.

    public int n;
    
    // Use this for initialization
    void Start () {
        for (int i = 0; i < n; i++)
        {
            Debug.Log("Silent is Gold ");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

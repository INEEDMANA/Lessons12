using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons78 : MonoBehaviour
{
    //Вывести на экран фигуру из звездочек:
    //*******
    //*******
    //*******
    //******
    //(квадрат из n строк, в каждой строке n звездочек)
    public int n;

    // Use this for initialization
    void Start () {
        string str = "*";
        for (int i = 0; i < n; i++)
        {  // треба якось зробити щоб колічество str 
           // в дебагі = n . я хз як це зробити
            Debug.Log(str + str + str + str);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

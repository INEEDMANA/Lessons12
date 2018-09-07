using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lessons56 : MonoBehaviour {
    
    //  Робот может перемещаться в четырех направлениях («11» — север, «12» — запад, «13» — юг, «14» — восток) и принимать три цифровые команды: 
    //    0 — продолжать движение, 1 — поворот налево, –1 — поворот направо. Дан число (11, 12, 13 или 14) — 
    //        исходное направление робота и целое число N (0, 1 или -1) — посланная ему команда. 
    //         Вывести направление робота после выполнения полученной команды (то есть север, запад, юг или восток).

    public int x;
    public int y;
	// Use this for initialization
	void Start () {
        if (x == 11)
        {
            if (y == 0)
            {
                Debug.Log("we are going south");
            }
            if (y == 1)
            {
                Debug.Log("we are going west");
            }
            if (y == -1)
            {
                Debug.Log("we are going еast");
            }
        }
        if (x == 12)
        {
            if (y == 0)
            {
                Debug.Log("we are going west ");
            }
            if (y == 1)
            {
                Debug.Log("we are going south ");
            }
            if (y == -1)
            {
                Debug.Log("we are going north ");
            }
        }
        if (x == 13)
        {
            if (y == 0)
            {
                Debug.Log("we are going north");
            }
            if (y == 1)
            {
                Debug.Log("we are going еast");
            }
            if (y == -1)
            {
                Debug.Log("we are going west");
            }
        }
        if (x == 14)
        {
            if (y == 0)
            {
                Debug.Log("we are going еast");
            }
            if (y == 1)
            {
                Debug.Log("we are going north");
            }
            if (y == -1)
            {
                Debug.Log("we are going south");
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

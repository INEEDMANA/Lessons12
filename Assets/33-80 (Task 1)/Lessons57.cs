using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons57 : MonoBehaviour {
    //    Дана дата из трех чисел (день, месяц и год). Вывести yes, если такая дата существует 
    //   (например, 12 02 1999 - yes, 22 13 2001 - no). Считать, что в феврале всегда 28 дней.

    public int days;
    public int month;
    public int year;

	// Use this for initialization
	void Start () {
        if (days <= 31 && month <= 12)
        {
            if (month == 2 && days >= 29)
            {
                Debug.Log("It`s february lol only 28 days");
            }
            Debug.Log("Yes");
        }
        else {
            Debug.Log("no");
       }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

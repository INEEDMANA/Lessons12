using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons58 : MonoBehaviour {
    // Дано две даты, каждая из которых состоит из трех чисел(день, месяц и год). 
    // Вывести yes, если первая дата раньше второй, иначе вывести no.


    public int data1;
    public int month1;
    public int year1;
    public int data2;
    public int month2;
    public int year2;
    // Use this for initialization
    void Start ()
    {
        if (data1 > 0 && data1 < 31 && month1 > 0 && month1 < 13 && year1 > 0)
        {
            if (data2 > 0 && data2 < 31 && month2 > 0 && month2 < 13 && year2 > 0)
            {
                if (year1 > year2)
                {
                    Debug.Log("First date is longer than the second date ");
                }
                else if (year1 == year2)
                {
                    if (month1 > month2)
                    {
                        Debug.Log("First date is longer than the second date ");
                    }
                    if (month1 < month2)
                    {
                        Debug.Log("Second date is longer than the first date");
                    }
                    else if (month1 == month2)
                    {
                        if (data1 > data2)
                        {
                            Debug.Log("First date is longer than the second date ");
                        }
                        else if (data1 == data2)
                        {
                            Debug.Log("The dates are the same");
                        }
                        if (data1 < data2)
                        {
                            Debug.Log("Second date is longer than the first date");
                        }

                    }
                }


            }
            else Debug.Log("wrong date ");
            if (year1 < year2)
            {
                Debug.Log("Second date is longer than the first date");
            }


        }
        else Debug.Log("wrong date ");

    }

    // Update is called once per frame
    void Update () {
		
	}
}

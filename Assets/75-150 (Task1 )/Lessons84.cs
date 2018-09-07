using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons84 : MonoBehaviour {

    //Пользователь вводит курс доллара в рублях. Показать таблицу цен 1$, 2$, ..., 100$ в рублях, 
    //третьим столбцом добавить количество кг конфет, которые можно купить на данные суммы, если цена 1 кг конфет равна 20 руб. 
    //Пример: 1$ - 70 р - 3.5 кг и так далее (всего 100 строк).
    public float dollar;

    // Use this for initialization
    void Start () {

        float rubles = 70;
        rubles = dollar * rubles;
        float candies = rubles / 20;
        Debug.Log(dollar + " " + rubles + " " + candies);
        for (float i = 1; i <= 100; i++)
        {
            float candis = rubles / 20;
            Debug.Log(i + " " + rubles + " " + candis);
            rubles += 70;

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

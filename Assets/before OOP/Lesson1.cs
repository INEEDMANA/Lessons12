using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour {

    //Компьютер загадывает число от 1 до n. У пользователя k попыток отгадать. 
    //После каждой неудачной попытки компьютер сообщает меньше или больше загаданное число.
    //В конце игры текст с результатом (или “Вы угадали”, или “Попытки закончились”).

    public int n;
    public int k;
   

    // Use this for initialization
    void Start () {
           
        int res = Random.Range(1, n);
        
    }
	
	// Update is called once per frame
	void Update () {
		for (int i=1; i<=k; i++)
        {


        }


	}
}

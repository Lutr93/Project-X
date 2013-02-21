using UnityEngine;
using System.Collections;

public class PlayerFlashlight : MonoBehaviour 
	{
	public Transform flashlight; //Захват фонарика
	public int rand; //Переменная для рандома
	public int frequency = 960; //Переменная для частоты
	
	// Мигание света
	void Update () 
		{
		rand = Random.Range(0,1000);
			if (rand >= frequency)
			{
				flashlight.active = false;
			}
			else
			{
				flashlight.active = true;
			}
		}
	}


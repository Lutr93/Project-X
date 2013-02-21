using UnityEngine;
using System.Collections;
using System.Threading;

public class ItemPick : MonoBehaviour 
{
	private bool _visable;
	private GUIScreenText gp;
	public AudioClip pickSound; //Подключаем звук
	
	void Awake () {
		gp = GameObject.Find("GUIScreenText").GetComponent<GUIScreenText>(); //инициализируем поле
	}
	
	void Update () 
	{		
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		
		//При нажатии на Е и расстоянии до объекта меньше 2 предмет будет побираться
		if(Input.GetButtonDown("Pick")& Vector3.Distance(transform.position, player.transform.position)<2)
		{
			audio.PlayOneShot(pickSound);
			//Thread.Sleep(500);
			if (gp != null)
      				{
						gp.TimeDown = 3;
						gp._visable = true;
      				}
			Destroy(gameObject);
		}
	}
}

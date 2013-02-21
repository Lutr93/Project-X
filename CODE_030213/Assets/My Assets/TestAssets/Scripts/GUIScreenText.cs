/// <summary>
/// GUI papers.
/// Ставить на пустой игровой объект
/// </summary>
/// 
using UnityEngine;
using System.Collections;

public class GUIScreenText : MonoBehaviour {
	
	//public int Papers;	// Количество записок
	public int TimeDown;	// Время исчезновения надписи
	private float Timer;	// Таймер
	public bool _visable;	// Вывод текста
	public string ItemText;
	private bool win;	// Вывод победы

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
		_visable = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (TimeDown != 0){
			Timer = (float)TimeDown;
			TimeDown = 0;
		}
		
		// Таймер
		if(Timer > 0)
			Timer -= Time.deltaTime;
		//на всякий случай обнуляем результат
		if(Timer < 0)
			Timer = 0;
		//если пауза выдержана то убираем надпись
		if(Timer == 0){
			_visable = false;
		}
		
		/*if (Papers == 10) {
			win = true;
			_visable = false;
		}*/
	}
	
	void OnGUI () {
		if (_visable) {
			GUI.Label ( new Rect(Screen.width/2,Screen.height/3,180,30), ItemText);
			//GUI.Label ( new Rect(Screen.width/2 + 52,Screen.height/3,180,30), Papers.ToString());
		}
		/*if (win) {
			GUI.Label ( new Rect(Screen.width/2,Screen.height/3,180,30), "You WIN");
		}*/
	}
}

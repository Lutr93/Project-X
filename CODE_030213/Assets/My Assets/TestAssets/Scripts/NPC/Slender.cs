/// <summary>
/// Slender.
/// Вешается на слендера
/// Отвечает за телепортацию Слендера к игроку
/// </summary>
using UnityEngine;
using System.Collections;

public class Slender : MonoBehaviour {
	//Перемещение
	private Transform target; //цель
	private Transform myTransform;  //переменная для хранения ссылки на свойство transform
	
	// Места телепортации
	public bool NoKill = true;	//Если игрок умер
	private string teg;	// Тег места перемещения
	private int rand;	// Рандомное число для случайного выбора тега
		
	// Таймер
	public float coolDown;       //время между телепортациями
	private float attackTimer;    //таймер
	
	void Awake(){
		//ссылка на transform чтоб сократить время обращения его в теле скрипта
		myTransform = transform;
	}
	
	// Use this for initialization
	void Start () {
		
		attackTimer = 0;
		if(coolDown == 0){
			coolDown = 6.0f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (NoKill){
		//выдерживаем паузу
		if(attackTimer > 0)
			attackTimer -= Time.deltaTime;
		//на всякий случай обнуляем результат
		if(attackTimer < 0)
			attackTimer = 0;
		//если пауза выдержана то телепортируемся
		if(attackTimer == 0){
			rand = Random.Range(1, 9);
			switch(rand)
			{
			case 1:
				teg = "Point1";
				break;
			case 2:
				teg = "Point2";
				break;
			case 3:
				teg = "Point3";
				break;
			case 4:
				teg = "Point4";
				break;
			case 5:
				teg = "Point5";
				break;
			case 6:
				teg = "Point6";
				break;
			case 7:
				teg = "Point7";
				break;
			case 8:
				teg = "Point8";
				break;
			}
					//ищем по тегу Point
					GameObject go = GameObject.FindGameObjectWithTag(teg);//.transform
					//поставить на него прицел
					target = go.transform;
				Teleport ();
		}
		}
		else {
			//ищем по тегу Kill
				GameObject go = GameObject.FindGameObjectWithTag("kill");//.transform
				//поставить на него прицел
				target = go.transform;
			Teleport ();
		}
			
	}
	
	void Teleport () {
		// Разворачиваемся
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation,Quaternion.LookRotation(target.position - myTransform.position),10000);
		// Телепортируемся
		myTransform.position = target.position;
		
		attackTimer = coolDown;
	}
}

using UnityEngine;
using System.Collections;

public class ShadowNpcAI : MonoBehaviour {
	//настраиваемое
	public Transform target;    // Цель
	public int moveSpeed;       // Скорость перемещения
	public int rotationSpeed;   // Скорость поворота
	public float maxDistance;      // Максимальное приближение к игроку
	public float curDistance; // Текущая дистанция
	public int ReactionDistance; // Дистанция на которой монстр реагирует
	public GameObject ObjPoint; // Объект поинта
	
	private Transform myTransform;  // Временная переменная для хранения ссылки на свойство transform
	
	public enum MonsterStat //перечисление всех состояний курсора
   	{
		walkPlayer,
		idle
   	}
	
	private MonsterStat _monsterStat;


	
	void Awake(){
		//ссылка на transform чтоб сократить время обращения его в теле скрипта
		myTransform = transform;
		
	}

	// Use this for initialization
	void Start () {
		//ищем по тегу player
		GameObject go = GameObject.FindGameObjectWithTag("Player");
		//поставить на него прицел
		target = go.transform;
		
			
		if(maxDistance == null) maxDistance = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
		curDistance = Vector3.Distance(target.position, myTransform.position);
		//PointDistance = Vector3.Distance(Point.position, myTransform.position);
		
		//если позволяет дистанция двигаемся к цели(проверка на минимальную дистанцию)
		if((curDistance >= maxDistance) && (curDistance <= ReactionDistance))
		{
			_monsterStat = MonsterStat.walkPlayer;
		}
		else 
		{
			_monsterStat = MonsterStat.idle;
		}
		
		switch(_monsterStat){
			case MonsterStat.idle:
				//чертим линию
				Debug.DrawLine(target.position,myTransform.position,Color.yellow);

			break;
			
			case MonsterStat.walkPlayer:
				//чертим линию
				Debug.DrawLine(target.position,myTransform.position,Color.red);
			
				// Разворачиваемся в сторону игрока
				myTransform.rotation = Quaternion.Slerp(myTransform.rotation,Quaternion.LookRotation(target.position - myTransform.position),rotationSpeed*Time.deltaTime);
				//двигаемся к цели
				myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
			
			break;
			
		}
	}
}
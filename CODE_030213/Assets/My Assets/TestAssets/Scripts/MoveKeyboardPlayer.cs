using UnityEngine;
using System.Collections;

public class MoveKeyboardPlayer : MonoBehaviour {

// Переменные движения
public GameObject player;
public int speedRotation = 7;
public int speed = 5;

// Анимации
public AnimationClip a_Idle;
public float a_IdleSpeed = 1;
public AnimationClip a_Walk;
public float a_WalkSpeed = 1;
public AnimationClip a_Run;
public float a_RunSpeed = 1;
	
private bool _run;
	
void Start () { 
	player = (GameObject)this.gameObject; 
	animation[a_Idle.name].speed = a_IdleSpeed;
	animation[a_Walk.name].speed = a_WalkSpeed;
	animation[a_Run.name].speed = a_RunSpeed;
	animation.CrossFade(a_Idle.name);
  }
		
  void Update(){
	// Переключение бег/ходьба		
	if (Input.GetKeyUp(KeyCode.R)) { 
		if (_run == false){
			speed = speed + 2;
			speedRotation = speedRotation + 3;
			_run = !_run;
		}
		else {
			speed = speed - 2;
			speedRotation = speedRotation - 3;
			_run = !_run;
		}	
	}
	// Передвижение		
	else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) 
  	{ 
  		player.transform.position += player.transform.forward * speed * Time.deltaTime; 
			
  		if (_run){ 
			animation.CrossFade(a_Run.name);
		}
		else{
			animation.CrossFade(a_Walk.name);
		}
  	} 
	else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) 
  	{ 
  		player.transform.position -= player.transform.forward * speed * Time.deltaTime;
			
		if (_run){
			animation.CrossFade(a_Run.name);
		}
		else{
			animation.CrossFade(a_Walk.name);
		}
  	} 
	else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) 
  	{ 
  		player.transform.Rotate(Vector3.down * speedRotation * Time.deltaTime);
			
		if (_run){
			animation.CrossFade(a_Run.name);
		}
		else{
			animation.CrossFade(a_Walk.name);
		}
 	} 
	else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) 
  	{ 
  		player.transform.Rotate(Vector3.up * speedRotation * Time.deltaTime);
			
		if (_run){
			animation.CrossFade(a_Run.name);
		}
		else{
			animation.CrossFade(a_Walk.name);
		}
  	} 
	else animation.CrossFade(a_Idle.name);
  }
}
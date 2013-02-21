using UnityEngine;
using System.Collections;

public class DoorAction : MonoBehaviour {
	public Transform DoorObject;
	public string Animation1;
	public string Animation2;
	
	void OnTriggerEnter () {
		DoorObject.animation.Play(Animation1);
	}
	
	void OnTriggerExit () {
		DoorObject.animation.Play(Animation2);
	}
}
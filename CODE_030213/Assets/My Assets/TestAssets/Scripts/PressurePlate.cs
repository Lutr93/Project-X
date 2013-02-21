using UnityEngine;
using System.Collections;

public class PressurePlate : MonoBehaviour {
	public Transform SetObject;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		SetObject.renderer.material.color = Color.red;
	}
	void OnTriggerExit () {
		SetObject.renderer.material.color = Color.blue;
	}
}

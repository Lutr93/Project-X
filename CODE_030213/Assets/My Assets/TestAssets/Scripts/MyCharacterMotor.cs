using UnityEngine;
using System.Collections;

public class MyCharacterMotor : MonoBehaviour {
	public Transform player;
	public int speedImpulse;
	public int jumpImpulse;
	private bool isJump;
	
	void Start()
	{
		//player = transform;
	}
	
	void Update()
	{
		if(Input.GetKey(KeyCode.W))
		{
			player.position += player.forward * speedImpulse * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.S))
		{
			player.position -= player.forward * speedImpulse * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.D))
		{
			player.position += player.right * speedImpulse * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.A))
		{
			player.position -= player.right * speedImpulse * Time.deltaTime;
		}
		if(Input.GetKeyDown(KeyCode.Space) && !isJump)
		{
			isJump = true;
			player.rigidbody.AddForce(Vector3.up * jumpImpulse * Time.deltaTime, ForceMode.Impulse);
		}
	}
}
using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public Transform player;
	public Transform TeleportPoint;
	
	void OnTriggerEnter ()
	{
			player.transform.position = TeleportPoint.transform.position;
	}
}

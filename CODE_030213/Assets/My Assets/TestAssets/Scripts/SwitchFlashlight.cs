using UnityEngine;
using System.Collections;

public class SwitchFlashlight : MonoBehaviour 
{
	
	public Transform flashlight; //Захват фонаркиа
	public AudioClip FlashLightSound;
	private int light = 1;
	
	// Вкл/Выкл свет
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			light += 1;
			if(light%2==0)
			{
				flashlight.active = false;
				audio.PlayOneShot(FlashLightSound);
			}
			else 
			{
				flashlight.active = true;
				audio.PlayOneShot(FlashLightSound);
			}
		}	
	}
}

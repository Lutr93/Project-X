using UnityEngine;
using System.Collections;

public class TurnLight : MonoBehaviour {
	public Transform LightObject;	//Захват источника света
	public float IntensityLight;
	public Material SwitchMaterial1;	//Метриалы
	public Material SwitchMaterial2;	//
	public AudioClip SoundFx;	//Звук
	private int i = 1;
	
	// Update is called once per frame
	void Update () {
		
		GameObject player = GameObject.FindGameObjectWithTag("Player");	//Инициализация игрока
		//Логика включения/выключения
		if(Input.GetButtonDown("Action")& Vector3.Distance(transform.position, player.transform.position)<2)
		{
			i += 1;
			if(i%2==0)
			{
				audio.PlayOneShot(SoundFx);	
				LightObject.renderer.material = SwitchMaterial2;
				LightObject.light.intensity = 0;		
			}
			else
			{
				audio.PlayOneShot(SoundFx);	
				LightObject.renderer.material = SwitchMaterial1;
				LightObject.light.intensity = IntensityLight;
			}
		}	
	}
}

using UnityEngine;
using System.Collections;
using System.Threading;

public class menu : MonoBehaviour {

public AudioClip ClickSound;	
public string AboutTextLine1;
public string AboutTextLine2;
public string AboutTextLine3;
public string AboutTextLine4;
private int _window = 0;
	
void  OnGUI (){ 
		
	//guiText.fontStyle = FontStyle.Bold;
if (_window == 0) { // теперь главное меню активировано при _window = 0 guiText.fontStyle = FontStyle.Bold;
	GUI.Box ( new Rect(Screen.width/2 - 100,Screen.height/2 - 100,200,180), "MAIN MENU"); 
if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 - 80,180,30), "Play")) { 
			Application.LoadLevel ("CryingShadow_1");
			audio.PlayOneShot(ClickSound);
    	}
if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 - 40,180,30), "About")) { 
            	_window = 2;
				audio.PlayOneShot(ClickSound);
            } 
if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 + 40,180,30), "Exit game")) { 
				Application.Quit();
				audio.PlayOneShot(ClickSound);
            } 
}

	// Помощь
if (_window == 2) { 
	GUI.Box ( new Rect(Screen.width/2 - 100,Screen.height/2 - 100,200,180), "ABOUT"); 
	GUI.Label ( new Rect(Screen.width/2 - 100,Screen.height/2 - 80,180,130), AboutTextLine1);
	GUI.Label ( new Rect(Screen.width/2 - 100,Screen.height/2 - 55,180,130), AboutTextLine2);
	GUI.Label ( new Rect(Screen.width/2 - 100,Screen.height/2 - 30,180,130), AboutTextLine3);
	GUI.Label ( new Rect(Screen.width/2 - 100,Screen.height/2 - 0,180,130), AboutTextLine4);// текст 
		if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 + 40,180,30), "Back") || Input.GetKey ("escape")) {	
        	_window = 0;
			audio.PlayOneShot(ClickSound);
    	} 
	}
}
}
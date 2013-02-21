function OnGUI() {
if(GUI.Button(new Rect(20,100,50,50),"up"))
{
GameObject.Find("Player(Clone)").transform.position = new Vector3(0,5,0);
}
}
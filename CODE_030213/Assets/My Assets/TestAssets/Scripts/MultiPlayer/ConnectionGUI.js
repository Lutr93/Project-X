var remoteIP = "192.168.0.3";
var remotePort = 25000;
var listenPort = 25000;
var useNAT = false;
var yourIP = "";
var yourPort = "";
 function OnGUI () {
// Проверка подключены ли вы к Серверу или нет
if (Network.peerType == NetworkPeerType.Disconnected)
{
// Если вы подключены
if (GUI.Button (new Rect(10,10,100,30),"Connect"))
{
Network.useNat = useNAT;
// Подключение к Серверу
Network.Connect(remoteIP, remotePort);
}
if (GUI.Button (new Rect(10,50,100,30),"Start Server"))
{
Network.useNat = useNAT;
// Создание Сервера
Network.InitializeServer(32, listenPort);
// Сказать нашим объектам, что уровень и сеть готова к работе
for (var go : GameObject in FindObjectsOfType(GameObject))
{
go.SendMessage("OnNetworkLoadedLevel",
SendMessageOptions.DontRequireReceiver);
}
}
// Создаем поля  ip адрес и port
remoteIP = GUI.TextField(new Rect(120,10,100,20),remoteIP);
remotePort = parseInt(GUI.TextField(new
Rect(230,10,40,20),remotePort.ToString()));
}
else
{
// Получаем твой  ip адрес и port
ipaddress = Network.player.ipAddress;
port = Network.player.port.ToString();
GUI.Label(new Rect(140,20,250,40),"IP Adress: "+ipaddress+":"+port);
if (GUI.Button (new Rect(10,10,100,50),"Disconnect"))
{
// Отключение от Сервера
Network.Disconnect(200);
}
}
}
function OnConnectedToServer () {
// Сказать всем объектам что сцена и сеть готовы
for (var go : GameObject in FindObjectsOfType(GameObject))
go.SendMessage("OnNetworkLoadedLevel",
SendMessageOptions.DontRequireReceiver);
}
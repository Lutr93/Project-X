var SpaceCraft : Transform;
function OnNetworkLoadedLevel () {
// Создание SpaceCraft(Корабля) когда сеть создана
Network.Instantiate(SpaceCraft, transform.position, transform.rotation, 0);
}
function OnPlayerDisconnected (player : NetworkPlayer) {
Network.RemoveRPCs(player, 0);
Network.DestroyPlayerObjects(player);
}
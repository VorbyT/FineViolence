using Prototype.NetworkLobby;
using UnityEngine;
using UnityEngine.Networking;

public class LobbyHooks : LobbyHook {

    public override void OnLobbyServerSceneLoadedForPlayer(NetworkManager manager, GameObject lobbyPlayer, GameObject gamePlayer)
    {
        LobbyPlayer lobby = lobbyPlayer.GetComponent<LobbyPlayer>();
        NetworkPlayer pilot = gamePlayer.GetComponent<NetworkPlayer>();
        pilot.name = lobby.name;
    }
}

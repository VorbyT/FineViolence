using UnityEngine;
using UnityEngine.Networking;

public class NetWork : NetworkManager {

    public static string ip = "2.94.117.95";

	// Use this for initialization
	void Start () {
        networkAddress = ip;

    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Kappa");
    }

    // Update is called once per frame
    void Update () {
        networkAddress = ip;
    }
}

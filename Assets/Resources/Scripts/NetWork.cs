using UnityEngine;
using UnityEngine.Networking;

public class NetWork : NetworkManager {

    public static string ip;

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

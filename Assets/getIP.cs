using UnityEngine;

public class getIP : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(Network.player.ipAddress);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using UnityEngine;
using UnityEngine.UI;


public class setIP : MonoBehaviour {

    static InputField field;

    void Start()
    {
        var path = GameObject.Find("IpField");
        field = path.GetComponent<InputField>();
        Debug.Log(path);
        Debug.Log(field);
    }

	public void btnClick()
    {
        NetWork.ip = field.text;
    }
}

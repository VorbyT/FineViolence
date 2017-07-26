using UnityEngine;
using UnityEngine.UI;

public class setIP : MonoBehaviour {

    InputField field;

    void Start()
    {
        field = GetComponent<InputField>();
       // field.text = NetWork.ip;
    }

	public void btnClick()
    {
        NetWork.ip = field.text;
    }
}

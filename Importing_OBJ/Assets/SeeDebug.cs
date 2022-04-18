using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeDebug : MonoBehaviour
{
    TextMesh textMesh;

    
    void Start()
    {
        textMesh = gameObject.GetComponent<TextMesh>();
    }
    private void OnEnable() //개체가 사용되도록 설정되고 활성상태가 되면 호출
    {
        Application.logMessageReceivedThreaded += LogMessage;
    }
    void OnDisable()         //동작을 사용할 수 없거나 비활성상태가 되면 호출
    {
        Application.logMessageReceivedThreaded -= LogMessage;
    }

    public void LogMessage(string message, string stackTrace, LogType type)
    {
        if (textMesh.text.Length > 300)
        {
            textMesh.text += message + "\n";//stackTrace는 근원지가 어떤 함수인지 알려준다
        }
        else
        {
            textMesh.text += message + "\n";
        }
    }
    // Update is called once per frame
    void Update()
    {
                
    }
}

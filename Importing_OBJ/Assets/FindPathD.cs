using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dummiesman;
using System.IO;
using System;


public class FindPathD : MonoBehaviour
{   //Application.persistentDataPath;를 사용
    //Import OBJ via Application.persistentDataPath;
    string f_path;

    public GameObject p;
    //public GameObject p, s, d, e;
    public GameObject c;
    GameObject obj;

    Transform posi;


    void loading(string path)
    {
        var lodedobj = new OBJLoader().Load(path);          //경로에서 파일 로드
        obj = GameObject.Find("Object2");
        posi = obj.GetComponent<Transform>();
        posi.position = new Vector3(-3.33f, -4.33f, -10f);  //눈앞에 보이게 transform 조정
        posi.localScale = new Vector3(0.01f, 0.01f, 0.01f);
    }


    void Start()
    {
        Instantiate(c, new Vector3(0f, 0.25f, 1f), Quaternion.identity);

        f_path = Application.persistentDataPath;

        string file_p;
        string fp;
        file_p = Path.Combine(f_path, "Object2.obj");
        fp = file_p.Replace("\\", "/");
        Debug.Log(fp);

        if (File.Exists(fp))
        {
            loading(fp);
        }
        else if (!File.Exists(fp))
        {
            Instantiate(p, new Vector3(-0.1f, 0f, 0.5f), Quaternion.identity);//홀로렌즈에서 파일을 찾지 못하면 큐브를 생성하도록 트릭 설치
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

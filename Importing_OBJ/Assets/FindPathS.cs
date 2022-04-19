using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dummiesman;
using System.IO;
using System;


public class FindPathS : MonoBehaviour
{   //Application.streamingAssetsPath를 사용
    //Import OBJ via Application.streamingAssetsPath
    string f_path;

    public GameObject p;
    //public GameObject p, s, d, e;
    public GameObject c;
    GameObject obj;

    Transform posi;


    void loading(string path)
    {   //Application.streamingAssetsPath; 를 사용 따로 StreamingAssets폴더를 만들어줘야함
        //Import OBJ via Application.streamingAssetsPath. You also have to make named StreamingAssets Folder before using this script.
        var lodedobj = new OBJLoader().Load(path);          //경로에서 파일 로드
        obj = GameObject.Find("Object3");                   //Load file from path
        posi = obj.GetComponent<Transform>();
        posi.position = new Vector3(-0.2f, 0.1f, 0.5f);     //Adjust transform to be visible
        posi.localScale = new Vector3(0.005f, 0.005f, 0.005f);
    }


    void Start()
    {
        Instantiate(c, new Vector3(0f, 0.25f, 1f), Quaternion.identity);
        //generate C prefab when start method is activate
        f_path = Application.streamingAssetsPath;

        string file_p = Path.Combine(f_path, "Object3.obj");   //file_p : f_path와 connect filepath f_path with "file name.obj"
        string fp = file_p.Replace("\\", "/");                 //fp     : replace file_p's '\' to '/' 
        Debug.Log(fp);                                         //debug log fp on Unity console window

        if (File.Exists(fp))                                    //If the file exists in path fp and is found 
        {
            loading(fp);                                        //call loading method with fp
        }
        else if (!File.Exists(fp))                              //If the file does not exist in path fp
        {
            Instantiate(p, new Vector3(-0.1f, 0f, 0.5f), Quaternion.identity);// genarate prefab
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

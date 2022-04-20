using UnityEngine;
using Dummiesman;
using System.IO;
using System;                       //Environmet.SpecialFolder를 쓰려면 필요


public class FindPathE : MonoBehaviour
{   //Environment.SpecialFolder를 사용
    //Import OBJ via Environment.SpecialFolder
    string f_path;

    public GameObject p;
    public GameObject c;
    GameObject obj;

    Transform posi;


    void loading(string path)
    {   //Environment.SpecialFolder를 사용하려면 빌드 이후 권한 설정을 해줘야함
        //If you want to use Environment.SpecialFolder, you must set access permission
        var lodedobj = new OBJLoader().Load(path);          //경로에서 파일 로드(Load file from path)    
        lodedobj.transform.position = new Vector3(0f, -0.45f, -0.25f);     //Adjust transform to be visible
        lodedobj.transform.localScale = new Vector3(0.001f, 0.001f, 0.001f); //눈앞에 보이게 transform 조정
    }


    void Start()
    {   
        Instantiate(c, new Vector3(0f, 0.25f, 1f), Quaternion.identity);
        //generate C prefab when start method is activate
        f_path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        string file_p = Path.Combine(f_path, "Object1.obj");    //file_p : f_path와 "원하는 obj파일명"의 경로를 Combine을 통해 합쳐줌 
        string fp = file_p.Replace("\\", "/");                  //fp     : file_p의 \같은 경로의 기호를 /로 변경해줌     
        Debug.Log(fp);                                          //fp를 유니티 콘솔창에 띄워줌

        if (File.Exists(fp))                                    //경로 fp에 파일이 존재하여 찾으면 
        {
            loading(fp);                                        //loading 함수에 fp를 넣고 호출
        }
        else if (!File.Exists(fp))                              //경로 fp에 파일이 존재하지 않으면
        {
            Instantiate(p, new Vector3(-0.1f, 0f, 0.5f), Quaternion.identity);// 프리펩을 생성하도록 트릭 설치
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

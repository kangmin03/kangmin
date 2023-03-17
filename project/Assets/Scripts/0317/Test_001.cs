using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   //한번 실행
        int age;              //변수 age
        age = 30;             //age는 30
        Debug.Log(age);       //age값을 콘솔창에 보여줌

        float height1 = 160.5f;         //height1에 160.5값 선언
        float height2;                  //height2 선언

        height2 = height1;              //height2에 height1 값 입력
        Debug.Log(height2);             //height2에 입력된 값을 콘솔창에 띄움

        string name;                    //name을 선언
        name = "Sera";                 //name에 kangmin 입력
        Debug.Log(name);                //name에 입력된 값을 콘솔창에 띄움
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;                     //anwer 선언  
        answer = 1 + 2;                 //answer 값 입력
        Debug.Log(answer);              //answer 값 출력

        int n1 = 8;                     //n1 값 선언후 입력
        int n2 = 9;                     //n2 값 선언후 입력
        int answer2;                    //answer2 선언
        answer2 = n1 + n2;              //answer2 값 입력
        Debug.Log(answer2);             //answer2 출력

        int answer3 = 10;               //answer3 선언후 입력
        answer3 += 5;                   //answer3에 +5 추가
        Debug.Log(answer3);             //answer3 출력
        answer3++;                      //answer3에 +1 추가
        Debug.Log(answer3);             //answer3 출력

        string str = "Happy";           //str 입력
        string str2 = "birthday";       //str2 입력

        str += str2;                    //str 뒤에 str2 붙임
        Debug.Log(str);                 //str 출력

        string message = str + answer3;  //message 값 입력
        Debug.Log(message);              //message 출력


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

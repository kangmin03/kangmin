using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;                     //anwer ����  
        answer = 1 + 2;                 //answer �� �Է�
        Debug.Log(answer);              //answer �� ���

        int n1 = 8;                     //n1 �� ������ �Է�
        int n2 = 9;                     //n2 �� ������ �Է�
        int answer2;                    //answer2 ����
        answer2 = n1 + n2;              //answer2 �� �Է�
        Debug.Log(answer2);             //answer2 ���

        int answer3 = 10;               //answer3 ������ �Է�
        answer3 += 5;                   //answer3�� +5 �߰�
        Debug.Log(answer3);             //answer3 ���
        answer3++;                      //answer3�� +1 �߰�
        Debug.Log(answer3);             //answer3 ���

        string str = "Happy";           //str �Է�
        string str2 = "birthday";       //str2 �Է�

        str += str2;                    //str �ڿ� str2 ����
        Debug.Log(str);                 //str ���

        string message = str + answer3;  //message �� �Է�
        Debug.Log(message);              //message ���


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   //�ѹ� ����
        int age;              //���� age
        age = 30;             //age�� 30
        Debug.Log(age);       //age���� �ܼ�â�� ������

        float height1 = 160.5f;         //height1�� 160.5�� ����
        float height2;                  //height2 ����

        height2 = height1;              //height2�� height1 �� �Է�
        Debug.Log(height2);             //height2�� �Էµ� ���� �ܼ�â�� ���

        string name;                    //name�� ����
        name = "Sera";                 //name�� kangmin �Է�
        Debug.Log(name);                //name�� �Էµ� ���� �ܼ�â�� ���
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

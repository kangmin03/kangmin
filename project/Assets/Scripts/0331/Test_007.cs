using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void SayHello()                                     //�μ��� ��ȯ���� ���� �޼���
    {
        Debug.Log("==================");
        Debug.Log("Hello");
        Debug.Log("==================");
    }

    void CallName(string name)                         //�μ��� �ִ� �޼���
    {
        Debug.Log("Hello " + name);
    }

    int Add(int a, int b)                             //�μ��� ��ȯ���� �ִ� �޼���
    {
        int c = a + b;      
        return c;                                     //int�� �Լ��� �����߱� ������ return�� int ������
    }
    void Start()
    {
        SayHello();
        SayHello();
        SayHello();

        CallName("Tom");
        CallName("Harry");
        CallName("Lora");

        int answer;                                  //���� answer ����
        answer = Add(2, 3);                          //�޼��� ȣ���� 2,3�� �� �Է� �׸��� return ���� answer�� ����
        Debug.Log(answer);
        Debug.Log(Add(7, 9));                        //�Լ��� ������ �ִ°��� �ƴ� Debug.Log�� �μ��� ���
    }

  

    // Update is called once per frame
    void Update()
    {
        
    }
}

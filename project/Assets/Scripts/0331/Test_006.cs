using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    public int[] array = new int[5];                    //�迭 5�� ������ ������ �̸� array ����
    public int[] points = { 83, 99, 52, 93, 15 };       
    void Start()
    {
        array[0] = 2;                                   //�迭�� ���� �Է�
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)                     //for���� ���� �ܼ�â�� array �迭 �ȿ� �ִ� 0~4 ���� ǥ��
        {
            Debug.Log(array[i]);
        }

        Debug.Log("===================");

        for (int i = 0; i < points.Length; i++)        //�迭�� ���̸� �������� ���� => 5
        {       
            if (points[i] > 90)                        //point[i] ���� for ���鼭 90�� �Ѵ� ���ڸ� ����Ʈ
            {
                Debug.Log(points[i]);
            }
        }

        int sum = 0;                                   //�ӽú��� sum ����

        for (int i = 0; i < points.Length; i++)        //�迭�� ���̸� �������� ���� => 5
        {
            sum += points[i];                          //����� �迭�� �� ��

        }

        int average = sum / points.Length;             //�迭�� �հ����� �迭 ���̸�ŭ ������(���)
        Debug.Log(average);                            //��հ� ���



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

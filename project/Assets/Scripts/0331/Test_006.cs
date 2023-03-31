using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    public int[] array = new int[5];                    //배열 5개 공간을 선언후 이름 array 설정
    public int[] points = { 83, 99, 52, 93, 15 };       
    void Start()
    {
        array[0] = 2;                                   //배열에 정수 입력
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)                     //for문을 통해 콘솔창에 array 배열 안에 있는 0~4 내용 표시
        {
            Debug.Log(array[i]);
        }

        Debug.Log("===================");

        for (int i = 0; i < points.Length; i++)        //배열의 길이를 가져오는 변수 => 5
        {       
            if (points[i] > 90)                        //point[i] 각각 for 돌면서 90이 넘는 숫자만 프린트
            {
                Debug.Log(points[i]);
            }
        }

        int sum = 0;                                   //임시변수 sum 선언

        for (int i = 0; i < points.Length; i++)        //배열의 길이를 가져오는 변수 => 5
        {
            sum += points[i];                          //선언된 배열의 합 값

        }

        int average = sum / points.Length;             //배열의 합값에서 배열 길이만큼 나누기(평균)
        Debug.Log(average);                            //평균값 출력



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

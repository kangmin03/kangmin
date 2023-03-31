using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void SayHello()                                     //인수도 반환값도 없는 메서드
    {
        Debug.Log("==================");
        Debug.Log("Hello");
        Debug.Log("==================");
    }

    void CallName(string name)                         //인수가 있는 메서드
    {
        Debug.Log("Hello " + name);
    }

    int Add(int a, int b)                             //인수와 반환값이 있는 메서드
    {
        int c = a + b;      
        return c;                                     //int로 함수를 선언했기 때문에 return도 int 여야함
    }
    void Start()
    {
        SayHello();
        SayHello();
        SayHello();

        CallName("Tom");
        CallName("Harry");
        CallName("Lora");

        int answer;                                  //변수 answer 선언
        answer = Add(2, 3);                          //메서드 호출후 2,3의 값 입력 그리고 return 값을 answer에 대입
        Debug.Log(answer);
        Debug.Log(Add(7, 9));                        //함수를 변수에 넣는것이 아닌 Debug.Log의 인수로 사용
    }

  

    // Update is called once per frame
    void Update()
    {
        
    }
}

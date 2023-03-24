using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour
{
    public int herbNum = 1;                 //정수 herbNum 선언 (public 추가)
    // Start is called before the first frame update
    void Start()
    {
                    
        if(herbNum == 1)                    //조건식 herbNum 이 1일 경우 로직 실행
        {
            Debug.Log("체력을 50 회복");    //조건 만족시 내용 출력
        }
        else
        {
            Debug.Log("체력 -50");          //조건을 만족하지 못할시 내용 출력
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

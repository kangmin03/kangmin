using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleTileMap : MonoBehaviour
{

    public GameObject tile;                                     //타일 게임오브젝트 선언

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile);                        //Prefabs or Object를 instantiate 함수로 생성 temp에 입력
                temp.transform.position = new Vector3(i, 0, j);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

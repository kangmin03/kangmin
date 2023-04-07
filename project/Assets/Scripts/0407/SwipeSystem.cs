using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{
    public Vector2 initialPos;      //마우스는 x, y 만 있음
    public GameObject Character;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) initialPos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0)) Calculate(Input.mousePosition);
    }

    void Calculate(Vector3 finalPos)                    //계산하는 함수
    {
        float disX = Mathf.Abs(initialPos.x - finalPos.x);
        float disY = Mathf.Abs(initialPos.y - finalPos.y);

        if(disX > 0 || disY > 0)                        //|| = or
        {
            if(disX > disY)
            {
                if(initialPos.x > finalPos.x)
                {
                    Debug.Log("Left"); Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
                }
                else
                {
                    Debug.Log("Right"); Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);
                }
            }
            else
            {
                if(initialPos.y > finalPos.y)
                {
                    Debug.Log("Down"); Character.transform.position += new Vector3(0.0f, 0.0f, -1.0f);
                }
                else
                {
                    Debug.Log("Up"); Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f);
                }
            }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_004 : MonoBehaviour
{
    public int hp = 180;
    public Text textUI;
    public Text hpTextUI;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))     //���ǹ� ���콺 �Է� ���� 0�μ��� ����
        {
            hp += 10;
        }
        if(Input.GetMouseButtonDown(1))     //���ǹ� ���콺 �Է� ���� 1�μ��� ������
        {
            hp -= 10;
        }

        if (hp <= 50)               //50���� �϶�
        {
            //Debug.Log("����!");    //�ؽ�Ʈ ���
            textUI.text = "����!";

        }
        else if (hp >= 200)         //200�̻� �϶�
        {
            //Debug.Log("����!");    //�ؽ�Ʈ ���
            textUI.text = "����!";
        }
        else                       //�ƴҶ�
        {
            //Debug.Log("���!");    //�ؽ�Ʈ ���
            textUI.text = "���!";
        }

        hpTextUI.text = "HP : " + hp.ToString();            //ToString ������ ���ڿ��� �ٲ��ִ� �Լ� ("HP : ����")
    }
}

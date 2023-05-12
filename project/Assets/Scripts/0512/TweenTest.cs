using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    public bool isPunch = false;
    Sequence sequenceLoop;
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMoveX(5, 2);            //X������ 5��ŭ 2�ʰ� �̵�
        //transform.DORotate(new Vector3(0, 0, 180), 2); //z�� 180�� ȸ��
        //transform.DOScale(new Vector3(2, 2, 2), 2); //2��� 2�ʵ���

        //Sequence sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 2)).SetEase(Ease.OutBounce);
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 2));
        //sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 2)).OnComplete(SequenceEnd);

        //sequenceLoop = DOTween.Sequence();
        //sequenceLoop.Append(transform.DOMoveX(5, 2)).SetEase(Ease.OutBounce);
        //sequenceLoop.SetLoops(-1, LoopType.Yoyo);
        //sequenceLoop.Kill();


    }

    void SequenceEnd()
    {
        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!isPunch)
            {
                isPunch = true;
                transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f),
                    0.1f, 10, 1).OnComplete(EndPunch);

            }
        }
    }
    void EndPunch()
    {
        isPunch = false;
    }
}
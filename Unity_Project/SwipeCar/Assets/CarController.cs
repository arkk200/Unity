using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        
    }

    void Update()
    {
        // ���������� ���̸� ���Ѵ�. (�߰�)
        if (Input.GetMouseButtonDown(0))    // ���콺�� Ŭ���ϸ�
        {
            // ���콺�� Ŭ���� ��ǥ
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // ���콺 ��ư���� �հ����� ������ �� ��ǥ
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            // �������� ���̸� ó�� �ӵ��� �����Ѵ�.
            this.speed = swipeLength / 500.0f;

            // ȿ������ ����Ѵ�.
            GetComponent<AudioSource>().Play();
        }


        transform.Translate(this.speed, 0, 0);  // �̵� // transform �տ� ������Ʈ�� �� ���̸� ��ũ��Ʈ�� ����� �ش� ������Ʈ�� Transform ������Ʈ�� �ν�
        this.speed *= 0.98f;                    // ����
    }    
}

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
        // 스와이프의 길이를 구한다. (추가)
        if (Input.GetMouseButtonDown(0))    // 마우스를 클릭하면
        {
            // 마우스를 클릭한 좌표
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 버튼에서 손가락을 떼었을 때 좌표
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            // 스와이프 길이를 처음 속도로 변경한다.
            this.speed = swipeLength / 500.0f;

            // 효과음을 재생한다.
            GetComponent<AudioSource>().Play();
        }


        transform.Translate(this.speed, 0, 0);  // 이동 // transform 앞에 오브젝트를 안 붙이면 스크립트가 적용된 해당 오브젝트의 Transform 컴포넌트로 인식
        this.speed *= 0.98f;                    // 감속
    }    
}

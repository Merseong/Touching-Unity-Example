using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 플레이어의 이동속도
    public float speed = 0.2f;

    // 매 프레임마다 호출됩니다.
    private void Update()
    {
        // WASD 또는 화살표 인풋을 받습니다. 상단바 Edit-Project Settings-Input에서 확인할 수 있습니다.
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 이 게임오브젝트의 transform의 Translate 함수를 호출합니다.
        // Translate는 현재위치에서 매개변수만큼 이동하는 함수입니다.
        gameObject.transform.Translate(horizontal * speed, vertical * speed, 0);
    }
}

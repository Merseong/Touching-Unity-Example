using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 이 오브젝트가 만들어진 뒤 호출되는 함수입니다.
    private void Start()
    {
        // 이 게임오브젝트를 10초 뒤 삭제합니다.
        Destroy(gameObject, 10);
    }
}

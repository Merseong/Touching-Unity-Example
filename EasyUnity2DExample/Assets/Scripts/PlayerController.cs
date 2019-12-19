using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 플레이어의 이동속도
    public float speed = 0.2f;
    // 쏠 오브젝트의 프리팹
    public GameObject bulletPrefab;
    // 총알을 쏘고 다음까지의 딜레이
    public float bulletTime = 0.1f;

    // 바로 직전에 쏜 총알의 시간
    private float lastBulletTime = 0;

    // 매 프레임마다 호출됩니다.
    private void Update()
    {
        // WASD 또는 화살표 인풋을 받습니다. 상단바 Edit-Project Settings-Input에서 확인할 수 있습니다.
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 이 게임오브젝트의 transform의 Translate 함수를 호출합니다.
        // Translate는 현재위치에서 매개변수만큼 이동하는 함수입니다.
        gameObject.transform.Translate(horizontal * speed, vertical * speed, 0);

        // 마우스를 좌클릭하고있으면 if문 안으로 들어갑니다.
        // GetMouseButtonDown으로 바꾸면 누르는 순간만 if문 안으로 들어갑니다.
        // Time.time은 게임이 시작하고 흐른 시간입니다.
        if (lastBulletTime + bulletTime < Time.time && Input.GetMouseButton(0))
        {
            lastBulletTime = Time.time;

            // 마우스 방향과 화면 중심에서  쏠 방향을 결정합니다.
            Vector3 dir = Input.mousePosition - new Vector3(Screen.width / 2, Screen.height / 2);

            // 프리팹의 인스턴스를 만들고, Rigidbody를 호출해 힘을 가합니다.
            GameObject bulletInst = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bulletInst.GetComponent<Rigidbody2D>().AddForce(dir);
        }
    }
}

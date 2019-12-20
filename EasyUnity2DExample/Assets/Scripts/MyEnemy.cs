﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    // 플레이어의 위치 정보입니다.
    public Transform player;
    // 적의 속도입니다.
    public float speed = 3;

    private void Start()
    {
        // 씬에서 "Player"라는 이름의 게임오브젝트의 위치정보를 가져옵니다.
        player = GameObject.Find("Player").transform;
    }

    private void Update()
    {
        // 만일 플레이어 오브젝트가 있다면
        if (player != null)
        {
            // 플레이어 방향으로 갑니다.
            transform.Translate((player.position - transform.position).normalized * speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Bullet>() is Bullet b) // 총알일 경우 (총알 스크립트를 가지고있을경우)
        {
            // 총알이 사라집니다.
            Destroy(b.gameObject);

            // 총알에 맞은 적도 사라집니다.
            Destroy(gameObject);
        }
        else if (collision.GetComponent<PlayerController>() is PlayerController p) // 플레이어일 경우 (플레이어 스크립트를 가지고있을경우)
        {
            // 시각적으로 보이지 않게하고, 컨트롤 스크립트를 끕니다.
            p.GetComponent<SpriteRenderer>().enabled = false;
            p.GetComponent<PlayerController>().enabled = false;

            // Log에 게임이 종료되었다고 표시합니다.
            Debug.LogError("Game Over!");
        }
    }
}
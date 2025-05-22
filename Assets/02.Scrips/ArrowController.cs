using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour
{
    public float moveSpeed;
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("player");
    }

    void Update()
    {
        // 화살을 아래로 이동
        transform.Translate(0, -moveSpeed, 0);

        // 충돌 판정
        Vector2 p1 = transform.position;    // 화살의 중심 좌표
        Vector2 p2 = player.transform.position;    // 플레이어의 중심 좌표
        Vector2 dir = p1 - p2;  //벡터 차이 => 벡터의 방향(플레이어 -> 화살)
        float d = dir.magnitude;    //벡터 크기
        float r1 = 0.5f;    // 화살의 반경
        float r2 = 1.0f;    // 플레이어의 반경

        //충돌 상태
        if (d < r1 + r2)
        {
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<GameManager>().HurtHP();

            Destroy(gameObject);
        }

        // Y 위치가 특정 값보다 작아지면 화살 객체 삭제
        if (transform.position.y < -6f) Destroy(gameObject);
    }
}
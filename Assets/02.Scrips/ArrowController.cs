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
        // ȭ���� �Ʒ��� �̵�
        transform.Translate(0, -moveSpeed, 0);

        // �浹 ����
        Vector2 p1 = transform.position;    // ȭ���� �߽� ��ǥ
        Vector2 p2 = player.transform.position;    // �÷��̾��� �߽� ��ǥ
        Vector2 dir = p1 - p2;  //���� ���� => ������ ����(�÷��̾� -> ȭ��)
        float d = dir.magnitude;    //���� ũ��
        float r1 = 0.5f;    // ȭ���� �ݰ�
        float r2 = 1.0f;    // �÷��̾��� �ݰ�

        //�浹 ����
        if (d < r1 + r2)
        {
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<GameManager>().HurtHP();

            Destroy(gameObject);
        }

        // Y ��ġ�� Ư�� ������ �۾����� ȭ�� ��ü ����
        if (transform.position.y < -6f) Destroy(gameObject);
    }
}
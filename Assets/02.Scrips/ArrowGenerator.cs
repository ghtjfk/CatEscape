using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float spawnTime = 1.0f;
    float deltaTime = 0;

    void Update()
    {
        deltaTime += Time.deltaTime;
        if (deltaTime > spawnTime)
        {
            deltaTime = 0;
            GameObject arrow = Instantiate(arrowPrefab);
            float pointX = Random.Range(-8.35f, 8.35f);
            arrow.transform.position = new Vector3(pointX, 7, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject hpGauge;
    public GameObject gameOver_Text;

    public float fullHP;
    public float myHP;
    void Start()
    {
        myHP = fullHP;
        hpGauge = GameObject.Find("hpGauge");
    }

    public void HurtHP()
    {
        myHP -= 20;
        hpGauge.GetComponent<Image>().fillAmount = myHP / fullHP;   //float값은 0으로 딱 떨어지지 않아, 나누기로 구현.

        if (myHP <= 0)
        {
            gameOver_Text.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject hpGauge;
    public GameObject gameOver_Text;
    void Start()
    {
        hpGauge = GameObject.Find("hpGauge");
    }

    public void HurtHP()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.2f;

        if (hpGauge.GetComponent<Image>().fillAmount <= 0.1f)
        {
            gameOver_Text.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}

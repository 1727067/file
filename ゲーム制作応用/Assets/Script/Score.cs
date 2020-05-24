using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private char rank;

    void Start()
    {
        if (CountTime.Instance.currentTime >= 60)
        {
            rank = 'S';
        }
        else if (CountTime.Instance.currentTime < 60 && CountTime.Instance.currentTime >= 40)
        {
            rank = 'A';
        }
        else if (CountTime.Instance.currentTime < 40 && CountTime.Instance.currentTime >= 20)
        {
            rank = 'B';
        }
        else if (CountTime.Instance.currentTime < 20 && CountTime.Instance.currentTime >= 0)
        {
            rank = 'C';
        }
        else
        {
            rank = 'D';
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "残り時間   " + (int)CountTime.Instance.currentTime + " 秒 \r\n評価 : " + rank;
    }
}

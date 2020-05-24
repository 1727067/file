using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountTime : MonoBehaviour
{
    public player timeUp;
    [SerializeField] float gameTime = 120.0f;
    Text time;
    public float currentTime;

    public Image TimeUp;

    static CountTime instance;

    public static CountTime Instance
    {
        get { return instance; }
    }

    void Start()
    {
        time = GetComponent<Text>();

        currentTime = gameTime;
        TimeUp.enabled = false;
    }

    void Update()
    {
        instance = this;

        Timer();
    }

    void Timer()
    {
        if (!Drop.Instance.dropFlag)
        {
            currentTime -= Time.deltaTime;
        }

        int minute = Mathf.FloorToInt(currentTime / 60f);

        int seconds = Mathf.FloorToInt(currentTime - minute * 60);

        if (currentTime <= 0.0f)
        {
            TimeUp.enabled = true;
            currentTime = 0;
            timeUp.TimeUp();

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("TitleScene");
            }
        }

        //デバッグ用
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    currentTime -= 5;
        //}

        time.text = string.Format("{0:00}", currentTime);
    }
}

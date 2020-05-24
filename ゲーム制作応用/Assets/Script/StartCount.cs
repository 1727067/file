using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartCount : MonoBehaviour
{
    public Text StartText;
    private float MaxTime = 4.0f;
    int time;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Couter();
    }

    void Couter()
    {
        MaxTime -= Time.deltaTime;
        time = (int)MaxTime;
        StartText.text = time.ToString();
        if (time == 0)
        {
            SceneManager.LoadScene("GameScene");
        }
    }

}

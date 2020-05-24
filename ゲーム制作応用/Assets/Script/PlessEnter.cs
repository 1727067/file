using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlessEnter : MonoBehaviour
{
    private GameObject textObject;
    private float nextTime;
    private float interval = 0.8f;

    void Start()
    {
        textObject = GameObject.Find("Text");
        nextTime = Time.time;

    }

    void Update()
    {
        EnterTime();
    }

    void EnterTime()
    {
        if (Time.time > nextTime)
        {
            float alpha = textObject.GetComponent<CanvasRenderer>().GetAlpha();
            if (alpha == 1.0f)
                textObject.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
            else
                textObject.GetComponent<CanvasRenderer>().SetAlpha(1.0f);

            nextTime += interval;
        }
    }
}

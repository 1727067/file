using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobTranslate : MonoBehaviour
{

    enum MobDirection
    {
        right,
        left
    }

    private MobDirection mobDir;

    // Use this for initialization
    void Start()
    {
        mobDir = MobDirection.right;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.x >= 20.0f)
        {
            mobDir = MobDirection.right;
        }
        else if (this.gameObject.transform.position.x <= -20.0f)
        {
            mobDir = MobDirection.left;
        }

        if (mobDir == MobDirection.right)
        {
            this.gameObject.transform.Translate(0.3f, 0.0f, 0.0f);
        }
        else if (mobDir == MobDirection.left)
        {
            this.gameObject.transform.Translate(-0.3f, 0.0f, 0.0f);
        }

    }
}

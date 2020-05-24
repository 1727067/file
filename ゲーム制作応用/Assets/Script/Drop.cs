using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Drop : MonoBehaviour
{
    private List<Joycon> m_joycons;

    public bool dropFlag;
    static Drop instance;
    private Animator srip;
    public AudioClip DropSE;

    public static Drop Instance
    {
        get { return instance; }
    }

    AudioSource dropSE;

    void Start()
    {
        m_joycons = JoyconManager.Instance.j;

        if (m_joycons == null || m_joycons.Count <= 0) return;

        dropSE = GetComponent<AudioSource>();

        srip = GetComponent<Animator>();

    }

    void Update()
    {
        instance = this;


        foreach (var joycon in m_joycons)
        {

            var accel = joycon.GetAccel();


            if (accel.x > 3.0 || accel.y > 3.0 || accel.z > 3.0)
            {
                if (!dropFlag)
                {
                    dropSE.PlayOneShot(DropSE);

                }

                dropFlag = true;
                srip.SetBool("Bool", true);
            }

            if (Input.GetKey(KeyCode.Return) && dropFlag)
            {
                dropFlag = false;
                CountTime.Instance.currentTime -= 5.0f;
                srip.SetBool("Bool", false);
            }
        }
    }
}

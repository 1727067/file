using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    //バランスボードデータ取得
    public GameObject data;
    WiiBalanceBoardCliant wiiBalanceBoardCliant;
    //当たり判定
    private bool hitJudge = false;
    private Vector3 player_pos;
    //サウンド
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audiosource;
    //ジョイコンデータ取得
    private List<Joycon> m_joycons;
    private Joycon m_joyconR;
    bool transformFlag;
    public bool dropFlag;
    static Drop instance;

    private Animator srip;

    private void Start()
    {
        data = GameObject.Find("Cliant");
        wiiBalanceBoardCliant = data.GetComponent<WiiBalanceBoardCliant>();
        audiosource = GetComponent<AudioSource>();

        m_joycons = JoyconManager.Instance.j;

        if (m_joycons == null || m_joycons.Count <= 0) return;

        m_joyconR = m_joycons.Find(c => !c.isLeft);
        transformFlag = false;

        m_joycons = JoyconManager.Instance.j;

        if (m_joycons == null || m_joycons.Count <= 0) return;


        srip = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!transformFlag)
        {
            PlayerManager();
        }
    }

    void PlayerManager()
    {
        float playerposition;
        float weight = 0;

        if (wiiBalanceBoardCliant.posdata == null)
        {
            return;
        }

        if (wiiBalanceBoardCliant.posdata.Length == 0)
        {
            return;
        }

        playerposition = float.Parse(wiiBalanceBoardCliant.posdata);

        weight = float.Parse(wiiBalanceBoardCliant.weightdata);

        if (wiiBalanceBoardCliant.posdata != null && wiiBalanceBoardCliant.weightdata != null)
        {
            if (weight > 0)
            {
                if (!Drop.Instance.dropFlag)
                {
                    this.gameObject.transform.Translate(0.0f, 0.0f, 0.5f);

                    player_pos = transform.position;
                    player_pos.x = Mathf.Clamp(player_pos.x, -20.0f, 20.0f);
                    transform.position = new Vector3(player_pos.x, player_pos.y, player_pos.z);

                    if (Input.GetKey(KeyCode.RightArrow) || playerposition > 0)
                    {
                        this.gameObject.transform.Translate(0.2f, 0.0f, 0.0f);
                    }

                    else if (Input.GetKey(KeyCode.LeftArrow) || playerposition < 0)
                    {
                        this.gameObject.transform.Translate(-0.2f, 0.0f, 0.0f);
                    }
                }
            }
        }

        this.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);

        if (this.gameObject.transform.position.z >= 2100)
        {
            SceneManager.LoadScene("EndScene");
        }

    }
    void OnCollisionEnter(Collision name)
    {
        if (name.gameObject.tag == "palasol")
        {
            audiosource.PlayOneShot(sound1);
        }

        if (name.gameObject.tag == "mob")
        {
            audiosource.PlayOneShot(sound2);
            m_joyconR.SetRumble(160, 320, 1.0f, 200);
            this.gameObject.transform.position -= (transform.forward * 10.0f);
            transformFlag = true;
            Invoke("MobHitEnd", 1);
        }
    }
    public void MobHitEnd()
    {
        transformFlag = false;
    }
    public void TimeUp()
    {
        transformFlag = true;
    }
}

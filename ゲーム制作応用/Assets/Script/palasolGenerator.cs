using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palasolGenerator : MonoBehaviour
{

    public GameObject palasol1;
    public GameObject palasol2;

    int rand;

    private Vector3[] coordinate = new Vector3[73];

    struct Palasol
    {

    }

    void Start()
    {
        coordinate[0] = new Vector3(-10, 0, 100);
        coordinate[1] = new Vector3(0, 0, 100);
        coordinate[2] = new Vector3(-20, 0, 150);
        coordinate[3] = new Vector3(5, 0, 150);
        coordinate[4] = new Vector3(15, 0, 150);
        coordinate[5] = new Vector3(-15, 0, 250);
        coordinate[6] = new Vector3(10, 0, 250);
        coordinate[7] = new Vector3(20, 0, 250);
        coordinate[8] = new Vector3(-5, 0, 300);
        coordinate[9] = new Vector3(-20, 0, 350);
        coordinate[10] = new Vector3(0, 0, 350);
        coordinate[11] = new Vector3(-10, 0, 400);
        coordinate[12] = new Vector3(15, 0, 400);
        coordinate[13] = new Vector3(-15, 0, 450);
        coordinate[14] = new Vector3(-5, 0, 500);
        coordinate[15] = new Vector3(10, 0, 500);
        coordinate[16] = new Vector3(20, 0, 500);
        coordinate[17] = new Vector3(-10, 0, 600);
        coordinate[18] = new Vector3(5, 0, 600);
        coordinate[19] = new Vector3(-20, 0, 650);
        coordinate[20] = new Vector3(0, 0, 650);
        coordinate[21] = new Vector3(15, 0, 650);
        coordinate[22] = new Vector3(5, 0, 700);
        coordinate[23] = new Vector3(20, 0, 700);
        coordinate[24] = new Vector3(-15, 0, 750);
        coordinate[25] = new Vector3(-5, 0, 750);
        coordinate[26] = new Vector3(10, 0, 750);
        coordinate[27] = new Vector3(-10, 0, 850);
        coordinate[28] = new Vector3(10, 0, 850);
        coordinate[29] = new Vector3(20, 0, 850);
        coordinate[30] = new Vector3(-20, 0, 950);
        coordinate[31] = new Vector3(5, 0, 950);
        coordinate[32] = new Vector3(15, 0, 950);
        coordinate[33] = new Vector3(-15, 0, 1000);
        coordinate[34] = new Vector3(0, 0, 1000);
        coordinate[35] = new Vector3(-5, 0, 1100);
        coordinate[36] = new Vector3(10, 0, 1100);
        coordinate[37] = new Vector3(20, 0, 1100);
        coordinate[38] = new Vector3(-20, 0, 1150);
        coordinate[39] = new Vector3(-10, 0, 1150);
        coordinate[40] = new Vector3(0, 0, 1150);
        coordinate[41] = new Vector3(15, 0, 1150);
        coordinate[42] = new Vector3(-15, 0, 1250);
        coordinate[43] = new Vector3(5, 0, 1250);
        coordinate[44] = new Vector3(-20, 0, 1350);
        coordinate[45] = new Vector3(-10, 0, 1350);
        coordinate[46] = new Vector3(10, 0, 1350);
        coordinate[47] = new Vector3(20, 0, 1350);
        coordinate[48] = new Vector3(-5, 0, 1400);
        coordinate[49] = new Vector3(15, 0, 1400);
        coordinate[50] = new Vector3(0, 0, 1450);
        coordinate[51] = new Vector3(15, 0, 1450);
        coordinate[52] = new Vector3(20, 0, 1500);
        coordinate[53] = new Vector3(10, 0, 1500);
        coordinate[54] = new Vector3(0, 0, 1550);
        coordinate[55] = new Vector3(-10, 0, 1550);
        coordinate[56] = new Vector3(10, 0, 1550);
        coordinate[57] = new Vector3(20, 0, 1600);
        coordinate[58] = new Vector3(10, 0, 1600);
        coordinate[59] = new Vector3(-20, 0, 1700);
        coordinate[60] = new Vector3(-10, 0, 1700);
        coordinate[61] = new Vector3(5, 0, 1700);
        coordinate[62] = new Vector3(-15, 0, 1800);
        coordinate[63] = new Vector3(-5, 0, 1800);
        coordinate[64] = new Vector3(10, 0, 1800);
        coordinate[65] = new Vector3(-20, 0, 1850);
        coordinate[66] = new Vector3(0, 0, 1850);
        coordinate[67] = new Vector3(20, 0, 1850);
        coordinate[68] = new Vector3(-10, 0, 1950);
        coordinate[69] = new Vector3(15, 0, 1950);
        coordinate[70] = new Vector3(-15, 0, 2000);
        coordinate[71] = new Vector3(0, 0, 2000);
        coordinate[72] = new Vector3(20, 0, 2000);

        for (int i = 0; i < 73; i++)
        {
            rand = Random.Range(0, 2);

            if (rand == 0)
            {
                GameObject x = Instantiate(palasol1) as GameObject;
                x.transform.position = coordinate[i];
            }
            else
            {
                GameObject x = Instantiate(palasol2) as GameObject;
                x.transform.position = coordinate[i];
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

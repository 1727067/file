using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    const int StageTipSize = 23;

    int currentTipIndex;

    public Transform charactor;
    public GameObject[] stageTips;
    public int startTipIndex;
    public int preInstantiate;
    public List<GameObject> generateStageList = new List<GameObject>();

    private void Start()
    {
        currentTipIndex = startTipIndex - 1;
        UpdateStage(preInstantiate);
    }

    private void Update()
    {
        int charaPositionIndex = (int)(charactor.position.z / StageTipSize);

        if (charaPositionIndex + preInstantiate > currentTipIndex)
        {
            UpdateStage(charaPositionIndex + preInstantiate);
        }
    }

    void UpdateStage(int toTipIndex)
    {
        if (toTipIndex <= currentTipIndex) return;

        for (int i = currentTipIndex + 1; i <= toTipIndex; i++)
        {
            GameObject stageObject = GenerateStage(i);

            generateStageList.Add(stageObject);
        }

        while (generateStageList.Count > preInstantiate + 2) DestroyOldestStage();

        currentTipIndex = toTipIndex;

    }

    GameObject GenerateStage(int tipIndex)
    {
        int nextStageTip = Random.Range(0, stageTips.Length);

        GameObject stageObject = (GameObject)Instantiate(
            stageTips[nextStageTip],
            new Vector3(30, -0.90f, tipIndex * StageTipSize),
            Quaternion.Euler(0, 180, 0)
            );

        return stageObject;
    }

    void DestroyOldestStage()
    {
        GameObject oldStage = generateStageList[0];
        generateStageList.RemoveAt(0);
        Destroy(oldStage);
    }
}
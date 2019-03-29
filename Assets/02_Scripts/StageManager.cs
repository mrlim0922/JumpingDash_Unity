using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{

    public GameObject[] Stages;

    [HideInInspector] static public Vector3 SpawnPos;

    int RandNumber;
    

    void Start ()
    {
        GameManager.instance.IsDie = false;
        GameManager.instance.IsRestart = false;
        GameManager.instance.IsClear = true;
        SpawnPos = transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (GameManager.instance.IsRestart)
        {
            GameManager.instance.IsClear = true;
            GameManager.instance.StageCount = 1;
        }
        
		if(GameManager.instance.IsClear)
        {
            RandNumber = Random.Range(0, 2);
            Instantiate(Stages[RandNumber], SpawnPos, Quaternion.identity);
            GameManager.instance.StageCount++;
            GameManager.instance.IsClear = false;
            GameManager.instance.IsRestart = false;
        }
	}
}

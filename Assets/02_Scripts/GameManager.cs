using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    #region Singleton

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }
    #endregion Singleton

    public bool IsDie = false;
    public bool IsRestart = false;
    [HideInInspector] public bool IsClear = true;
    public int StageCount = 1;
    public bool IsGameStart;
    public bool IsPause;

    void Start ()
    {
        IsDie = false;
        IsRestart = false;
        IsClear = true;
        StageCount = 1;
        IsGameStart = false;
        IsPause = false;
    }
	
	void Update ()
    {
		
	}
}

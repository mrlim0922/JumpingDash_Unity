using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] public Text ScoreText;
    public GameObject Ball;
    float Charge = 1.5f;
    static public int Score;

    private void Start()
    {
        Score = 0;
        ScoreText.text = Score.ToString();
    }

    private void Update()
    {
        if (Ball != null)
        {
            if (Ball.transform.position.y >= Charge)
            {
                Debug.Log("1");
                Score += 1;
                ScoreText.text = Score.ToString();
                Charge += 1.5f;
            }
        }
    }
}

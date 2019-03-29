using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text GameOverScoreText;
    public GameObject GameOverWindow;

    void Start ()
    {
        GameManager.instance.IsDie = false;
    }

    // Update is called once per frame
    void Update ()
    {
		if(GameManager.instance.IsDie == true)
        {
            GameOverWindow.SetActive(true);
            GameOverScoreText.text = ScoreManager.Score.ToString();
        }
	}

    public void RestartBtn()
    {
        GameManager.instance.IsRestart = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

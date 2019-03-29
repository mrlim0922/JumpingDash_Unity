using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtomManager : MonoBehaviour {

    public GameObject PauseWindow;

    private void Start()
    {
        GameManager.instance.IsPause = false;
        PauseWindow.SetActive(false);
    }

    public void PauseBtn()
    {
        if (GameManager.instance.IsGameStart && !GameManager.instance.IsDie)
        {
            PauseWindow.SetActive(true);
            Time.timeScale = 0f;
            GameManager.instance.IsPause = true;
        }
    }

    public void ReStartBtn()
    {
        PauseWindow.SetActive(false);
        Time.timeScale = 1f;
        GameManager.instance.IsRestart = true;
        GameManager.instance.IsPause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackBtn()
    {
        PauseWindow.SetActive(false);
        GameManager.instance.IsPause = false;
        Time.timeScale = 1f;
    }
}

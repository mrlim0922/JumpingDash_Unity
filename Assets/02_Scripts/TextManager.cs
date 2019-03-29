using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

    public Text StartText;

	void Update ()
    {
        if(!GameManager.instance.IsGameStart)
        {
            StartText.gameObject.SetActive(true);
        }

        else if(GameManager.instance.IsGameStart)
        {
            StartText.gameObject.SetActive(false);
        }

    }
}

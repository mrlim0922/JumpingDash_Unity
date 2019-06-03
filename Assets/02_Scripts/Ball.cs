using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public GameObject MainCamera;

    private void Start()
    {
        GameManager.instance.IsGameStart = false;
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    private void Update()
    {
        MainCamera.transform.position = Vector3.Lerp(MainCamera.transform.position,
            new Vector3(MainCamera.transform.position.x, transform.position.y, -10), Time.deltaTime);
    }


    public void LeftJumpBtn()  
    {
        if(!GameManager.instance.IsGameStart)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            GameManager.instance.IsGameStart = true;
        }

        if (!GameManager.instance.IsPause)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(-1.5f, 6f, 0);
        }
    } //Player LeftJump Button
    public void RightJumpBtn() 
    {
        if (!GameManager.instance.IsGameStart)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            GameManager.instance.IsGameStart = true;
        }

        if (!GameManager.instance.IsPause)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(1.5f, 6f, 0);
        }
    } //Player RightJump Button
}

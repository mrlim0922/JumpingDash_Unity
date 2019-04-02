using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    float speed = 2f;

    private void Update()
    {
        if (GameManager.instance.IsGameStart)
        {
            if (!GameManager.instance.IsDie)
                transform.Translate(new Vector2(0, 1) * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            GameManager.instance.IsDie = true;
        }
        else if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            Debug.Log("Obstacle");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            GameManager.instance.IsDie = true;
        }

        else if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            Debug.Log("Obstacle");
        }
    }
}


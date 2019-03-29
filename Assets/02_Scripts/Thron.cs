using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thron : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            GameManager.instance.IsDie = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            GameManager.instance.IsDie = true;
        }
    }
}

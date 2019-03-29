using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLine : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D col)
    {
        StageManager.SpawnPos =
            new Vector3(transform.position.x, transform.position.y + 6,
            transform.position.z);
        GameManager.instance.IsClear = true;
        Destroy(gameObject.GetComponent<BoxCollider2D>());
    }
}

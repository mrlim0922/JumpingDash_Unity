using UnityEngine;

public class Gate : MonoBehaviour
{
    public float targetPosition;
    public float Max;
    public float Min;
    public float speed;

    private void Update()
    {
        if (transform.position.x <= Min)
        {
            Debug.Log("-2");
            targetPosition = Max + 0.1f;
        }

        else if (transform.position.x >= Max)
        {
            Debug.Log("2");
            targetPosition = Min - 0.1f;
        }

        transform.position = Vector3.Lerp(transform.position, new Vector2(targetPosition,
                transform.position.y), speed * Time.deltaTime);

    }
}
using UnityEngine;

public class MoveableObstacle : MonoBehaviour
{

    [SerializeField] [Range(0f, 10f)] private float Speed = 1;
    [SerializeField] [Range(0f, 10f)] private float radiusX = 1;
    [SerializeField] [Range(0f, 10f)] private float radiusY = 1;

    public float targetPosition;
    public float Max;
    public float Min;
    public float RunningTime = 0f;
    public float X = 0f;
    public float Y = 0f;

    public int type; //xMove = 0 , yMove = 1, CircleMove = 2

    Vector3 pos = Vector3.zero;

    private void Start()
    {
        X = transform.position.x;
        Y = transform.position.y;
    }

    private void Update()
    {
        if (GameManager.instance.IsClear)
        {
            X = transform.position.x;
            Y = transform.position.y;
        }

        switch (type)
        {
            case 0:

                if (transform.position.x <= Min)
                {
                    targetPosition *= -1;
                }

                else if (transform.position.x >= Max)
                {
                    targetPosition *= -1;
                }

                transform.position = Vector3.Lerp(transform.position, new Vector2(targetPosition,
                        transform.position.y), Speed * Time.deltaTime);
                break;

            case 1:

                if (transform.position.y <= Min)
                {
                    targetPosition *= -1;
                }

                else if (transform.position.y >= Max)
                {
                    targetPosition *= -1;
                }

                transform.position = Vector3.Lerp(transform.position, new Vector2(transform.position.x,
                    targetPosition), Speed * Time.deltaTime);
                break;

            case 2:

                RunningTime += Time.deltaTime * Speed;
                float x = X + (radiusX * Mathf.Cos(RunningTime));
                float y = Y + (radiusY * Mathf.Sin(RunningTime));
                pos = new Vector2(x, y);
                transform.position = pos;
                break;
        }
    }
}
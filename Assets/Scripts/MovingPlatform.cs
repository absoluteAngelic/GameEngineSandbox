using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    Vector3 startingPosition;
    Vector3 endingPosition;
    public Transform endingPositionTransform;
    public float oneDirectionMoveTime;
    bool shouldMove;
    float movementCursor;
    bool countingUp;

    void Start()
    {
        startingPosition = this.transform.position;
        endingPosition = endingPositionTransform.position;
    }

    void Update()
    {
        if (shouldMove)
        {
            if (movementCursor <= 0)
            {
                countingUp = true;
            }
            else if (movementCursor >= oneDirectionMoveTime)
            {
                countingUp = false;
            }

            if (countingUp)
            {
                movementCursor += Time.deltaTime;
            }
            else
            {
                movementCursor -= Time.deltaTime;
            }

            float lerpedCursor = Mathf.InverseLerp(0,oneDirectionMoveTime, movementCursor);

            this.transform.position = new Vector3(Mathf.Lerp(startingPosition.x, endingPosition.x, lerpedCursor), Mathf.Lerp(startingPosition.y, endingPosition.y, lerpedCursor), Mathf.Lerp(startingPosition.z, endingPosition.z, lerpedCursor));
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (PlayerController.Instance.GetMoney() >= 50)
            {
                PlayerController.Instance.TakeMoney(50);
                shouldMove = true;
            }
            else
            {
                Debug.Log("Need 40 coins to buy the moving platform DLC");
            }
        }
    }
}

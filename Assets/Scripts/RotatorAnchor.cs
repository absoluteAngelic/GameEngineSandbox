using UnityEngine;

public class RotatorAnchor : MonoBehaviour
{
    public float maxAngle;
    public int degreesPerSecond;
    float currentAngle;
    bool flippingRight;
    Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (currentAngle <= 0)
        {
            flippingRight = true;
        }
        else if (currentAngle >= maxAngle)
        {
            flippingRight = false;
        }

        if (flippingRight)
        {
            currentAngle += Time.deltaTime * degreesPerSecond;
        }
        else
        {
            currentAngle -= Time.deltaTime * degreesPerSecond;
        }

        Quaternion localRotation = Quaternion.Euler(currentAngle, 0, 0);
        _rb.MoveRotation(localRotation);
    }
}

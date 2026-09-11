using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _rb;
    public GameObject winScreen;
    public GameObject loseScreen;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(new Vector3(-2, 0, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(new Vector3(0, 0, -2));
        }

        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(new Vector3(2, 0, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(new Vector3(0, 0, 2));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("End"))
        {
            Win();
        }

        if (collision.gameObject.CompareTag("LosePlane"))
        {
            Lose();
        }
    }

    void Win()
    {
        winScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    void Lose()
    {
        loseScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}

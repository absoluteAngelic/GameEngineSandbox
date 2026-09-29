using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    Rigidbody _rb;
    public GameObject winScreen;
    public GameObject loseScreen;
    bool touchingPlatform;

    int money;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.maxLinearVelocity = 20;

        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }

    void Update()
    {
        //Debug.Log(_rb.linearVelocity.magnitude);

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
            if (touchingPlatform)
            {
                _rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            }
        }
    }

    public void Win()
    {
        winScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Lose()
    {
        loseScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GiveMoney(int x)
    {
        money += x;
        Debug.Log($"Total Player Money: {money}");
    }

    public void TakeMoney(int x)
    {
        money -= x;
        Debug.Log($"Player Paid: {x}");
        Debug.Log($"Total Player Money: {money}");
    }

    public int GetMoney()
    {
        return money;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            touchingPlatform = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            touchingPlatform = false;
        }
    }
}

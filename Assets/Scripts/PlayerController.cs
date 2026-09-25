using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    Rigidbody _rb;
    public GameObject winScreen;
    public GameObject loseScreen;

    int money;

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

    public int GetMoney()
    {
        return money;
    }
}

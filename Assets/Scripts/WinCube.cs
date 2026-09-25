using UnityEngine;

public class WinCube : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (PlayerController.Instance.GetMoney() >= 10)
            {
                PlayerController.Instance.Win();
            }
        }
    }
}

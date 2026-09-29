using UnityEngine;

public class WinCube : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController.Instance.Win();
        }
    }
}

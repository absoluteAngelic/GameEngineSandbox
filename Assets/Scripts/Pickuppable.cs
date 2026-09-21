using UnityEngine;

public class Pickuppable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PickedUp();
        }
    }

    virtual protected void PickedUp()
    {
    }
}

using Unity.VisualScripting;
using UnityEngine;

public abstract class Pickuppable : MonoBehaviour
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

    public abstract void Spawn(Vector3 spawnPosition);
}

using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Pickuppable itemToSpawn;

    private void Start()
    {
        itemToSpawn.Spawn(gameObject.transform.position);
    }
}

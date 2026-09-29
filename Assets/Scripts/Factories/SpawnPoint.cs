using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public PickuppableFactory factoryToCall;

    private void Start()
    {
        factoryToCall.Spawn(this.gameObject);
    }
}

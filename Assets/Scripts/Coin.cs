using UnityEngine;

public class Coin : Pickuppable
{
    public int value = 5;

    override protected void PickedUp()
    {
        Debug.Log("Coin Picked Up");
        PlayerController.Instance.GetComponent<PlayerController>().GiveMoney(value);
        GameObject.Destroy(this.gameObject);
    }

    public override void Spawn(Vector3 spawnPosition)
    {
        GameObject spawnedObj = Instantiate(this.gameObject,spawnPosition, this.transform.rotation);
    }
}

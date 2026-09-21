using UnityEngine;

public class Coin : Pickuppable
{
    public int value = 5;

    [SerializeField]
    protected GameObject player;

    override protected void PickedUp()
    {
        Debug.Log("Coin Picked Up");
        player.GetComponent<PlayerController>().GiveMoney(value);
        GameObject.Destroy(this.gameObject);
    }
}

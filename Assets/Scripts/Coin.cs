using UnityEngine;

public class Coin : Pickuppable
{
    public int value = 5;

    override protected void PickedUp()
    {
        PlayerController.Instance.GetComponent<PlayerController>().GiveMoney(value);
        GameObject.Destroy(this.gameObject);
    }
}

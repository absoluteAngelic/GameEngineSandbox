using UnityEngine;

[CreateAssetMenu(fileName = "CoinFactory", menuName = "Factories/CoinFactory")]
public class CoinFactory : PickuppableFactory
{
    public Coin coin;
    public int amount;
    public float spaceBetween;

    public override void Spawn(GameObject _gameObject)
    {
        for (int i = 0; i < amount; i++)
        {
            Coin spawnedObj = Instantiate(coin, _gameObject.transform.position + new Vector3(0, i * spaceBetween, 0), coin.transform.rotation);
        }
    }
}

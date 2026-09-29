using UnityEngine;

[CreateAssetMenu(fileName = "PowerupFactory", menuName = "Factories/PowerupFactory")]
public class PowerupFactory : PickuppableFactory
{
    public Pickuppable powerup;

    public override void Spawn(GameObject _gameObject)
    {
        Pickuppable spawnedObj = Instantiate(powerup, _gameObject.transform.position, powerup.transform.rotation);
    }
}

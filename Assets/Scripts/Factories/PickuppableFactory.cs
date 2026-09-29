using UnityEngine;

public abstract class PickuppableFactory : ScriptableObject
{
    public abstract void Spawn(GameObject _gameObject);
}

using UnityEngine;

public class Bluer : Pickuppable
{
    [SerializeField]
    Material blueMaterial;

    LosePlane floor;

    private void Start()
    {
        floor = FindFirstObjectByType<LosePlane>();
    }

    override protected void PickedUp()
    {
        Debug.Log("Bluer picked up");
        floor.GetComponent<MeshRenderer>().material = blueMaterial;
        GameObject.Destroy(this.gameObject);
    }
}

using UnityEngine;

public class Redder : Pickuppable
{
    [SerializeField]
    Material redMaterial;

    LosePlane floor;

    private void Start()
    {
        floor = FindFirstObjectByType<LosePlane>();
    }

    override protected void PickedUp()
    {
        Debug.Log("Redder picked up");
        floor.GetComponent<MeshRenderer>().material = redMaterial;
        GameObject.Destroy(this.gameObject);
    }
}

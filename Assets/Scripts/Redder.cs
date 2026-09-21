using UnityEngine;

public class Redder : Pickuppable
{
    [SerializeField]
    Material redMaterial;

    [SerializeField]
    GameObject floor;

    override protected void PickedUp()
    {
        Debug.Log("Redder picked up");
        floor.GetComponent<MeshRenderer>().material = redMaterial;
        GameObject.Destroy(this.gameObject);
    }
}

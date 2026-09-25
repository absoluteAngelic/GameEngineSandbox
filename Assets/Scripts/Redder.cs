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

    public override void Spawn(Vector3 spawnPosition)
    {
        GameObject spawnedObj = Instantiate(this.gameObject, spawnPosition, this.transform.rotation);
    }
}

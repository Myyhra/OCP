using UnityEngine;

public class Villager : Character, IMovable, IHarvester
{
    public override void Move()
    {
        Debug.Log("Villager is moving");
    }
    public void Harvest()
    {
        Debug.Log("Villager is harvesting");
    }
}

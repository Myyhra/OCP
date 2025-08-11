using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class LiskovGameManager : MonoBehaviour
{
    private List<IMovable> movableList = new List<IMovable>();
    private List<IHarvester> harvesterList = new List<IHarvester>();

    public LiskovGameManager()
    {
        movableList = new List<IMovable>();
        {
            new Villager();
            new Character();
        };

        harvesterList = new List<IHarvester>()
        {
            new Villager()
        };

    }

    public void Update()
    {
        foreach (Character movable in movableList)
        {
            movable.Move();
        }
        foreach (Villager harvester in harvesterList)
        {
            harvester.Harvest();
        }
    }
}

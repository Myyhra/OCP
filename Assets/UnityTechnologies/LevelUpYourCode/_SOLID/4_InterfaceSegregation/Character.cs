using UnityEngine;

public class Character : IMovable
{
    public virtual void Move()
    {
        Debug.Log("Character is moving");
    }
    
}

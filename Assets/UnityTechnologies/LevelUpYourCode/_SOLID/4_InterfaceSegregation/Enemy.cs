using UnityEngine;

public class Enemy : MonoBehaviour, IDamageableP, IMoving, IUnitStats
{
    public float health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public float defense { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public int Strength { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public int Dexterity { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public int Endurance { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Die()
    {

    }

    public void RestoreHealth()
    {
        
    }

    public void TakeDamage()
    {
        
    }
    public void GoForward()
    {
        
    }
    public void Reverse()
    {
        
    }

    public void TurnLeft()
    {
        
    }

    public void TurnRight()
    {
        
    }
}

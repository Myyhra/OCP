using UnityEngine;

public interface IDamageable
{
    public float health { get; set; }
    public float defense { get; set; }
    public void Die();
    public void TakeDamage();
    public void RestoreHealth();
  
}

public interface IUnitStats
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Endurance { get; set; }
}
public interface IMoving
{
    public void GoForward();
    public void Reverse();
    public void TurnLeft();
    public void TurnRight();
}

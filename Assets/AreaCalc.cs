using UnityEngine;

[System.Serializable]
public class Rectangle : Shape
{
    public float x; public float y;
    public override float CalculateArea()
    {
        return x * y;
    }
}
[System.Serializable]
public class Circle : Shape
{
    public float rad;

    public override float CalculateArea()
    {
        return Mathf.PI * (rad * rad);
    }

}

public class AreaCalc : MonoBehaviour
{
    public float getArea(Shape shape)
    {
        return shape.CalculateArea();
    }
    void Start()
    {
       
    }

    void Update()
    {
        
    }
}

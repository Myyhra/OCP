using UnityEngine;
using UnityEngine.Pool;
public class Gun : MonoBehaviour
{
    public ObjectPoolManager poolManager;
    public GameObject bullets;
    public float muzzleVelocity;
    public Transform muzzlePosition;
    public float cooldown;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            poolManager.FireBullet(muzzlePosition.position,muzzlePosition.rotation);
        }
    }
}

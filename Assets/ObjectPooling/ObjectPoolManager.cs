using UnityEngine;
using UnityEngine.Pool;
public class ObjectPoolManager : MonoBehaviour
{
    public GameObject bulletPrefab;
    public ObjectPool<GameObject> bulletpool;

    private void Start()
    {
        //public objectPull
        //(
        //    Func<T> createFunc,
        //    Action<T> actionOnGet = null,
        //    Action<T> ActionOnRelease = null,
        //   Actuib<T> actionOnDestroy = null
        //)
        bulletpool = new ObjectPool<GameObject>
        (
            CreateBullet, //Creation Logic
            OnTakeBullet,//Object is taken from the pull
            OnReturnBullet,//When an object is returned to the pool
            OnDestroyBullet,//When the pool is cleared/destroyed
            false, //Whether the pull should grow dynamically
            10 //Initial size or pool
        );
    }

    GameObject CreateBullet()
    {
        return Instantiate( bulletPrefab );
    }

    void OnTakeBullet(GameObject bullet)
    {
        bullet.SetActive( true );
    }
    void OnReturnBullet(GameObject bullet)
    {
        bullet.SetActive ( false );
    }
    void OnDestroyBullet(GameObject bullet)
    {
        Destroy( bullet );
    }

    public void FireBullet(Vector3 Pos,Quaternion rotation)
    {
        GameObject bullet = bulletpool.Get();
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * 10);
        bullet.transform.position = Pos;
        bullet.transform.rotation = rotation;

    }

    public void ReturnBullets(GameObject bullet)
    {
        bulletpool.Release(bullet);
    }


}

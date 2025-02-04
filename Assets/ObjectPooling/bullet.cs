using UnityEngine;

public class bullet : MonoBehaviour
{
    public ObjectPoolManager poolManager;
    [SerializeField] float timer;
    float speed = 10f;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            //poolManager.ReturnBullets(gameObject);
            FindAnyObjectByType<ObjectPoolManager>().ReturnBullets(gameObject);
        }
    }
}

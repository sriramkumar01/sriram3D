using UnityEngine;

public class bullet : MonoBehaviour
{
    public float Life = 3;

    private void Awake()
    {
        Destroy(gameObject, Life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
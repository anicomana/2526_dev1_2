using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public int hitRequired = 1;

    void OnTriggerEnter(Collider other)
    {
        hitRequired--;
        Destroy(other.gameObject);

        if (hitRequired == 0)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            FindAnyObjectByType<ScoreManager>().AddScore();
        }
    }
}

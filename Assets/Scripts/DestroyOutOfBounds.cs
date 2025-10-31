using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -14.0f;

    void Update()
    {
        if (transform.position.z > topBound){
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound){
            Destroy(gameObject);
            Debug.Log("Animal has reached your FARM!!");
        }
    }
}

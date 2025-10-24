using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject projectilePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed); 
        
        // Bounding box for player
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        if (transform.position.z < -xRange) {
            transform.position = new Vector3(transform.position.x, transform.position.y, -xRange);
        }
        if (transform.position.z > xRange) {
            transform.position = new Vector3(transform.position.x, transform.position.y, xRange);
        }

        // Launch projectile

        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            Debug.Log("Shot the BANANA!!");
        }
        
    }
}

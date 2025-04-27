using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    [SerializeField] float speed = 5f;  // Movement speed

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // Left/Right keys
        float moveZ = Input.GetAxis("Vertical");   // Up/Down keys

        Vector3 move = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;
        transform.Translate(move, Space.World);
    }
}

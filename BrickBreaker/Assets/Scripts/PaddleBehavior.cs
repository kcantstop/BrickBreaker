using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    public float BoundaryL = -5.3f;
    public float BoundaryR = 5.3f;
    public float Speed = 5.0f;

    public KeyCode LeftDirection = KeyCode.LeftArrow;

    public KeyCode RightDirection = KeyCode.RightArrow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0.0f, 0.0f, 0.0f);

        if (Input.GetKey(LeftDirection))
        {
            movement.x -= Speed;
        }

        if (Input.GetKey(RightDirection))
        {
            movement.x += Speed;
        }
        
        if (transform.position.x <= BoundaryL)
        {
            movement.x = Mathf.Max(movement.x, 0);
        }

        if (transform.position.x >= BoundaryR)
        {
            movement.x = Mathf.Min(movement.x, 0);
        }

        movement *= Time.deltaTime;
        
        transform.position += movement;
    }
}

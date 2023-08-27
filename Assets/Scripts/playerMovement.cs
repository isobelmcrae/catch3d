using System.Collections;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float turnSpeed = 1.0f;
    private Rigidbody player;

    private float verticalInput; // movement input
    private float horizontalInput; // turn input

    private void Start()
    {
        player = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Move();
        Turn();
    }

    void Move()
    {
        Vector3 movement = transform.forward * verticalInput * moveSpeed;
        player.MovePosition(player.position + movement * Time.deltaTime);
    }

    void Turn()
    {
        float turn = horizontalInput * turnSpeed * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

        player.MoveRotation(player.rotation * turnRotation);
    }

}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 10.0f;
    public float gravity = -20f;

    public float yVelocity = 0;

    public Transform cameraTransform;
    public CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
    }

    private void playerMove()
    {
        float _moveDirX = Input.GetAxisRaw("Horizontal");
        float _moveDirZ = Input.GetAxisRaw("Vertical");

        Vector3 moveDirection = new Vector3(_moveDirX, 0, _moveDirZ);

        moveDirection = cameraTransform.TransformDirection(moveDirection);

        moveDirection *= speed;

        yVelocity += (gravity * Time.deltaTime);

        moveDirection.y = yVelocity;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}

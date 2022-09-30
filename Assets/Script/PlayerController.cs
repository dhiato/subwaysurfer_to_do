using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour

{
    private CharacterController controller;
    private Vector3 direction;
    private float desiredLane = 1;
    public float laneDistance = 4;
    public float jumpForce;
    public float Gravity = -20;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()

    {
        
        direction.y += Gravity * Time.deltaTime;

        if (SwipeManager.swipeUp)
        {
            jump();
        }

        if (SwipeManager.swipeRight)
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
        }

        if (SwipeManager.swipeLeft)
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if (desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }
        transform.position = targetPosition;
        controller.center = controller.center;

    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }
    private void jump()
    {
        direction.y = jumpForce;

    }
   
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private float speed = 10f;
    [SerializeField] private GameObject NextLevelMenu;
    [SerializeField] private GameObject PauseBT;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (horizontal != 0 || vertical != 0)
        {
            Spin(vertical, 0f ,horizontal);
        }
        
    }

    private void Spin(float x, float y, float z)
    {
        Vector3 torque = new Vector3(x, y, z * -1);

        rb.AddTorque(torque * speed);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("DeadZone"))
        {
            SceneController.Restart();
        }
        else if (collision.CompareTag("Finish"))
        {
            Time.timeScale = 0;
            NextLevelMenu.SetActive(true);
            PauseBT.SetActive(false);
        }
    }
}

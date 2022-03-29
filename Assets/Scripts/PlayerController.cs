using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    bool isOn = false;
    [SerializeField] float torqueAmount = 5f;
    [SerializeField] int forwardTorque = 50;
    [SerializeField] int boostSpeed = 15;

    SurfaceEffector2D surfaceEffector;

    Rigidbody2D rg2d;
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    private void RespondToBoost()
    {
        // throw new NotImplementedException();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isOn)
            {
                surfaceEffector.speed += boostSpeed;
            }
            else
            {
                surfaceEffector.speed -= boostSpeed;
            }
            isOn = !isOn;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rg2d.AddTorque(torqueAmount);
        }
        else
        {
            rg2d.AddTorque(-forwardTorque * Time.deltaTime);
        }
    }
}

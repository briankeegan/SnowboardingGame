using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 5f;
    [SerializeField] int forwardTorque = 50;
    Rigidbody2D rg2d;
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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

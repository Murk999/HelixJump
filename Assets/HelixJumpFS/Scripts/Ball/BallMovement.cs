using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallMovement : MonoBehaviour
{
    [Header("Fall")]
    [SerializeField] private float fallHeight;
    [SerializeField] private float fallSpeedDefault;
    [SerializeField] private float fallSpeedMax;
    [SerializeField] private float fallSpeedAxeleration;

    private Animator animatior;

    private float floorY;
    private float fallSpeed;


    private void Start()
    {
        enabled = false;

        animatior = GetComponent<Animator>();
    }

    private void Update()
    {
        if (transform.position.y > floorY)
        {
            //transform.Translate(0, -fallHeight * Time.deltaTime, 0); //локальное
            transform.position += Vector3.down * fallSpeed * Time.deltaTime; //глобальное

            if(fallSpeed < fallSpeedMax)
            {
                fallSpeed += fallSpeedAxeleration * Time.deltaTime;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, floorY, transform.position.z);
            enabled = false;
        }
        
    }

    public void Jump()
    {
        animatior.speed = 1;
        fallSpeed = fallSpeedDefault;
    }

    public void Fall(float startFloorY)
    {
        animatior.speed = 0;
        enabled = true;
        floorY = startFloorY - fallHeight;
    }

    public void Stop()
    {
        animatior.speed = 0;
    }
}

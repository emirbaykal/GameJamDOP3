using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float horverSpeed;

    private float hor;
    private float ver;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        transform.Translate(0f,0f,forwardSpeed * Time.deltaTime);

        hor = Input.GetAxis("Horizontal");

        ver = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hor * horverSpeed,ver * horverSpeed,0.0f);
        rb.AddForce(movement);

        rb.drag = 10;

        MovementAnim();
    }

    void MovementAnim()
    {
        if (hor > 0)
        {
            gameObject.transform.DORotate(new Vector3(0,0,-25),0.2f);
        }else if (hor == 0)
        {
            gameObject.transform.DORotate(new Vector3(0,0,0),0.2f);
        }else if (hor < 0)
        {
            gameObject.transform.DORotate(new Vector3(0,0,25),0.2f);
        }
        
        if (ver > 0)
        {
            gameObject.transform.DORotate(new Vector3(-25,0,0),0.2f);
        }else if (ver == 0)
        {
            gameObject.transform.DORotate(new Vector3(0,0,0),0.2f);
        }else if (ver < 0)
        {
            gameObject.transform.DORotate(new Vector3(25,0,0),0.2f);
        }
    }
}

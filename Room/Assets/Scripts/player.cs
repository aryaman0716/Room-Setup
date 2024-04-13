using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] float speed = 2.0f;
    [SerializeField] Rigidbody rb;

    float moveside;
    float movefront;
    Vector3 spawnPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawnPos = transform.position;
    }

    void Update()
    {
        moveside = Input.GetAxis("Horizontal");
        movefront = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(moveside, 0, movefront);
        moveDirection.Normalize();
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}

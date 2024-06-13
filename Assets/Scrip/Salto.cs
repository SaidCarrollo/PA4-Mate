using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    private Rigidbody _comRigiBody;
    private bool detector;
    public LayerMask Detectar;
    public float raycast;
    public float SpeedX;
    public float salto;
    public int maxSaltos = 2;
    private int saltosRestantes;

    private void Start()
    {
        _comRigiBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        CheckGround();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), 0);
        _comRigiBody.velocity = new Vector2(moveInput.x * SpeedX, _comRigiBody.velocity.y);

        if (Input.GetButtonDown("Jump") && saltosRestantes > 0)
        {
            Jump();
        }
    }

    private void Jump()
    {
        _comRigiBody.velocity = new Vector2(_comRigiBody.velocity.x, 0);
        _comRigiBody.AddForce(Vector2.up * salto, ForceMode.Impulse);
        saltosRestantes--;
    }

    private void CheckGround()
    {
        bool isGrounded = Physics2D.Raycast(transform.position, Vector2.down, raycast, Detectar);

        if (isGrounded)
        {
            saltosRestantes = maxSaltos;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("piso"))
        {
            detector = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("piso"))
        {
            detector = false;
        }
    }
}
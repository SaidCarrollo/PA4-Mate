using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Playermovement : MonoBehaviour
{
    private float velocidadCaminando = 4f;
    private float velocidadCorriendo = 5f;
    private bool estaCorriendo = false;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Movement(InputAction.CallbackContext context)
    {
        float inputX = context.ReadValue<Vector2>().x;
        estaCorriendo = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        float velocidadActual = estaCorriendo ? velocidadCorriendo : velocidadCaminando;
        Vector3 fuerzaMovimiento = new Vector3(inputX * velocidadActual, rb.velocity.y, 0f);

        rb.velocity = fuerzaMovimiento;
    }
}



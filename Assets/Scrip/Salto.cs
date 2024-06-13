using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    private Rigidbody rig;
    public float salto;
    public float verti;
    public bool detector;
    public bool jum;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verti = Input.GetAxis("Vertical");

        if (Input.GetAxis("Vertical") > 0 && detector == true)
        {
            jum = true;
        }
        else
        {
            jum = false;
        }

    }
    private void FixedUpdate()
    {

        if (jum == true)
        {
            rig.AddForce(Vector2.up * salto, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            detector = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            detector = false;
        }
    }
}

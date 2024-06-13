using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public HingeJoint joint;
    public void PararTiempo()
    {
        JointMotor motor = joint.motor;
        motor.targetVelocity = 0f;
        joint.motor = motor;
    }
    public void VolverTiempo()
    {
        JointMotor motor = joint.motor;
        motor.targetVelocity = 150f;
        joint.motor = motor;
    }
}

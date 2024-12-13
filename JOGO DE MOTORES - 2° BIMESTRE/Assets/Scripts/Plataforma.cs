using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    JointLimitState2D st;
    SliderJoint2D sl;

    void Start()
    {
        sl = GetComponent<SliderJoint2D>();
    }

    void Update()
    {
        if (sl.limitState == JointLimitState2D.LowerLimit || sl.limitState == JointLimitState2D.UpperLimit)
        {
            if ( st != sl.limitState)
            {
                JointMotor2D mot = sl.motor;
                mot.motorSpeed *= -1;
                sl.motor = mot;
            }
        }
        st = sl.limitState;
    }
}
   
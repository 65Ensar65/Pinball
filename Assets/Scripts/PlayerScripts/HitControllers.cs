using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitControllers : EBaseSingleton<HitControllers>
{
    [SerializeField] float ResetPos;
    [SerializeField] float PressedPosition;
    [SerializeField] float HitStrengt;
    [SerializeField] float FlipperDamper;


    private HingeJoint hingeJoint;
    void Start()
    {
        hingeJoint = GetComponent<HingeJoint>();
        hingeJoint.useSpring = true;
    }

    
    void Update()
    {
        GetHitController();
    }

    public void GetHitController()
    {
        JointSpring jointSpring = new JointSpring();
        jointSpring.spring = HitStrengt;
        jointSpring.spring = FlipperDamper;

        if (Input.GetMouseButton(0))
        {
            jointSpring.targetPosition = PressedPosition;
            //jointSpring.targetPosition = ResetPos;
            Debug.Log("Shoot2");
        }

        hingeJoint.spring = jointSpring;
        hingeJoint.useLimits = true;
    }
}

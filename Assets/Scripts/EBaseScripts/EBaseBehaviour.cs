using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBaseBehaviour : MonoBehaviour
{
    [HideInInspector] public Rigidbody e_rigibody;
    [HideInInspector] public Animator e_animator;
    [HideInInspector] public Collider e_collider;
    [HideInInspector] public Joystick e_joystick;
    [HideInInspector] public SphereCollider e_sphereCollider;
    [HideInInspector] public BallCurtainSystem e_ballCurtainSystem;
    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        e_rigibody = GetComponent<Rigidbody>() ? GetComponent<Rigidbody>() : null;
        e_animator = GetComponent<Animator>() ? GetComponent<Animator>() : null;
        e_collider = GetComponent<Collider>() ? GetComponent<Collider>() : null;
        e_sphereCollider = GetComponent<SphereCollider>() ? GetComponent<SphereCollider>() : null;
        e_joystick = (FindObjectOfType<Joystick>() ? FindObjectOfType<Joystick>() : null);
        e_ballCurtainSystem = (FindObjectOfType<BallCurtainSystem>() ? FindObjectOfType<BallCurtainSystem>() : null);
    }

}

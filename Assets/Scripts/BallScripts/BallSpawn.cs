using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : EBaseSingleton<BallSpawn>
{
    private BonusSystem _bonusSystem;
    private int _bonusSystemNumber;

    private void OnEnable()
    {
        _bonusSystem = FindObjectOfType<BonusSystem>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Curtain"))
        {
            GameObject gameObject = e_ballCurtainSystem.GetButBall();
            gameObject.transform.position = other.transform.position;
            gameObject.SetActive(true);
            Debug.Log("Çarptý");           
        }
    }
}

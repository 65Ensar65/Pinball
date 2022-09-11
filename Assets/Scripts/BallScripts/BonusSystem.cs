using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BonusSystem : EBaseSingleton<BonusSystem>
{
    [SerializeField] CurtainSystem curtainSystem;
    [HideInInspector] public int curtainNumber;

    [SerializeField] TMP_Text CurtainText;

    void Start()
    {
        GetCurtainController();   
    }

    public int GetGateNumber()
    {
        return curtainNumber;
    }

    public void GetCurtainController()
    {
        switch (curtainSystem)
        {
            case CurtainSystem.Positife:
                curtainNumber = Random.Range(1, 5);
                CurtainText.text = curtainNumber.ToString();
                break;
            case CurtainSystem.Negatife:
                curtainNumber = Random.Range(-1, -5);
                CurtainText.text = curtainNumber.ToString();
                break;
            default:
                break;
        }
    }

    public enum CurtainSystem
    {
        Positife,
        Negatife
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryPower : MonoBehaviour
{
    [SerializeField] Image BatteryImage;
    [SerializeField] float DrainTime = 15.0f;
    [SerializeField] float Power;

    void Update()
    {
        if (SaveScript.LightFlashOn == true || SaveScript.NightVisionOn == true)
        {
            BatteryImage.fillAmount -= (1.0f / DrainTime) * Time.deltaTime;
            Power = BatteryImage.fillAmount;
            SaveScript.BatteryPower = Power;
        }
        if (SaveScript.BatteryUsed == true)
        {
            SaveScript.BatteryUsed = false;
            BatteryImage.fillAmount = 1;
            Power = BatteryImage.fillAmount;
            SaveScript.BatteryPower = Power;
        }
    }
}

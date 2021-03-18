using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PlayerLightSettings : MonoBehaviour
{
    [SerializeField] PostProcessVolume Volume;
    [SerializeField] PostProcessProfile Standard;
    [SerializeField] PostProcessProfile NightVision;
    [SerializeField] GameObject NightVisionOverlay;
    [SerializeField] GameObject FlashLight;

    private bool NightVisionActive = false;
    private bool FlashLightActive = false;

    void Start()
    {
        NightVisionOverlay.gameObject.SetActive(false);
        FlashLight.gameObject.SetActive(false);
    }


    void Update()
    {
        if (SaveScript.BatteryPower > 0.0f)
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                if (NightVisionActive == true)
                {
                    NightVisionOverlay.gameObject.SetActive(false);
                    NightVisionActive = false;
                    Volume.profile = Standard;
                    SaveScript.NightVisionOn = false;
                }
                else
                {
                    NightVisionActive = true;
                    NightVisionOverlay.gameObject.SetActive(true);
                    Volume.profile = NightVision;
                    SaveScript.NightVisionOn = true;
                }
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (FlashLightActive == true)
                {
                    FlashLightActive = false;
                    FlashLight.gameObject.SetActive(false);
                    SaveScript.LightFlashOn = false;
                }
                else
                {
                    FlashLightActive = true;
                    FlashLight.gameObject.SetActive(true);
                    SaveScript.LightFlashOn = true;
                }

            }
        }
        else
        {
            FlashLight.gameObject.SetActive(false);
            NightVisionOverlay.gameObject.SetActive(false);
            Volume.profile = Standard;
            SaveScript.LightFlashOn = false;
            SaveScript.NightVisionOn = false;
            NightVisionActive = false;
            FlashLightActive = false;
        }

    }
}

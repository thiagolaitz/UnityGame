using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    [SerializeField] Text HealthText;

    void Start()
    {
        HealthText.text = SaveScript.Hp + "%";
    }

    void Update()
    {
        if(SaveScript.HpChanged == true)
        {
            SaveScript.HpChanged = false;
            HealthText.text = SaveScript.Hp + "%";
        }
    }
}

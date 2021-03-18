using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject InventoryMenu;
    [SerializeField] GameObject PlayerArms;
    [SerializeField] GameObject Knife;
    [SerializeField] GameObject Bat;
    //[SerializeField] GameObject Axe;

    //Apple
    [SerializeField] GameObject AppleImage1;
    [SerializeField] GameObject AppleButton1;
    [SerializeField] GameObject AppleImage2;
    [SerializeField] GameObject AppleButton2;
    [SerializeField] GameObject AppleImage3;
    [SerializeField] GameObject AppleButton3;
    [SerializeField] GameObject AppleImage4;
    [SerializeField] GameObject AppleButton4;

    //Battery
    [SerializeField] GameObject BatteryImage1;
    [SerializeField] GameObject BatteryButton1;
    [SerializeField] GameObject BatteryImage2;
    [SerializeField] GameObject BatteryButton2;
    [SerializeField] GameObject BatteryImage3;
    [SerializeField] GameObject BatteryButton3;
    [SerializeField] GameObject BatteryImage4;
    [SerializeField] GameObject BatteryButton4;

    //Weapons
    [SerializeField] GameObject KnifeImage;
    [SerializeField] GameObject KnifeButton;
    [SerializeField] GameObject BatImage;
    [SerializeField] GameObject BatButton;
    [SerializeField] GameObject PistolImage;
    [SerializeField] GameObject PistolButton;
    [SerializeField] GameObject CrossbowImage;
    [SerializeField] GameObject CrossbowButton;
    [SerializeField] GameObject AxeImage;
    [SerializeField] GameObject AxeButton;

    //Ammo
    [SerializeField] GameObject AmmoImage1;
    [SerializeField] GameObject AmmoButton1;
    [SerializeField] GameObject AmmoImage2;
    [SerializeField] GameObject AmmoButton2;
    [SerializeField] GameObject AmmoImage3;
    [SerializeField] GameObject AmmoButton3;
    [SerializeField] GameObject AmmoImage4;
    [SerializeField] GameObject AmmoButton4;
    [SerializeField] GameObject AmmoImage5;
    [SerializeField] GameObject AmmoButton5;

    //Keys
    [SerializeField] GameObject CabinKey;
    [SerializeField] GameObject CabinButton;
    [SerializeField] GameObject HouseKey;
    [SerializeField] GameObject HouseButton;
    [SerializeField] GameObject RoomKey;
    [SerializeField] GameObject RoomButton;

    private bool InventoryActive = false;
    private AudioSource Player;
    [SerializeField] AudioClip AppleBite;
    [SerializeField] AudioClip BatteryChange;
    [SerializeField] AudioClip WeaponChange;

    void Start()
    {
        Player = GetComponent<AudioSource>();
        InventoryMenu.gameObject.SetActive(false);
        InventoryActive = false;

        //Apple
        AppleImage1.gameObject.SetActive(false);
        AppleButton1.gameObject.SetActive(false);
        AppleImage2.gameObject.SetActive(false);
        AppleButton2.gameObject.SetActive(false);
        AppleImage3.gameObject.SetActive(false);
        AppleButton3.gameObject.SetActive(false);
        AppleImage4.gameObject.SetActive(false);
        AppleButton4.gameObject.SetActive(false);

        //Battery
        BatteryImage1.gameObject.SetActive(false);
        BatteryButton1.gameObject.SetActive(false);
        BatteryImage2.gameObject.SetActive(false);
        BatteryButton2.gameObject.SetActive(false);
        BatteryImage3.gameObject.SetActive(false);
        BatteryButton3.gameObject.SetActive(false);
        BatteryImage4.gameObject.SetActive(false);
        BatteryButton4.gameObject.SetActive(false);

        //Weapon
        KnifeImage.gameObject.SetActive(false);
        KnifeButton.gameObject.SetActive(false);
        BatImage.gameObject.SetActive(false);
        BatButton.gameObject.SetActive(false);
        CrossbowImage.gameObject.SetActive(false);
        CrossbowButton.gameObject.SetActive(false);
        AxeImage.gameObject.SetActive(false);
        AxeButton.gameObject.SetActive(false);
        PistolImage.gameObject.SetActive(false);
        PistolButton.gameObject.SetActive(false);

        //Keys
        CabinKey.gameObject.SetActive(false);
        CabinButton.gameObject.SetActive(false);
        HouseKey.gameObject.SetActive(false);
        HouseButton.gameObject.SetActive(false);
        RoomKey.gameObject.SetActive(false);
        RoomButton.gameObject.SetActive(false);

        //Ammo
        AmmoImage1.gameObject.SetActive(false);
        AmmoButton1.gameObject.SetActive(false);
        AmmoImage2.gameObject.SetActive(false);
        AmmoButton2.gameObject.SetActive(false);
        AmmoImage3.gameObject.SetActive(false);
        AmmoButton3.gameObject.SetActive(false);
        AmmoImage4.gameObject.SetActive(false);
        AmmoButton4.gameObject.SetActive(false);
        AmmoImage5.gameObject.SetActive(false);
        AmmoButton5.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (InventoryActive == true)
            {
                InventoryActive = false;
                InventoryMenu.gameObject.SetActive(false);
                Cursor.visible = false;
                Time.timeScale = 1f;
            }
            else
            {
                InventoryActive = true;
                InventoryMenu.gameObject.SetActive(true);
                Cursor.visible = true;
                Time.timeScale = 0f;
            }
        }

        CheckInventory();
        CheckWeapons();
        CheckKeys();
        CheckAmmo();
    }

    void CheckAmmo()
    {
        int Ammo = SaveScript.Ammo;
        int Arrow = SaveScript.Arrow;

        if (Ammo == 1)
        {
            AmmoImage1.gameObject.SetActive(true);
            AmmoButton1.gameObject.SetActive(true);
            AmmoImage2.gameObject.SetActive(false);
            AmmoButton2.gameObject.SetActive(false);
            AmmoImage3.gameObject.SetActive(false);
            AmmoButton3.gameObject.SetActive(false);
            AmmoImage4.gameObject.SetActive(false);
            AmmoButton4.gameObject.SetActive(false);
        }
        if (Ammo == 2)
        {
            AmmoImage1.gameObject.SetActive(true);
            AmmoButton1.gameObject.SetActive(true);
            AmmoImage2.gameObject.SetActive(true);
            AmmoButton2.gameObject.SetActive(true);
            AmmoImage3.gameObject.SetActive(false);
            AmmoButton3.gameObject.SetActive(false);
            AmmoImage4.gameObject.SetActive(false);
            AmmoButton4.gameObject.SetActive(false);
        }
        if (Ammo == 3)
        {
            AmmoImage1.gameObject.SetActive(true);
            AmmoButton1.gameObject.SetActive(true);
            AmmoImage2.gameObject.SetActive(true);
            AmmoButton2.gameObject.SetActive(true);
            AmmoImage3.gameObject.SetActive(true);
            AmmoButton3.gameObject.SetActive(true);
            AmmoImage4.gameObject.SetActive(false);
            AmmoButton4.gameObject.SetActive(false);
        }
        if (Ammo == 4)
        {
            AmmoImage1.gameObject.SetActive(true);
            AmmoButton1.gameObject.SetActive(true);
            AmmoImage2.gameObject.SetActive(true);
            AmmoButton2.gameObject.SetActive(true);
            AmmoImage3.gameObject.SetActive(true);
            AmmoButton3.gameObject.SetActive(true);
            AmmoImage4.gameObject.SetActive(true);
            AmmoButton4.gameObject.SetActive(true);
        }
        if (Arrow == 1)
        {
            AmmoImage5.gameObject.SetActive(true);
            AmmoButton5.gameObject.SetActive(true);
        }
    }

    void CheckKeys()
    {
        bool House = SaveScript.HouseKey;
        bool Cabin = SaveScript.CabinKey;
        bool Room = SaveScript.RoomKey;

        if (House == true)
        {
            HouseKey.gameObject.SetActive(true);
            HouseButton.gameObject.SetActive(true);
        }
        if (Cabin == true)
        {
            CabinKey.gameObject.SetActive(true);
            CabinButton.gameObject.SetActive(true);
        }
        if (Room == true)
        {
            RoomKey.gameObject.SetActive(true);
            RoomButton.gameObject.SetActive(true);
        }
    }

    void CheckWeapons()
    {
        bool Knife = SaveScript.Knife;
        bool Axe = SaveScript.Axe;
        bool Pistol = SaveScript.Pistol;
        bool Crossbow = SaveScript.Crossbow;
        bool Bat = SaveScript.Bat;

        if (Knife == true)
        {
            KnifeImage.gameObject.SetActive(true);
            KnifeButton.gameObject.SetActive(true);
        }
        if (Bat == true)
        {
            BatImage.gameObject.SetActive(true);
            BatButton.gameObject.SetActive(true);
        }
        if (Pistol == true)
        {
            PistolImage.gameObject.SetActive(true);
            PistolButton.gameObject.SetActive(true);
        }
        if (Axe == true)
        {
            AxeImage.gameObject.SetActive(true);
            AxeButton.gameObject.SetActive(true);
        }
        if (Crossbow == true)
        {
            CrossbowImage.gameObject.SetActive(true);
            CrossbowButton.gameObject.SetActive(true);
        }
    }

    void CheckInventory()
    {
        int Apples = SaveScript.Apples;
        int Batteries = SaveScript.Batteries;

        switch (Apples)
        {
            case 1:
                AppleImage1.gameObject.SetActive(true);
                AppleButton1.gameObject.SetActive(true);
                AppleImage2.gameObject.SetActive(false);
                AppleButton2.gameObject.SetActive(false);
                AppleImage3.gameObject.SetActive(false);
                AppleButton3.gameObject.SetActive(false);
                AppleImage4.gameObject.SetActive(false);
                AppleButton4.gameObject.SetActive(false);
                break;
            
            case 2:
                AppleImage1.gameObject.SetActive(true);
                AppleButton1.gameObject.SetActive(true);
                AppleImage2.gameObject.SetActive(true);
                AppleButton2.gameObject.SetActive(true);
                AppleImage3.gameObject.SetActive(false);
                AppleButton3.gameObject.SetActive(false);
                AppleImage4.gameObject.SetActive(false);
                AppleButton4.gameObject.SetActive(false);
                break;

            case 3:
                AppleImage1.gameObject.SetActive(true);
                AppleButton1.gameObject.SetActive(true);
                AppleImage2.gameObject.SetActive(true);
                AppleButton2.gameObject.SetActive(true);
                AppleImage3.gameObject.SetActive(true);
                AppleButton3.gameObject.SetActive(true);
                AppleImage4.gameObject.SetActive(false);
                AppleButton4.gameObject.SetActive(false);
                break;

            case 4:
                AppleImage1.gameObject.SetActive(true);
                AppleButton1.gameObject.SetActive(true);
                AppleImage2.gameObject.SetActive(true);
                AppleButton2.gameObject.SetActive(true);
                AppleImage3.gameObject.SetActive(true);
                AppleButton3.gameObject.SetActive(true);
                AppleImage4.gameObject.SetActive(true);
                AppleButton4.gameObject.SetActive(true);
                break;
        }

        switch (Batteries)
        {
            case 1:
                BatteryImage1.gameObject.SetActive(true);
                BatteryButton1.gameObject.SetActive(true);
                BatteryImage2.gameObject.SetActive(false);
                BatteryButton2.gameObject.SetActive(false);
                BatteryImage3.gameObject.SetActive(false);
                BatteryButton3.gameObject.SetActive(false);
                BatteryImage4.gameObject.SetActive(false);
                BatteryButton4.gameObject.SetActive(false);
                break;

            case 2:
                BatteryImage1.gameObject.SetActive(true);
                BatteryButton1.gameObject.SetActive(true);
                BatteryImage2.gameObject.SetActive(true);
                BatteryButton2.gameObject.SetActive(true);
                BatteryImage3.gameObject.SetActive(false);
                BatteryButton3.gameObject.SetActive(false);
                BatteryImage4.gameObject.SetActive(false);
                BatteryButton4.gameObject.SetActive(false);
                break;

            case 3:
                BatteryImage1.gameObject.SetActive(true);
                BatteryButton1.gameObject.SetActive(true);
                BatteryImage2.gameObject.SetActive(true);
                BatteryButton2.gameObject.SetActive(true);
                BatteryImage3.gameObject.SetActive(true);
                BatteryButton3.gameObject.SetActive(true);
                BatteryImage4.gameObject.SetActive(false);
                BatteryButton4.gameObject.SetActive(false);
                break;

            case 4:
                BatteryImage1.gameObject.SetActive(true);
                BatteryButton1.gameObject.SetActive(true);
                BatteryImage2.gameObject.SetActive(true);
                BatteryButton2.gameObject.SetActive(true);
                BatteryImage3.gameObject.SetActive(true);
                BatteryButton3.gameObject.SetActive(true);
                BatteryImage4.gameObject.SetActive(true);
                BatteryButton4.gameObject.SetActive(true);
                break;
        }

    }

    public void HealthUpdate()
    {
        int Hp = SaveScript.Hp;
        if(Hp < 90)
        {
            Player.clip = AppleBite;
            Player.Play();
            SaveScript.Apples -= 1;
            SaveScript.Hp += 10;
            SaveScript.HpChanged = true;
            AppleButton1.gameObject.SetActive(false);
            AppleImage1.gameObject.SetActive(false);

        }
        else if (Hp < 100 && Hp >= 90)
        {
            Player.clip = AppleBite;
            Player.Play();
            SaveScript.Hp = 100;
            SaveScript.Apples -= 1;
            SaveScript.HpChanged = true;
            AppleButton1.gameObject.SetActive(false);
            AppleImage1.gameObject.SetActive(false);
        }    

    }

    public void PowerUpdate()
    {
        Player.clip = BatteryChange;
        Player.Play();
        SaveScript.BatteryUsed = true;
        SaveScript.BatteryPower = 1f;
        SaveScript.Batteries -= 1;
        BatteryImage1.gameObject.SetActive(false);
        BatteryButton1.gameObject.SetActive(false);
    }

    public void AssignKnife()
    {
        PlayerArms.gameObject.SetActive(true);
        Knife.gameObject.SetActive(true);
        Player.clip = WeaponChange;
        Player.Play();
    }

    public void AssignBat()
    {
        PlayerArms.gameObject.SetActive(true);
        Bat.gameObject.SetActive(true);
        Player.clip = WeaponChange;
        Player.Play();
    }

    /*
    public void AssignAxe()
    {
        PlayerArms.gameObject.SetActive(true);
        Axe.gameObject.SetActive(true);
        Player.clip = WeaponChange;
        Player.Play();
    }*/

    public void WeaponsOff()
    {
        //Axe.gameObject.SetActive(false);
        Bat.gameObject.SetActive(false);
        Knife.gameObject.SetActive(false);
    }
}



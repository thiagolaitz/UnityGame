using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] AudioClip PickUpSound;
    [SerializeField] float distance = 4.0f;
    [SerializeField] GameObject PickUpMessage;
    [SerializeField] float AdjustY = -0.1f;
    [SerializeField] GameObject PlayerArms;

    RaycastHit hit;
    private AudioSource Player;
    private float RayDistance;
    private bool CanSeePickUp = false;
    private Vector3 Position;
    private Vector3 Adjust;

    void Start()
    {
        Player = GetComponent<AudioSource>();
        PickUpMessage.gameObject.SetActive(false);
        PlayerArms.gameObject.SetActive(false);
        RayDistance = distance;
        Player.clip = PickUpSound;
    }

    void Update()
    {
        Position = transform.position;
        Adjust = new Vector3(0f, AdjustY, 0f);
        Position += Adjust;
                
        if (Physics.Raycast(Position, transform.forward, out hit, RayDistance))
        {
            if (hit.transform.tag == "Apple")
            {
                CanSeePickUp = true;
                if (Input.GetKeyDown(KeyCode.E) && SaveScript.Apples < 4)
                {
                    Player.Play();
                    Destroy(hit.transform.gameObject);
                    SaveScript.Apples += 1;
                }
            }else if (hit.transform.tag == "Battery")
            {
                CanSeePickUp = true;
                if (Input.GetKeyDown(KeyCode.E) && SaveScript.Batteries < 4)
                {
                    Player.Play();
                    Destroy(hit.transform.gameObject);
                    SaveScript.Batteries += 1;
                }
            }else if (hit.transform.tag == "Knife")
            {
                CanSeePickUp = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Player.Play();
                    Destroy(hit.transform.gameObject);
                    SaveScript.Knife = true;
                }
                
            }
            else if (hit.transform.tag == "Bat")
            {
                CanSeePickUp = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SaveScript.Bat = true;
                    Player.Play();
                    Destroy(hit.transform.gameObject);
                }
                
            }
            else if (hit.transform.tag == "Crossbow")
            {
                CanSeePickUp = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SaveScript.Crossbow = true;
                    Player.Play();
                    Destroy(hit.transform.gameObject);
                }
                
            }
            else if (hit.transform.tag == "Axe")
            {
                CanSeePickUp = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SaveScript.Axe = true;
                    Player.Play();
                    Destroy(hit.transform.gameObject);
                }
                
            }
            else if (hit.transform.tag == "Pistol")
            {
                CanSeePickUp = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SaveScript.Pistol = true;
                    Player.Play();
                    Destroy(hit.transform.gameObject);
                }
                
            }
            else if (hit.transform.tag == "Ammo")
            {
                CanSeePickUp = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SaveScript.Ammo += 1;
                    Player.Play();
                    Destroy(hit.transform.gameObject);
                }
            }
            else if (hit.transform.tag == "Arrow")
            {
                CanSeePickUp = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SaveScript.Arrow = 1;
                    Player.Play();
                    Destroy(hit.transform.gameObject);
                }
            }
            else if (hit.transform.tag == "HouseKey")
            {
                CanSeePickUp = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SaveScript.HouseKey = true;
                    Player.Play();
                    Destroy(hit.transform.gameObject);
                }
            }
            else if (hit.transform.tag == "CabinKey")
            {
                CanSeePickUp = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SaveScript.CabinKey = true;
                    Player.Play();
                    Destroy(hit.transform.gameObject);
                }
            }
            else if (hit.transform.tag == "RoomKey")
            {
                CanSeePickUp = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SaveScript.RoomKey = true;
                    Player.Play();
                    Destroy(hit.transform.gameObject);
                }
            }
            else
            {
                CanSeePickUp = false;
            }

            if (CanSeePickUp == true)
            {
                PickUpMessage.gameObject.SetActive(true);
                RayDistance = 1000.0f;
            }
            else
            {
                PickUpMessage.gameObject.SetActive(false);
                RayDistance = distance;
            }
        }
        Debug.DrawRay(transform.position, transform.forward * 4.0f);
    }
}

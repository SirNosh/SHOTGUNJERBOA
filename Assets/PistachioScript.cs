using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PistachioScript : MonoBehaviour
{
    
    public PlayerScript playerRef;

    void Start()
    {
        PlayerScript playerRef = GetComponent<PlayerScript>();
        int Ammo = playerRef.Ammo;
    }

    public Text AmmoCounter;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pistachio"))
        {
            Destroy(other.gameObject);
            playerRef.Ammo++;
            AmmoCounter.text = "Ammo: " + playerRef.Ammo;
        }
    
    }
}
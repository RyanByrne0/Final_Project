using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUp : MonoBehaviour
{

    public bool greenKey = false;
    public bool redKey = false;
    public bool goldKey = false;
    public bool stairs = false;

    public GameObject stairObject;
    public GameObject stairPickup;
    public GameObject Key1;
    public GameObject Key2;
    public GameObject key3;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;

    public int HP = 2;
    public int countdown = 300;


    public Transform Checkpoint;
    public GameObject guard;

    void Start()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("StairPickup"))
        {
            stairs = true;
            stairPickup.SetActive(false);
        }

        if (stairs == true && other.CompareTag("Stairs"))
        {

            stairObject.SetActive(true);
            
        }

        if (other.CompareTag("GreenKey"))
        {

            greenKey = true;
            Key1.SetActive(false);

        }

        if ( other.CompareTag("RedKey"))
        {

            redKey = true;
            Key2.SetActive(false);

        }

        if (other.CompareTag("GoldKey"))
        {

            goldKey = true;
            key3.SetActive(false);
        }

        if (greenKey == true && other.CompareTag("GreenDoor"))
        {
            door1.SetActive(false);
        }

        if (redKey == true && other.CompareTag("RedDoor"))
        {
            door2.SetActive(false);
        }

        if (goldKey == true && other.CompareTag("GoldDoor"))
        {
            door3.SetActive(false);
        }

        if (other.CompareTag("GreenKey"))
        {
            Checkpoint = other.transform;
        }

        if (other.CompareTag("Guard"))
        {
            HP-=1;
            countdown = -200;
            guard = other.gameObject;                
       }

        

     
     
    }



    void Update()
    {
       if(HP <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        countdown++;

       if(countdown <= 0)
        {
            guard.SetActive(false);
        }
       else if(countdown >= 300)
        {
            guard.SetActive(true);
        }
    }
    
}

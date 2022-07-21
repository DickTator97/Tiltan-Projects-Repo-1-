using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //holding the data about the player's health
    [SerializeField] int Health = 5;

    //holding the Data about player's name
   

    string Name = "Sanny";

    // Start is called before the first frame update
    void Start()
    {

        //holding the data about the player's health on start app 

        int Saved_Health = PlayerPrefs.GetInt("Health");


        // returning the health value on start as long as it's greater than 0
        if (Saved_Health > 0)
        {
            Health = Saved_Health;


        }

        string Saved_Name = PlayerPrefs.GetString("Name");

        if (Saved_Name.Length > 0)
        {
            Name = Saved_Name;
        }
        Debug.Log(Name);
    }


    // Update is called once per frame
    void Update()
    {



    }
    private void OnDestroy()
    {
        //prints to the console the player current health on exit application
        PlayerPrefs.SetInt("Health", Health);

        //prints to the console the player's name on exit application
        PlayerPrefs.SetString("Name", Name);


    }
}


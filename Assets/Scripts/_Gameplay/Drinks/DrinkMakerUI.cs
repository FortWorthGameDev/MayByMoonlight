﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinkMakerUI : MonoBehaviour {

    public GameObject DrinkToDisplay;

    public Text LaneValue;

    //keeps bucks score
    //public Text myBucks;
    //public DrinkScore drinkScore;
    
    IMixedDrink theDrink;
    Drink2DSprite drinkSprite;

	// Use this for initialization
	void Start () {
        if(DrinkToDisplay != null)
        {
            //drinkScore = gameObject.GetComponent<DrinkScore>();
            theDrink = DrinkToDisplay.GetComponent<IMixedDrink>();
            drinkSprite = transform.root.GetComponentInChildren<Drink2DSprite>();

            if (theDrink != null)
            {
                if (drinkSprite != null)
                {
                    return;
                }
                Debug.Log("Could not find Drink2DSprite attached to GameObject " + transform.root.name);
            }
        }
        Debug.Log("Could not find IMixedDrink implemented on DrinkToDisplay GameObject.  Can not display.");



	}
	
	// Update is called once per frame
	void Update () 
    {
        //myBucks.text = drinkScore.Bucks.ToString();
        drinkSprite.UpdateImage(theDrink);
        LaneValue.text = theDrink.Lane.ToString();
        
	}
}

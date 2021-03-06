﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink : MonoBehaviour, IMixedDrink
{
    public int LaneValue = 0;
    public float WhiskeyValue = 0f;
    public float VodkaValue = 0f;
    public float RumValue = 0f;
    public float SodaValue = 0f;
    public float CokeValue = 0f;
    public float VermouthValue = 0f;
    public Garnish TypeOfGarnish = Garnish.Lime;
    public bool IsJustWaterValue = false;

    // IMixedDrink interface ---------------------------------
    public float Whiskey { get { return WhiskeyValue; } set { WhiskeyValue = value; } }
    public float Rum { get { return RumValue; } set { RumValue = value; } }
    public float Vodka { get { return VodkaValue; } set { VodkaValue = value; } }
    public float Soda { get { return SodaValue; } set { SodaValue = value; } }
    public float Coke { get { return CokeValue; } set { CokeValue = value; } }
    public float Vermouth { get { return VermouthValue; } set { VermouthValue = value; } }
    public Garnish TheGarnish { get { return TypeOfGarnish; } set { TypeOfGarnish = value; } }
    public bool IsJustWater { get { return IsJustWaterValue; } set { IsJustWaterValue = value; } }
    public int Lane { get { return LaneValue; } set { LaneValue = value; } }
    //----------------------------------------------------------

    void Start () {
        if (IsJustWaterValue)
        {
            // Debug.Log("Lane: " + LaneValue + ". I am just water");
            return;
        }
        // Debug.Log("Down Lane: " + LaneValue + ". I am a drink of type (Vodka, Whiskey, Rum | Coke, Soda, Vermouth | Garnish): {" +
        //           VodkaValue + ", " +
        //           WhiskeyValue + ", " +
        //           RumValue + " | " +
        //           CokeValue + ", " +
        //           SodaValue + ", " +
        //           VermouthValue + " | " +
        //           TypeOfGarnish +
        //           "}");
	}
}
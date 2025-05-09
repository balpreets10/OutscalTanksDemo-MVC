using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner TankSpawner;

    public void SelectGreenTank()
    {
        TankSpawner.CreateTank(TankTypes.GreenTank);
        gameObject.SetActive(false);
    }

    public void SelectRedTank()
    {
        TankSpawner.CreateTank(TankTypes.RedTank);
        gameObject.SetActive(false);
    }

    public void SelectBlueTank()
    {
        TankSpawner.CreateTank(TankTypes.BlueTank);
        gameObject.SetActive(false);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{

    public TankView TankView;

    public Material materialRed;

    public Material materialGreen;
    // Start is called before the first frame update
    void Start()
    {
       CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(30,80);
        TankController tankController = new TankController(tankModel, TankView,materialRed);
    }


}
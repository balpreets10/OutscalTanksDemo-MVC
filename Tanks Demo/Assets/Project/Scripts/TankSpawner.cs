using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{


    public TankView TankView;

    public Material materialRed;

    public List<Tank> TankList;
    // Start is called before the first frame update
    void Start()
    {
       CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(TankList[0].movementSpeed, TankList[0].rotationSpeed, TankList[0].TankTypes,
            TankList[0].color);
        TankController tankController = new TankController(tankModel, TankView,materialRed);
    }


}
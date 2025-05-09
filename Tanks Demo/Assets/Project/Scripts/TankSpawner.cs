using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{


    public TankView TankView;
    public List<Tank> TankList;

    public TankTypes TankTypes;
    // Start is called before the first frame update
    void Start()
    {
       CreateTank();
    }

    private void CreateTank()
    {
        Tank? selectedTank = (from tank in TankList
            where tank.TankTypes == TankTypes
            select tank).FirstOrDefault();

        TankModel tankModel = new TankModel(selectedTank.movementSpeed, selectedTank.rotationSpeed, selectedTank.TankTypes,
            selectedTank.color);
        TankController tankController = new TankController(tankModel, TankView);
    }


}
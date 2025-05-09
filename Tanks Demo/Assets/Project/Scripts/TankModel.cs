using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class TankModel
{
    private TankController _tankController;

    public float movementSpeed;
    public float rotationSpeed;
    public TankTypes tankTypes;
    public Material color;

    public TankModel(float movementSpeed, float rotationSpeed, TankTypes tankTypes, Material color)
    {
        this.movementSpeed = movementSpeed;
        this.rotationSpeed = rotationSpeed;
        this.tankTypes = tankTypes;
        this.color = color;
    }


    public float GetMovementSpeed()
    {
        return movementSpeed;
    }

    public float GetRotationSpeed()
    {
        return rotationSpeed;
    }
    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;
    }
}
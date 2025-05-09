using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class TankModel
{
    private TankController _tankController;

    public float movementSpeed;
    public float rotationSpeed;

    public TankModel(float movementSpeed, float rotationSpeed)
    {
        this.movementSpeed = movementSpeed;
        this.rotationSpeed = rotationSpeed;
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
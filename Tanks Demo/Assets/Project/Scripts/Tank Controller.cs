using UnityEngine;

public class TankController
{
    private readonly TankModel _tankModel;
    private readonly TankView _tankView;


    private readonly Rigidbody _rigidbody;


    public TankController(TankModel tankModel, TankView tankView)
    {
        Debug.Log("Found - " + tankModel.tankTypes);
        _tankView = Object.Instantiate(tankView);
        _tankView.SetTankController(this);
        _rigidbody = _tankView.GetRigidbody();
        _tankModel = tankModel;
        _tankModel.SetTankController(this);
        tankView.SetColor(_tankModel.color);

    }

    public void Move(float movement, float movementSpeed)
    {
        _rigidbody.velocity = _tankView.transform.forward * (movement * movementSpeed);
    }

    public void Rotate(float rotate, float rotateSpeed)
    {
        Vector3 vector3 = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector3 * Time.deltaTime);
        _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return _tankModel;
    }
}
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController _tankController;
    public Rigidbody Rigidbody;

    public   List<MeshRenderer> _renderers = new ();

    private float movement;
    private float rotation;
    // Start is called before the first frame update
    void Start()
    {

        GameObject camera = GameObject.Find(("Main Camera"));
        camera.transform.SetParent(transform);
        camera.transform.position = new Vector3(0, 6, -6.5f);
        camera.transform.rotation = Quaternion.Euler(17f,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(movement!=0)
            _tankController.Move(movement,_tankController.GetTankModel().GetMovementSpeed());
        if(rotation!=0)
            _tankController.Rotate(rotation,_tankController.GetTankModel().GetRotationSpeed());
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;
    }

    public void SetColor(Material material)
    {
        foreach (MeshRenderer renderer1 in _renderers)
        {
            renderer1.material = material;
        }

    }

    public Rigidbody GetRigidbody()
    {
        return Rigidbody;
    }
}
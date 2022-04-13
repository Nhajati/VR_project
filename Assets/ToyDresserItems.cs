using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyDresserItems : MonoBehaviour
{
    [SerializeField]
    private GameObject truck1;
    [SerializeField]
    private GameObject truck2;
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private GameObject toyCamera;
    [SerializeField]
    private GameObject waterCan;
    [SerializeField]
    private GameObject truckCase;
    [SerializeField]
    private GameObject waterCanCase;
    [SerializeField]
    private GameObject CameraCase;

    IGS520b.starter.SampleGame.GameManager gameManager;
    public GameObject myGameManager;

    [Tooltip("Points scored by touching this object.")]
    public float points = 10;


    // Start is called before the first frame update
    void Start()
    {
        // gameManager = new IGS520b.starter.SampleGame.GameManager;
        // gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager = myGameManager.GetComponent<IGS520b.starter.SampleGame.GameManager>();
        
        // Make sure non of the colliders in child objects are active
        foreach (Collider collider in GetComponentsInChildren<Collider>())
        {
           collider.enabled = false;
        }

        // Make sure the root collider is a trigger and enabled
        Collider rootCollider = GetComponent<Collider>();
        rootCollider.enabled = true;
        rootCollider.isTrigger = true;
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "ToyTruck1"){
            // truckCase.transform.position = new Vector3(0.0f, 0.0f, 3.7f);
            Destroy(truck1.GetComponent<OVRGrabbable>());
            Destroy(truck1.GetComponent<Rigidbody>());
            Destroy(col);
            // truck1.transform.position = new Vector3(7.17f, 0.7f, -1.23f);
            truck1.transform.position = new Vector3(7.5f, 0.7f, -1.23f);
            truck1.transform.rotation = Quaternion.Euler(0, 73, 0);
        }
        else if(col.gameObject.name == "ToyTruck2"){
            // truckCase.transform.position = new Vector3(0.0f, 0.0f, 3.7f);
            Destroy(truck2.GetComponent<OVRGrabbable>());
            Destroy(truck2.GetComponent<Rigidbody>());
            Destroy(col);
            // truck2.transform.position = new Vector3(7.19f, 0.7f, -1.05f);
            truck2.transform.position = new Vector3(7.5f, 0.7f, -1.05f);
            truck2.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if(col.gameObject.name == "ToyWaterCan"){
            // Destroy(waterCanCase.GetComponent<Collider>());
            // Destroy(waterCanCase.GetComponent<Rigidbody>());
            // waterCanCase.transform.position = new Vector3(0.0f, 0.0f, 3.7f);
            // Vector3 howmuchtomove = new Vector3(0.0f, 0.0f, 3.7f);
            // waterCanCase.transform.position = waterCanCase.transform.position + howmuchtomove;
            Destroy(waterCan.GetComponent<OVRGrabbable>());
            Destroy(waterCan.GetComponent<Rigidbody>());
            Destroy(col);
            // waterCan.transform.position = new Vector3(7.14f, 0.31f, -1.9f);
            waterCan.transform.position = new Vector3(7.5f, 0.31f, -1.9f);
            waterCan.transform.rotation = Quaternion.Euler(0, 63, 0);
        }
        else if(col.gameObject.name == "ToyCamera"){
            gameManager.AddPointToCounter();
            // CameraCase.transform.position = new Vector3(0.0f, 0.0f, 3.7f);
            Destroy(toyCamera.GetComponent<OVRGrabbable>());
            Destroy(toyCamera.GetComponent<Rigidbody>());
            Destroy(col);
            // toyCamera.transform.position = new Vector3(7.18f, 0.74f, -2.6f);
            toyCamera.transform.position = new Vector3(7.5f, 0.74f, -2.6f);
            toyCamera.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if(col.gameObject.name == "Ball"){
            Destroy(ball.GetComponent<OVRGrabbable>());
            Destroy(ball.GetComponent<Rigidbody>());
            Destroy(col);
            ball.transform.position = new Vector3(7.65f, 1.48f, -2.43f);
            ball.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

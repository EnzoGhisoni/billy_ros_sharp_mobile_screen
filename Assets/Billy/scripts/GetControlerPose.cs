using UnityEngine;
using System.Collections;
using Valve.VR;


public class GetControlerPose : MonoBehaviour
{
    // Declaration of variables for the headset
    public GameObject controler;
    private GameObject cube;

    // Declaration of variable which will be published
    private Vector3 previousPosition = Vector3.zero;
    private Quaternion previousRotation = Quaternion.identity;
    void Start()
    {
        //Initialize the Cube
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

    }

    // Update is called once per frame
    void Update()
    {
        // Get the pose of the headset

        cube.transform.position = new Vector3(controler.transform.position.x, controler.transform.position.y, controler.transform.position.z);
        cube.transform.rotation = new Quaternion(controler.transform.rotation.x, controler.transform.rotation.y, controler.transform.rotation.z, controler.transform.rotation.w);
        print(cube.transform.rotation.eulerAngles);



    }


}
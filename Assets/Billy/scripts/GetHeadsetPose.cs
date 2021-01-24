using UnityEngine;
using System.Collections;
using Valve.VR;


public class GetHeadsetPose : MonoBehaviour
{
    // Declaration of variables for the headset
    public GameObject headset;
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

        cube.transform.position = new Vector3(headset.transform.position.x, headset.transform.position.y, headset.transform.position.z);
        cube.transform.rotation = new Quaternion(headset.transform.rotation.x, headset.transform.rotation.y, headset.transform.rotation.z, headset.transform.rotation.w);
        print(cube.transform.rotation.eulerAngles);



    }

    
}
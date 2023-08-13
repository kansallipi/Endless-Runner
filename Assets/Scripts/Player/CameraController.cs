using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target; //player transform
    private Vector3 offset; //offset btw player and camera

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - target.position;//initialise offset
    }

    void LateUpdate()//camera will follow player
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, offset.z + target.position.z);
        transform.position = Vector3.Lerp(transform.position, newPosition, 0.6f);//go from transformed to new position
    }
}

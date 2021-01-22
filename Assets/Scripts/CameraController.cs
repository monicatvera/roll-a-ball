using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    // LateUpdate after every other update
    void LateUpdate()
    {
        //makes the camera follow the position of the player (but not rotation)
        transform.position = player.transform.position + offset;
    }
}

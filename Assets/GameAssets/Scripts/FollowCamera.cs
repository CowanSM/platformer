using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

    public GameObject player;
    public Vector3 speed = new Vector3(10f, 10f, 10f);
    Transform myTransform;
    Transform playerTransform;
    bool bAtMaxDistance = false;


    void Update ()
    {
        SetCameraPosition();
    }

    void OnEnable()
    {
        playerTransform = player.transform;
        myTransform = transform;
    }

    void SetCameraPosition()
    {
        int player = Mathf.FloorToInt(playerTransform.localPosition.x);
        int camera = Mathf.FloorToInt(myTransform.localPosition.x);

        this.transform.localPosition = new Vector3(playerTransform.localPosition.x, myTransform.localPosition.y, myTransform.localPosition.z);
    }
}

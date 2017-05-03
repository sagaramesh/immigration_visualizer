using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour
{
    private GameObject playerHead;
    private Transform playerTransform;

    void Start() {

        playerHead = GameObject.FindGameObjectWithTag("MainCamera");
        playerTransform = playerHead.transform;
    }

    void Update()
    {
        //transform.LookAt(Vector3.zero);
        transform.LookAt(playerTransform);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform carToFollow;

    void LateUpdate()
    {
        transform.position = new Vector3(carToFollow.position.x, carToFollow.position.y, transform.position.z);
    }
}

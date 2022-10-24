using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    [Tooltip("The target to be tracked.")] //The target to be tracked
    [SerializeField] private Transform target;
    [Tooltip("The offset position from the target.")]//The offset position from the target
    [SerializeField] private Vector3 positionOffset;

    void LateUpdate()
    {
        transform.position = target.position + positionOffset; //Minimap position equals the targets position and the target offsets position
    }
    // the minimap camera's position follows the player based on the player's current target position and it's offset position
}

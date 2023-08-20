using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumps : MonoBehaviour
{
    //[SerializeField] private ThirdPersonController thirdPersonController;
    [SerializeField] private float jumpForce;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ThirdPersonController>()._verticalVelocity = Mathf.Sqrt(jumpForce * -2f * -15);
        //thirdPersonController._verticalVelocity = Mathf.Sqrt(jumpForce * -2f * -15);
    }
}

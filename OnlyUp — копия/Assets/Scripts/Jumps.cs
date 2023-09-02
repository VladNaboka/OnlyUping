using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumps : MonoBehaviour
{
    //[SerializeField] private ThirdPersonController thirdPersonController;
    [SerializeField] private float jumpForce;
    [SerializeField] private AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ThirdPersonController>()._verticalVelocity = Mathf.Sqrt(jumpForce * -2f * -15);
        audioSource.Play();

        //thirdPersonController._verticalVelocity = Mathf.Sqrt(jumpForce * -2f * -15);
    }
}

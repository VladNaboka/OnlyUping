using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Ladder : MonoBehaviour
{
    private StarterAssetsInputs _input;
    //[SerializeField] private ThirdPersonController thirdPersonController;
    private void Start()
    {
        _input = GameObject.Find("PlayerArmature").GetComponent<StarterAssetsInputs>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (_input.move != Vector2.zero)
        {
            other.GetComponent<ThirdPersonController>()._verticalVelocity = Mathf.Sqrt(1 * -2f * -15);
            //thirdPersonController._verticalVelocity = Mathf.Sqrt(1 * -2f * -15);
        }
    }
}

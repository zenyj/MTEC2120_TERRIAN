using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class Spawn : MonoBehaviour
{
    public GameObject cube;


    public void OnFire(InputAction.CallbackContext context)
    {
        Instantiate(cube, transform.position, Quaternion.identity);

    }
}

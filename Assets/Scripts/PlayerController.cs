using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject dogPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootDog();
        }
    }

    private void ShootDog()
    {
        Instantiate(dogPrefab, transform.position, Quaternion.Euler(0, -90, 0));
    }
}

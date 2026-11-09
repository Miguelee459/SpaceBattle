using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    [SerializeField] private float CoolDownSeconds;
    bool CanShoot = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    IEnumerator EnableShoot()
    {
        yield return new WaitForSeconds(CoolDownSeconds);
        Debug.Log("Ya puedes disparar");
        CanShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && CanShoot)
        {
            Debug.Log("Disparo");
            CanShoot = false;
            //Llamar a la corutina que volvera a activar el disparo
            StartCoroutine(EnableShoot());
        }
    }

   
}
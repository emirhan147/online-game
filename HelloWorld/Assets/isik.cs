using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isik : MonoBehaviour
{
    // Start is called before the first frame update
    RaycastHit nesne;
    public GameObject hedef;
    public float Health;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Shoot();
            if (Health == 0)
            {
                Destroy(hedef);
            }
        }
    }
    void Shoot()
    {
        
            if (Physics.Raycast(transform.position, transform.forward, out nesne, 10))
            {
            print("shooted");
            
            Health -= 10;
            }

            
        }
        
        
    }


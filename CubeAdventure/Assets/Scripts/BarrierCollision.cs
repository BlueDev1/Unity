using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarrierCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Barrier")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);





        }
        if (collisionInfo.gameObject.tag == "Barrel")
        {

            FindObjectOfType<BarrelExplode>().Explode();

        }
    }
}
    







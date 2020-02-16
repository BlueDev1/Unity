
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTransformReset : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}

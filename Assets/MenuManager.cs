using UnityEngine;
using UnityEngine.SceneManagement;  // To load a scene

public class GameManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Load the menu scene (assuming it's called "MenuScene")
            SceneManager.LoadScene("Menu");
        }
    }
}


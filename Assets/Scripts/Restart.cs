using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public KeyCode PlayAgainKeyboardInput = KeyCode.Escape;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(PlayAgainKeyboardInput))
            SceneManager.LoadScene("MainMenu");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene(0);
    }
}

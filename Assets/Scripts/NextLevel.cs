using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public KeyCode PlayAgainKeyboardInput = KeyCode.Return;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(PlayAgainKeyboardInput))
            SceneManager.LoadScene("MiniGame2");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene(0);
    }
}

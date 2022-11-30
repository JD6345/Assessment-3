using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_bStartGame : MonoBehaviour
{
    //By referencing the Build Settings and putting the first level in the 'Scenes In Build' the script will give the button the function
    //to open the level scene once it has been referenced in Unity
    public int gameStartScene;

    public void StartGame()
    {
        SceneManager.LoadScene(gameStartScene);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{

    [ContextMenu("Load Game")]
    public void OpenGameScene()
    {
        SceneManager.LoadScene(1);
    }
}

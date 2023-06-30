using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GantiScene1(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }
}

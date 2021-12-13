using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_Loader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadInfoScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadPlatform1()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadPlatform2()
    {
        SceneManager.LoadScene(6);
    }
    public void NextInfo()
    {
        SceneManager.LoadScene(2);
    }
    public void Mission1()
    {
        SceneManager.LoadScene(3);
    }

}

using UnityEngine;
using UnityEngine.SceneManagement;

public class DDOL : MonoBehaviour
{
    void Awake()
    {
       Loader.ClockSkip = true;
       Invoke("NewMethod", 0.01f);
    }

    private void NewMethod()
    {
        DontDestroyOnLoad(gameObject);
        Loader.Load(Loader.Scene.MainMenu);
    }
}

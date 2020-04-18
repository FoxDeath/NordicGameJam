using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class RestartManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI restartText;
    [SerializeField] string text;

    private void Start() {
        StartCoroutine(TypeSentence(text));
    }
    IEnumerator TypeSentence(string sentence)
    {
        restartText.text = "";

        foreach(char letter in sentence.ToCharArray())
        {
            restartText.text += letter;

            if(letter.Equals('.') || letter.Equals('?') || letter.Equals('!'))
            {
                yield return new WaitForSeconds(0.5f);
            }
            else
            {
                yield return new WaitForSeconds(0.03f);

            }
        }
    }

    public void TryAgain()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        switch(sceneName)
        {
            case "CatchFruit":
                Loader.Load(Loader.Scene.CatchFruit);
            break;

            case "CrossRoad":
                Loader.Load(Loader.Scene.CrossRoad);
            break;

            case "OfficePacMan":
                Loader.Load(Loader.Scene.OfficePacMan);
            break;

            case "CarLabyrinth":
                Loader.Load(Loader.Scene.CarLabytinth);
            break;
        }
    }

    public void GiveUp()
    {
        Loader.Load(Loader.Scene.MainMenu);
    }
}

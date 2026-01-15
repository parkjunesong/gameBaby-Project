using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelect : MonoBehaviour
{
    public void SetMap()
    {
        SceneManager.LoadScene("Game Scene");
    }
}

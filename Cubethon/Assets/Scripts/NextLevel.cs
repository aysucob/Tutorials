using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void LoadNextLevel()
    {SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);}
    // Start is called before the first frame update
}

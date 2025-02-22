using UnityEngine;
using UnityEngine.SceneManagement;
public class LoserScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Game over Screen");
    }
}

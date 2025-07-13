using UnityEngine;
using UnityEngine.SceneManagement;

namespace TitleScreen
{
    public class LoadGame : MonoBehaviour
    {
        private bool hasLoaded = false; // Prevent multiple loads

        void Update()
        {
            if (!hasLoaded && (Input.anyKeyDown || Input.GetMouseButtonDown(0)))
                {
                hasLoaded = true;
                SceneManager.LoadScene("Astrosurvivor");
            }
        }
    }
}
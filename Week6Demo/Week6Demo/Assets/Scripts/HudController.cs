using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Andrea
{
    public class HudController : MonoBehaviour
    {
        public Image progressBar;
        public PlayerController player;

        private static HudController current;

        void Start()
        {
            /// Persistent Object

            if(current == null)
            {
            current = this;
            DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if(player != null)
            {
                float p = player.GetPercentXP();
                progressBar.fillAmount = p;
            }

           /* float p = Inventory.singleton.totalXP / Inventory.singleton.nextLevelXP;
            progressBar.fillAmount = p;*/
        }

        public void LoadNextScene()
        {
            SceneManager.LoadScene("Scene02", LoadSceneMode.Single);
        }
        public void LoadFirstScene()
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
}
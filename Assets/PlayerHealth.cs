using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public HealtBar healtBar;
    public GameObject blast;

    int maxHealth = 100;
    int currentHealth;
	
	void Start () {

        currentHealth = maxHealth;
        healtBar.SetMaxHealth(maxHealth);
	}
	

	void Update () {

        if (currentHealth <= 0)
        {
            GameObject tempBlast = Instantiate(Resources.Load("BigExplosionEffect1"), blast.transform.position, transform.rotation) as GameObject;

            Destroy(tempBlast, 2f);

            Invoke("gameOver", 2f);

       }

	}

    void gameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnCollisionEnter(Collision collision)
    {
      
            currentHealth -= 2;
            healtBar.SetHealth(currentHealth);
     
    }
}

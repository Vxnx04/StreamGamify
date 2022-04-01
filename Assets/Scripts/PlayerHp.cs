using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHp : MonoBehaviour
{

    public int playermaxHp;
    public int currentHp;
    public Image[] hpImage;

    public Sprite fullhearth;

    public Sprite emptyhearth;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playermaxHp > currentHp)
        {
            playermaxHp = currentHp;
        }

        for (int i = 0; i < hpImage.Length; i++)
        {
            if (i < playermaxHp)
            {
                hpImage[i].sprite = fullhearth;
            }
            else
            {
                hpImage[i].sprite = emptyhearth;
            }

            if (i < currentHp)
            {
                hpImage[i].enabled = true;
                
            }
            else
            {
                hpImage[i].enabled = false;
                
            }

        }
        
        if(playermaxHp <= 0)
        {gameObject.SetActive(false);
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
        }
        
    }
    

    public void HurtPlayer(int damageToGive)
    {
        playermaxHp -= damageToGive; 
        
    }
    
    
}

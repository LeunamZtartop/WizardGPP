using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public static int score;
    public TMP_text Health;
    public TMP_text text2;
    public Image bar;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Wizard>().mana;
    }

    // Update is called once per frame
    void Update()
    {
        //abgeschrieben
        textHealth.text = "Health: " + (int) PlayerPrefs.health + "/100";
        float healthPercentage = player.health /100;
        bar.fillAmount = healthPercentage;

        textMana.text = "Mana: " + (int) PlayerPrefs.mana + "/100";
        float manaPercentage = PlayerPrefs.GetMana() /100f;
        bar2.fillAmount = manaPercentage;

        //eigener shit
        text1.text = "Score: " + score;
        text2.text = "Mana: " + GameObject.FindWithTag("Player").GetComponent<Wizard>().mana;
        bar.rectTransform.localScale = new Vector3(1, 1, 1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    int tahmin;
    int min = 1, max = 100;
    bool startGame = false;
    bool finishGame = false;
    // Start is called before the first frame update
    void Start()
    {
        print("Oyuna baþlamak ister misiniz? (E/H)");
    }

    // Update is called once per frame
    void Update()
    {
        if (!startGame)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Baþlayalým. Aklýndan 1-100 arasý bi sayý tut ve Enter tuþuna bas!");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("Yat aþþa");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                startGame = true;
                Kontrol();
            }
        }
        else if(!finishGame)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                min = tahmin;
                Kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                max = tahmin;
                Kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Aklýndaki sayýyý bulduk !!!");
                finishGame = true;
            }
        }
    }

    void Kontrol()
    {
        tahmin = (min + max) / 2;
        print("Aklýndan tuttugun sayi " + tahmin + " mi ? Daha büyük ise yukarý daha küçük ise aþaðý tuþuna bas!");
    }
}

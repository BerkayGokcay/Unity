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
        print("Oyuna ba�lamak ister misiniz? (E/H)");
    }

    // Update is called once per frame
    void Update()
    {
        if (!startGame)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Ba�layal�m. Akl�ndan 1-100 aras� bi say� tut ve Enter tu�una bas!");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("Yat a��a");
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
                print("Akl�ndaki say�y� bulduk !!!");
                finishGame = true;
            }
        }
    }

    void Kontrol()
    {
        tahmin = (min + max) / 2;
        print("Akl�ndan tuttugun sayi " + tahmin + " mi ? Daha b�y�k ise yukar� daha k���k ise a�a�� tu�una bas!");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamekontrol : MonoBehaviour
{


    float saglik;
    public Image healtbar;
    public GameObject engelobjem;
    public GameObject NavMeshObje;
    public Text kalansayiText;
    public int kalansayiDeger;
    public Text NavMeshkalansayiText;
    public int NavMeshkalansayiDeger;
    public GameObject[] noktalar;
    public Button[] butonlar;
    public Button[] Navbutonlar;
    public GameObject gameOverPanel;


    void Start()
    {
        saglik = 100;
        kalansayiDeger = 30;
        kalansayiText.text = kalansayiDeger.ToString();

        NavMeshkalansayiDeger = 5;
        NavMeshkalansayiText.text = NavMeshkalansayiDeger.ToString();
    }

    
    void ButonlarKontrol()
    {
        if (kalansayiDeger == 0)
        {
            foreach (var item in butonlar)
            {
                item.interactable = false;
            }
        }
    }
    void NavButonlarKontrol()
    {
        if (NavMeshkalansayiDeger == 0)
        {
            foreach (var item in Navbutonlar)
            {
                item.interactable = false;
            }
        }
    }

    public void Noktalar(int indisler)
    {

        //noktalar[indisler].GetComponent<MeshRenderer>().enabled = false; 

        Instantiate(engelobjem, noktalar[indisler].transform.position, Quaternion.identity);
        kalansayiDeger--;
        kalansayiText.text = kalansayiDeger.ToString();
        ButonlarKontrol();

    }

    public void NavMeshNoktalar(int indisler)
    {


        Instantiate(NavMeshObje, noktalar[indisler].transform.position, Quaternion.identity);
        NavMeshkalansayiDeger--;
        NavMeshkalansayiText.text = NavMeshkalansayiDeger.ToString();
        NavButonlarKontrol();
    }

    public void CanDusur(float darbe)
    {

        saglik -= darbe;

        healtbar.fillAmount = saglik / 100;
        Cankontrol();

    }
    void Cankontrol()
    {
        if (saglik <= 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }


}

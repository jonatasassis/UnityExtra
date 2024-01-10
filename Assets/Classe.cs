using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Classe : MonoBehaviour
{
    public List<int> listaInt;
    public TMPro.TextMeshProUGUI intText;
    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SortearInt()
    {
        listaInt.RandomizarItem();
        intText.text = "" + listaInt.RandomizarItem();
       
    }
}

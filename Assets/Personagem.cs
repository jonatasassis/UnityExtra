using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Personagem : MonoBehaviour
{

   
#if UNITY_EDITOR

    [MenuItem("Personagem/AtivarCriacao")]
    //personagem so poderá ser criado quando a variavel "criar" =true;
    public static void Teste()
    {
        criar = true;
       

    }
#endif

    public int tipo;
    public int Level = 3;
    public int ataque = 100;
    public int defesa = 20;

    public GameObject playerPrefab;
    public static bool criar=false;
  
    public static int idPersonagem;
    public int AtaqueTotal
    {
        get { return (Level % 100) + ataque; }
    }

  
    public void CriarPersonagem()
    {
        if (criar)
        {
            Instantiate(playerPrefab, new Vector3(0, -4, 14), Quaternion.identity);
            criar = false;
        }
        
    }

    


}

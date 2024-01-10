using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Personagem))]
public class EditorPersonagem : Editor
{
    public override void OnInspectorGUI()
    {

        EditorGUILayout.HelpBox("Informacoes do Personagem", MessageType.Info);
        //base.OnInspectorGUI();
        Personagem meuPersonagem = (Personagem)target;

        meuPersonagem.tipo = EditorGUILayout.IntField("Classe do persongem", meuPersonagem.tipo);
        meuPersonagem.Level = EditorGUILayout.IntField("level do persongem", meuPersonagem.Level);
        meuPersonagem.ataque = EditorGUILayout.IntField("Ataque do persongem",meuPersonagem.ataque);
        meuPersonagem.defesa = EditorGUILayout.IntField("defesa do persongem", meuPersonagem.defesa);
        meuPersonagem.playerPrefab =(GameObject) EditorGUILayout.ObjectField("Player",meuPersonagem.playerPrefab,typeof(GameObject),true);
      

        EditorGUILayout.LabelField("Critico do personagem", meuPersonagem.AtaqueTotal.ToString());

       
        switch (meuPersonagem.tipo)
        {
            case 0:
             EditorGUILayout.HelpBox("Seu personagem está na classe base", MessageType.Info);
             break;

            case 1:
                EditorGUILayout.HelpBox("Seu personagem é Espadachim", MessageType.Info);
                break;

            case 2:
                EditorGUILayout.HelpBox("Seu personagem é Mago", MessageType.Info);
                break;

            case 3:
                EditorGUILayout.HelpBox("Seu personagem é Clerigo", MessageType.Info);
                break;

            case 4:
                EditorGUILayout.HelpBox("Seu personagem é Ladino ", MessageType.Info);
                break;

            default:
                EditorGUILayout.HelpBox("Classe nao consta ", MessageType.Info);
                break;
        }

        GUI.color = Color.yellow;
        // cria persongem se "criar" for true
        if (GUILayout.Button("Criar Player"))
        {
            meuPersonagem.CriarPersonagem();
        }

      





    }
}

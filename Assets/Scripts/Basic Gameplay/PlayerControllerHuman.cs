using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 10.0f;
    public float horizontalInput;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;

    void Start()
    {
        Debug.Log("Oyuncu Script'i (NewBehaviourScript) ÇALIÞTI!");
    }

    void Update()
    {
        // ... (Sýnýr ve Hareket kodlarýn burada, onlara dokunma) ...
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);


        // ----- 3. GÖREV: FÝNAL HATA AYIKLAMA -----
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("SPACE TUÞU ALGILANDI!");

            Vector3 spawnPos = transform.position + new Vector3(0, 0, 1);

            // 1. Pizzayý yarat VE O YARATILAN KLONU BÝR DEÐÝÞKENDE SAKLA
            GameObject yeniPizzaKlonu = Instantiate(projectilePrefab, spawnPos, projectilePrefab.transform.rotation);

            // 2. SORGULA: O yarattýðým klon GERÇEK MÝ (var mý), yoksa BOÞ (null) mu?
            if (yeniPizzaKlonu != null)
            {
                // Eðer "null" deðilse, klon yaratýldý demektir.
                Debug.Log("BAÞARIYLA YARATILDI! Adý: " + yeniPizzaKlonu.name);
            }
            else
            {
                // Eðer "null" ise, bu "Suçlu 1"in (Hayalet Yuva) kanýtýdýr.
                Debug.LogError("!!! HATA: YARATMA BAÞARISIZ! 'Projectile Prefab' yuvasý Inspector'da BOÞ (None) veya BOZUK!");
            }
        }
    }
}

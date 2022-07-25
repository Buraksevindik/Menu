using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMusic : MonoBehaviour
{
    public AudioSource Audio;
    public static BgMusic BgInstance;
    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
    private void Awake()
    {
        if (BgInstance != null && BgInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        BgInstance = this;
        //efektin/m�zi�in sahne ge�i�lerinde durmamas�n�,yok olmamas�n� sa�lar
        DontDestroyOnLoad(this);
    }
}

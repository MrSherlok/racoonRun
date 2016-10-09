using UnityEngine;
using System.Collections;

public class GribLogic : MonoBehaviour
{
    public bool itsGoodGrib;
    float randomPrize;

    void Start()
    {

        this.GetComponent<EnemyShotScript>().damage = 0;

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            GetComponent<ParticleSystem>().Play();
            if (itsGoodGrib)
            {
                randomPrize = Random.Range(0f, 5f);
                if (randomPrize >= 0f && randomPrize <= 1.1f)
                {
                    GetPrize(1);
                }
                if (randomPrize >= 1.2f && randomPrize <= 2.4f)
                {
                    GetPrize(2);
                }
                if (randomPrize >= 2.5f && randomPrize <= 3.8f)
                {
                    GetPrize(3);
                }
                if (randomPrize >= 3.9f && randomPrize <= 5f)
                {
                    GetPrize(4);
                }
            }
            if (!itsGoodGrib)
            {
                randomPrize = Random.Range(0f, 5f);
                if (randomPrize >= 0f && randomPrize <= 1.1f)
                {
                    GetPrize(5);
                }
                if (randomPrize >= 1.2f && randomPrize <= 2.4f)
                {
                    GetPrize(6);
                }
                if (randomPrize >= 2.5f && randomPrize <= 3.8f)
                {
                    GetPrize(7);
                }
                if (randomPrize >= 3.9f && randomPrize <= 5f)
                {
                    GetPrize(8);
                }
            }
        }
    }
    void GetPrize(int modificator)
    {
        if (modificator == 1)
        {
            CoinCollect.AddCoin(5);

        }
        //if (modificator == 2) {			
        //}

        if (modificator == 3)
        {

            if (GameObject.Find("Player1").GetComponent<HealthScript>().hp < 6)
            {
                this.GetComponent<EnemyShotScript>().damage = -1;
            }
        }

        if (modificator == 4)
        {
            CoinCollect.AddCoin(3);
        }

        if (modificator == 5)
        {
            CoinCollect.coins -= 3;
        }

        //if (modificator == 6) {
        //}

        if (modificator == 7)
        {

            if (GameObject.Find("Player1").GetComponent<HealthScript>().hp > 1)
            {
                this.GetComponent<EnemyShotScript>().damage = 1;
            }
        }

        if (modificator == 8)
        {
            CoinCollect.coins -= 5;
        }
    }
}

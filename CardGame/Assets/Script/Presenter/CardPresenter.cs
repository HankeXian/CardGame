using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using R3;
using UnityEngine;
using UnityEngine.UI;

public class CardPresenter : MonoBehaviour
{
    [SerializeField]
    private Image cardImage;
    public Card card;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void test()
    {
        card.testValue.Subscribe(test2).AddTo(this.GetCancellationTokenOnDestroy());
    }

    private void test2(int num)
    {
        
    }
}

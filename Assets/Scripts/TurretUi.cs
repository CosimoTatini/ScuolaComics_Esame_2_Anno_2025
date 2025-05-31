 using TMPro;
 using UnityEngine;
 using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour, ISubscriber
{

    private TurretDetailedView turretDetailedView;

    [SerializeField] TurretStatsSO statsSO;
    
   void Start()
    {
       Publisher.Subscribe(this,typeof(TurretMessage));
    }
    public void OnDisableSubscriber()
    {
        Publisher.Unsubscribe(this, typeof(TurretMessage));
    }

    public void OnPublish(IPublisherMessage message)
    {
        if (message is TurretMessage turretMessage)

            turretDetailedView.UpdateView(statsSO);
        }

    }


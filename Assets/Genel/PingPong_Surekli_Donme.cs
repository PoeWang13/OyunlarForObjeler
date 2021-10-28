using UnityEngine;

public class PingPong_Surekli_Donme : MonoBehaviour
{
    [Header("Script Atamaları")]
    [SerializeField] private float beklemeTime = 1;
    [SerializeField] private int pingPongSpeed = 125;
    [SerializeField] private float angleLimit = 90;
    [SerializeField] private Transform goruntu;
    private float angleNext;
    private float angleDirection = 1;
    private float beklemeTimeNext;
    private bool bekle;
    private void Update()
    {
        if (bekle)
        {
            beklemeTimeNext += Time.deltaTime;
            if (beklemeTimeNext > beklemeTime)
            {
                beklemeTimeNext = 0;
                bekle = false;
            }
        }
        else
        {
            angleNext += Time.deltaTime * angleDirection * pingPongSpeed;
            goruntu.localEulerAngles = new Vector3(0, angleNext, 0);
            if (angleDirection == 1)
            {
                if (angleNext >= angleLimit)
                {
                    angleDirection = -1;
                    bekle = true;
                }
            }
            else if (angleDirection == -1)
            {
                if (angleNext < 0)
                {
                    angleDirection = 1;
                    bekle = true;
                }
            }
        }
    }
}
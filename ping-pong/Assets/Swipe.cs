using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
   private bool tap, swipeLeft, swipeRight,swipeUp, swipeDown;
   private bool isDragging= false; 
   private Vector2 startTouch,swipeDelta;
    private void Update()
    {
        tap=swipeLeft=swipeRight=swipeUp=swipeDown=false;

        #region Moblie Inputs
        if(Input.touches.Length>0)
        {
            if(Input.touches[0].phase==TouchPhase.Began)
            {
                tap=true;
                startTouch=Input.touches[0].position;
            }
        }
        else if(Input.touches[0].phase==TouchPhase.Ended || Input.touches[0].phase==TouchPhase.Canceled)
        {
            Reset();
        }
        #endregion
        // swipeDelta=Vector2.zero;
        // if(isDragging)
        // {
            
        // }
    }

    private void Reset()
    {
        startTouch =swipeDelta =Vector2.zero;
    }
   public Vector2 SwipeDelta { get { return swipeDelta; }}
   public bool SwipeLeft { get { return swipeLeft; }}
   public bool SwipeRight { get { return swipeRight; }}
   public bool SwipeUp { get { return swipeUp; }}
   public bool SwipeDown { get { return swipeDown; }}
    public void Test(){
        startTouch =swipeDelta =Vector2.zero;
    }
}

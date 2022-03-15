using UnityEngine;
using UnityEngine.Events;

public class OculusControllerBehaviour : MonoBehaviour
{   
    public UnityEvent RightThumbStickForward = new UnityEvent();
    public UnityEvent RightThumbStickBackward = new UnityEvent();
    public UnityEvent RightThumbStickRight = new UnityEvent();
    public UnityEvent RightThumbStickLeft = new UnityEvent();
    
    public UnityEvent LeftThumbStickForward = new UnityEvent();
    public UnityEvent LeftThumbStickBackward = new UnityEvent();
    public UnityEvent LeftThumbStickRight = new UnityEvent();
    public UnityEvent LeftThumbStickLeft = new UnityEvent();

    public UnityEvent RightThumbStickButton = new UnityEvent();
    public UnityEvent LeftThumbStickButton = new UnityEvent();

    public UnityEvent RightIndexButtonPress = new UnityEvent();
    public UnityEvent RightThumbButtonPress = new UnityEvent();

    public UnityEvent LeftIndexButtonPress = new UnityEvent();
    public UnityEvent LeftThumbButtonPress = new UnityEvent();

    public UnityEvent AButtonPress = new UnityEvent();
    public UnityEvent BButtonPress = new UnityEvent();
    public UnityEvent XButtonPress = new UnityEvent();
    public UnityEvent YButtonPress = new UnityEvent();


    private bool rightThumbStickButtonPressed, leftThumbStickButtonPressed,
        rightIndexButtonPressed, leftIndexButtonPressed,
        rightThumbButtonPressed, leftThumbButtonPressed,
        aButtonPressed, bButtonPressed, xButtonPressed, yButtonPressed;

    void OnEnable()
    {
        rightThumbStickButtonPressed = true;
        leftThumbStickButtonPressed = true;
        rightIndexButtonPressed = true;
        leftIndexButtonPressed = true;
        rightThumbButtonPressed = true;
        leftThumbButtonPressed = true;
        aButtonPressed = true;
        bButtonPressed = true;
        xButtonPressed = true;
        yButtonPressed = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!this.enabled)
        {
            return;
        }

        OVRInput.Update();

        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
        {
            RightThumbStickForward?.Invoke();
        }
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown))
        {
            RightThumbStickBackward?.Invoke();
        }
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
        {
            RightThumbStickRight?.Invoke();
        }
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
        {
            RightThumbStickLeft?.Invoke();
        }

        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp))
        {
            LeftThumbStickForward?.Invoke();
        }
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown))
        {
            LeftThumbStickBackward?.Invoke();
        }
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickRight))
        {
            LeftThumbStickRight?.Invoke();
        }
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickLeft))
        {
            LeftThumbStickLeft?.Invoke();
        }

        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstick))
        {
            if (!rightThumbStickButtonPressed)
            {
                rightThumbStickButtonPressed = true;
                RightThumbStickButton?.Invoke();
            }
        } else {
            rightThumbStickButtonPressed = false;
        }
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick))
        {
            if (!leftThumbStickButtonPressed)
            {
                leftThumbStickButtonPressed = true;
                LeftThumbStickButton?.Invoke();
            }
        }else {
            leftThumbStickButtonPressed = false;
        }

        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            if (!rightIndexButtonPressed)
            {
                rightIndexButtonPressed = true;
                RightIndexButtonPress?.Invoke();
            }
        } else {
            rightIndexButtonPressed = false;
        }
        if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            RightThumbButtonPress?.Invoke();
        }

        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            if (!leftIndexButtonPressed)
            {
                leftIndexButtonPressed = true;
                LeftIndexButtonPress?.Invoke();
            }
        } else {
            leftIndexButtonPressed = false;
        }
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
        {
            if (!leftThumbButtonPressed)
            {
                leftThumbButtonPressed = true;
                LeftThumbButtonPress?.Invoke();
            }
        } else {
            leftThumbButtonPressed = false;
        }
        
        
        if (OVRInput.Get(OVRInput.Button.One))
        {
            if (!aButtonPressed)
            {
                aButtonPressed = true;
                AButtonPress?.Invoke();
            } 
        } else {
            aButtonPressed = false;
        }
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            if (!bButtonPressed)
            {
                bButtonPressed = true;
                BButtonPress?.Invoke();
            }
        } else {
            bButtonPressed = false;
        }
        if (OVRInput.Get(OVRInput.Button.Three))
        {
            if (!xButtonPressed)
            {
                xButtonPressed = true;
                XButtonPress?.Invoke();
            }
        } else {
            xButtonPressed = false;
        }
        if (OVRInput.Get(OVRInput.Button.Four))
        {
            if (!yButtonPressed)
            {
                yButtonPressed = true;
                YButtonPress?.Invoke();
            }
        } else {
            yButtonPressed = false;
        }
    }

    public void ToggleEnabled()
    {
        this.enabled = !this.enabled;
    }

    void FixedUpdate()
    {
        OVRInput.FixedUpdate();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_with_URL : MonoBehaviour
{
    public void OpenFacebook()
    {
        Application.OpenURL("https://www.facebook.com/people/Mohamed-Maher/pfbid0cBe8JjWkYkawLEDHUF5Dy3f2vXxDPBnZ1N7oLpZL66vGhaNnn1oDiWzt7d7gUiXBl/");
    }
    public void OpenTwitter()
    {
        Application.OpenURL("https://twitter.com/?lang=en");
    }
    public void OpenGoogle()
    {
        Application.OpenURL("https://www.google.com/chrome/?brand=YTUH&gclid=CjwKCAiAvdCrBhBREiwAX6-6UowX_kXjiVYXdagb_wEWsLCYE-TAEFrpIpde7KFz0uybYdHrOstV2BoC9VsQAvD_BwE&gclsrc=aw.ds");
    }
}

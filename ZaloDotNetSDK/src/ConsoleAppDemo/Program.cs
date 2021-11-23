using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaloCSharpSDK;
using ZaloDotNetSDK;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleAppDemo
{
    class ZaloToken
    {
        public string access_token { set; get; }
        public string expires_in { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            long appId = 400935361715655638;
            string secretKey = "Cp31r0OxUdbX1UGGDG5z";
            string callbackUrl = "http://zalo.iot.vn/api/notify/zalo/zalo_redirect_uri";

            var appClient = new Zalo3rdAppClient(new ZaloAppInfo(appId, secretKey, callbackUrl));

            //http://zalo.iot.vn/login.html?invitesrc=openapi&utm_source=zalo&utm_medium=zalo&utm_campaign=zalo&zarsrc=30


            //https://oauth.zaloapp.com/v3/auth?app_id=4493888734077794545&redirect_uri=http://zalo.iot.vn/ok.html
            string loginUrl = appClient.getLoginUrl();

            //https://id.zalo.me/account/login?continue=https%3A%2F%2Foauth.zaloapp.com%2Fv3%2Fauth%3Fapp_id%3D4493888734077794545%26redirect_uri%3Dhttp%3A%2F%2Fzalo.iot.vn%2Fok.html
            //https://id.zalo.me/account/login?continue=https://oauth.zaloapp.com/v3/auth?app_id=4493888734077794545&redirect_uri=http://zalo.iot.vn/ok.html

            //http://zalo.iot.vn/ok.html?uid=2119814009048858734&code=la7-NfakZGFoVkLGjYAyM_LKfXJX7Snwk5VS7BKvWMshOUC3_JQ8Nk1LqaIP7iu2Z5AbPDychHF-TSrWxo-h3BHwmbFx8x9tiLoN89Sg_aR5VU4RnYs0Pyzru0_IDwvvuZQ4EyKbpcFLSwOKbrtd5jvGnI3PTC9UXYQp1S1empwK8TnoaI6o4T9usmsFTkiVpNxpADSpcN2TS_fjzYIQKeT3Zqd16ijCXns-JiKKXd-2LffyZLUdCkaVkclyIT44fWdpHhfRbYFEKACSqbjSGQyqB1pbUmDBn4DJ7AOQV7DhQ75hR0GYDLf7DBOdAMITJGSFlKiwSxW45mMD3o1wWG0508y_9mZ71sqAoHXCU9XGZX5lboYh6m&scope=access_profile,access_friends_list,send_msg,push_feed

            long uid = 2119814009048858734;
            string code = "la7-NfakZGFoVkLGjYAyM_LKfXJX7Snwk5VS7BKvWMshOUC3_JQ8Nk1LqaIP7iu2Z5AbPDychHF-TSrWxo-h3BHwmbFx8x9tiLoN89Sg_aR5VU4RnYs0Pyzru0_IDwvvuZQ4EyKbpcFLSwOKbrtd5jvGnI3PTC9UXYQp1S1empwK8TnoaI6o4T9usmsFTkiVpNxpADSpcN2TS_fjzYIQKeT3Zqd16ijCXns-JiKKXd-2LffyZLUdCkaVkclyIT44fWdpHhfRbYFEKACSqbjSGQyqB1pbUmDBn4DJ7AOQV7DhQ75hR0GYDLf7DBOdAMITJGSFlKiwSxW45mMD3o1wWG0508y_9mZ71sqAoHXCU9XGZX5lboYh6m";
            string scope = "access_profile,access_friends_list,send_msg,push_feed";


            // { "expires_in": "3600", "access_token": "
            //4KvSI2BvOYKGIbT4Albc9Xb9LKScupLH61PwRM3yINyr7H1pHQrZGZv8AJfhXtrVKt4tHY-zLMbn26H45Uye9bq1M4GSi05oS0n0SHx0T41aDZfq1z1QM3Gk2K9GdKDZAa0_LMkALKubHXniORjAS39U6cXtedLf44euUdohR5z5THj75vvAQYWt64TnqajOJHWgUIt8G1r1EXGWAEnPFXHTRLfPdHjfFNqeK73EQaXD0GzvBi1l6sitA2OeWHf7IKv8I1UmTtHUV1f27ij894DE2eG6LIZaRYa" }
            //PIn8TtqlNLnaA4DxTIzPNsqhGNXvDGuv06WR7Ki9PpumQH9UU39pU0bI5IzV27aA6mi2G7vsHpGgSpvWRGTGFG9a6MGME7uM3tiQLbaZVGqQ9XyjS7zMR64vJJKGQ2521WvKFX9AI5y34pSw469OOdeREny8Kq5DHmSg5GXsC5mQ3tW62saHGnuQQ2LmMGPKF35H1IL76avHJdmKEaeoDbuiBd0uSqWQN2WjJ0XPRXDVK2rIHpDi9GerT7zFKIea3IHIJdWcHZmH9Jn2KcTV87L78J0j4tSoKL0
            
            //var token = appClient.getAccessToken(code).ToObject<ZaloToken>();

            string access_token = "4KvSI2BvOYKGIbT4Albc9Xb9LKScupLH61PwRM3yINyr7H1pHQrZGZv8AJfhXtrVKt4tHY-zLMbn26H45Uye9bq1M4GSi05oS0n0SHx0T41aDZfq1z1QM3Gk2K9GdKDZAa0_LMkALKubHXniORjAS39U6cXtedLf44euUdohR5z5THj75vvAQYWt64TnqajOJHWgUIt8G1r1EXGWAEnPFXHTRLfPdHjfFNqeK73EQaXD0GzvBi1l6sitA2OeWHf7IKv8I1UmTtHUV1f27ij894DE2eG6LIZaRYa";
            access_token = "PIn8TtqlNLnaA4DxTIzPNsqhGNXvDGuv06WR7Ki9PpumQH9UU39pU0bI5IzV27aA6mi2G7vsHpGgSpvWRGTGFG9a6MGME7uM3tiQLbaZVGqQ9XyjS7zMR64vJJKGQ2521WvKFX9AI5y34pSw469OOdeREny8Kq5DHmSg5GXsC5mQ3tW62saHGnuQQ2LmMGPKF35H1IL76avHJdmKEaeoDbuiBd0uSqWQN2WjJ0XPRXDVK2rIHpDi9GerT7zFKIea3IHIJdWcHZmH9Jn2KcTV87L78J0j4tSoKL0";
            //access_token = token.access_token;


            string fields = "id, name, picture, gender, birthday";
            var friends = appClient.getFriends(access_token, 0, int.MaxValue, fields).ToString();
            //var invitable_friends = appClient.getInvitableFriends(access_token, 0, int.MaxValue, fields).ToString();
            //var profile = appClient.getProfile(access_token, fields).ToString();

            //var postFeed = appClient.postFeed(access_token, "hello world2!", "https://thinh.iot.vn/").ToString();
            //FAIL: { "error": 12010, "message": "Quota daily per user for your app is limited" }
            //OK: {"id":"123123123_23123"}

            Console.WriteLine("Enter to exit ...");
            Console.ReadKey();
        }
    }
}

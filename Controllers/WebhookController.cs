using Microsoft.AspNetCore.Mvc;

namespace whatsapp_hook
{
    public class WebhookController : Controller
    {
        [HttpGet, Route("whatsapp_hook")]
        public void recognize_token()
        {
            string mode = Request.Query["hub.mode"].ToString();
            string challenge = Request.Query["hub.challenge"].ToString();
            string token = Request.Query["hub.verify_token"].ToString();

            if (mode == "subscribe" && token == "YOUR_VERIFICATION_TOKEN")
            {
                Response.StatusCode = 200;
                Response.WriteAsync(challenge);
            }
            else
            {
                Response.StatusCode = 403;

            }
        }


        [HttpPost, Route("whatsapp_hook")]
        public void parse_message()
        {
            using (StreamReader sr = new StreamReader(Request.Body))
            {
                string txtJSONMessage=sr.ReadToEnd();

                //Good, now you have the JSON sent by Meta, Enjoy It!
                //Now you can add your stuff...
            }
        }
    }
}
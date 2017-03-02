using Newtonsoft.Json;
using System.Collections.Generic;

namespace ReCaptcha.Models
{
    public class CaptchaVerification
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error-codes")]
        public List<string> Errors { get; set; }        
    }
}
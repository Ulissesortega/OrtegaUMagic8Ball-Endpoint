//Name: Ulises Ortega
//Date: 10.25.22
//Project: Magic 8 Ball
//Description: This is Endpoint return a ramdon answer to the user question.
//Peer Review: Christopher Prado 27OCT22 : the code is straighforward and clear. The responses were witty & creative. I just would reccomend that something be added so that I could jump to different question responses.
//Instructions: in the example bellow your local host will change, all you need to do is type question where it says Type Question Here
//Example: https://localhost:7106/Magic/Ball/replace with your questions <= here, the press enter.





using Microsoft.AspNetCore.Mvc;

namespace OrtegaUMagic8Ball_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MagicController : ControllerBase
{
    [HttpGet]
    [Route("Ball")]
    public string E(string Text)
    {
        return $" {Text}";
    }
    [HttpGet]
    [Route("Ball/{RNG}")]
    public string J(string RNG)
    {
        int randomNum = 0;
        System.Random r = new System.Random();
        randomNum = r.Next(1, 11);
        string text = "ji";
        switch (randomNum)
        {
            case 1:
                return text = "It is Certain";
                break;
            case 2:
                return text = "Ask Again Later";
                break;
            case 3:
                return text = "My Reply is No";
                break;
            case 4:
                return text = "Without a doubt";
                break;
            case 5:
                return text = "Better not tell you now";
                break;
            case 6:
                return text = "My sources say no";
                break;
            case 7:
                return text = "Yes definitely";
                break;
            case 8:
                return text = "Concentrate and ask again";
                break;
            case 9:
                return text = "Only if work hard enough for it";
                break;
            case 10:
                return text = "Bro, Do you Even Code?";
        }
        return text;
    }
}
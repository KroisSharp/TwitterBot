using System;
using System.Net;
using TweetSharp;

namespace TwitterBot
{
    internal class Program
    {
        //handle tokens
        private static readonly string customer_Key = "KEY";
        private static readonly string customer_key_Sercret = "KEY";
        private static readonly string access_Token = "KEY";
        private static readonly string acess_Token_Sercret = "KEY";

        private static readonly TwitterService Service = new TwitterService(customer_Key, customer_key_Sercret, access_Token, acess_Token_Sercret);


        private static void Main(string[] args)
        {
            //sender twitter
            SendTweet("Hello world");
        }


        //send at tweet
        private static void SendTweet(string _data)
        {
            Service.SendTweet(new SendTweetOptions {Status = _data}, (tweet, response) =>
            {
                if (response.StatusCode == HttpStatusCode.OK)
                    Console.WriteLine("Tweet sent");
                else
                    Console.WriteLine("Fejl! see tokens ok");
            });
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryApp.API_Model;
using InventoryApp.Helpers;
using System.Net.Http;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace InventoryApp.Processors
{
    public class CardProcessor
    {
        //Get a cards information using YGO Pro Deck API, will return multiple version
        public static async Task<YGOProCard> LoadProData(int option, string cardName = "")
        {
            string url = "";
            if (!String.IsNullOrEmpty(cardName))
            {
                switch (option) {
                    case 0:
                        url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?fname={cardName}&tcgplayer_data";
                        break;
                    case 1:
                        url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?id={cardName}&tcgplayer_data";
                        break;
                    case 2:
                        url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?cardset={cardName}&tcgplayer_data";
                        break;
                    default:
                        YGOProCard card = new YGOProCard();
                        return card;
                }
            }
            else
                url = $"https://db.ygoprodeck.com/api";

            using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {

                    YGOProCard card = await response.Content.ReadAsAsync<YGOProCard>();
                    return card;
                }
                else
                {
                    //return null card model
                    YGOProCard card = new YGOProCard();
                    return card;
                }
            }
        }

        public static async Task<YGOProCard> LoadProDataID(string cardid = "")
        {
            string url = "";
            if (!String.IsNullOrEmpty(cardid))
            {
                url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?id={cardid}&tcgplayer_data";
            }
            else
                url = $"https://db.ygoprodeck.com/api";

            using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {

                    YGOProCard card = await response.Content.ReadAsAsync<YGOProCard>();
                    return card;
                }
                else
                {
                    MessageBox.Show("Error");
                    YGOProCard card = new YGOProCard();
                    return card;
                }
            }
        }

        public static async Task<YGOProCard> GetImage(string cardName = "")
        {
           
            string url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?id={cardName}&tcgplayer_data";
            using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {

                    YGOProCard card = await response.Content.ReadAsAsync<YGOProCard>();
                    return card;
                }
                else
                {
                    //return null card model
                    YGOProCard card = new YGOProCard();
                    return card;
                }
            }
        }
    }
}

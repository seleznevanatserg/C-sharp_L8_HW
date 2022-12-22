using Telegram.Bot;
using Telegram.Bot.Types;

TelegramBotClient client = new TelegramBotClient("5769280891:AAFZpEZXv10v3Np10AIYvk1AxWqtZojpMHs");

User bot = client.GetMeAsync().Result;
Console.WriteLine(bot.Username);

Update[ ] updates = client.GetUpdatesAsync().Result;
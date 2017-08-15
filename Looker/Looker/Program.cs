using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Looker
{
    class Program
    {
        static void Main()
        {
            Requests requests = new Requests();

            string eventGetRequest = requests.SoftwareEventGetUrl + requests.AuthToken;

            var events = GetEvent(eventGetRequest).Result.ToList();

            foreach (Event item in events)
            {
                item.Venue = GetVenue(requests.VenueGetUrl + item.Venue + @"/?" + requests.AuthToken).Result;
            }
        }

        public static async Task<IEnumerable<Event>> GetEvent(string url)
        {
            HttpClient client = new HttpClient();
            var responseObject = await client.GetAsync(new Uri(url));
            var result = await responseObject.Content.ReadAsStringAsync();
            Rootobject rootObject = JsonConvert.DeserializeObject<Rootobject>(result);

            return rootObject.events.Select(e => e.ToEvent());
        }

        public static async Task<String> GetVenue(string url)
        {
            HttpClient client = new HttpClient();
            var responseObject = await client.GetAsync(new Uri(url));
            var result = await responseObject.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(result);

            return (string)json[@"address"][@"localized_address_display"];
        }
    }

    public static class RawEventExtensions
    {
        public static Event ToEvent(this RawEvent @event)
        {
            return new Event()
            {
                Description = @event.description.text,
                EndTime = @event.end.utc,
                Id = long.Parse(@event.id),
                Name = @event.name.text,
                StartTime = @event.start.utc,
                Venue = @event.venue_id
            };
        }
    }
}

using System;

namespace Looker
{
    public class Rootobject
    {
        public Top_Match_Events[] top_match_events { get; set; }
        public Pagination pagination { get; set; }
        public RawEvent[] events { get; set; }
        public Location location { get; set; }
    }

    public class Pagination
    {
        public int object_count { get; set; }
        public int page_number { get; set; }
        public int page_size { get; set; }
        public int page_count { get; set; }
        public bool has_more_items { get; set; }
    }

    public class Location
    {
        public string latitude { get; set; }
        public Augmented_Location augmented_location { get; set; }
        public string within { get; set; }
        public string longitude { get; set; }
        public string address { get; set; }
    }

    public class Augmented_Location
    {
        public string city { get; set; }
        public string region { get; set; }
        public string country { get; set; }
    }

    public class Top_Match_Events
    {
        public bool hide_start_date { get; set; }
        public string locale { get; set; }
        public object[] ticket_classes { get; set; }
        public string currency { get; set; }
        public Logo logo { get; set; }
        public string id { get; set; }
        public string privacy_setting { get; set; }
        public string venue_id { get; set; }
        public string user_id { get; set; }
        public Start start { get; set; }
        public int tx_time_limit { get; set; }
        public string logo_id { get; set; }
        public string source { get; set; }
        public string version { get; set; }
        public bool listed { get; set; }
        public bool is_series { get; set; }
        public bool hide_end_date { get; set; }
        public string status { get; set; }
        public Description description { get; set; }
        public End end { get; set; }
        public bool is_free { get; set; }
        public bool is_series_parent { get; set; }
        public int capacity { get; set; }
        public string format_id { get; set; }
        public string style_id { get; set; }
        public string tld { get; set; }
        public Name name { get; set; }
        public string language { get; set; }
        public DateTime created { get; set; }
        public string url { get; set; }
        public DateTime changed { get; set; }
        public bool is_locked { get; set; }
        public bool shareable { get; set; }
        public bool capacity_is_custom { get; set; }
        public bool online_event { get; set; }
        public string organizer_id { get; set; }
        public string category_id { get; set; }
        public bool is_reserved_seating { get; set; }
    }

    public class Logo
    {
        public Crop_Mask crop_mask { get; set; }
        public Original original { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string aspect_ratio { get; set; }
        public string edge_color { get; set; }
        public bool edge_color_set { get; set; }
    }

    public class Crop_Mask
    {
        public Top_Left top_left { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Top_Left
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Original
    {
        public string url { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
    }

    public class Start
    {
        public string timezone { get; set; }
        public DateTime local { get; set; }
        public DateTime utc { get; set; }
    }

    public class Description
    {
        public string text { get; set; }
        public string html { get; set; }
    }

    public class End
    {
        public string timezone { get; set; }
        public DateTime local { get; set; }
        public DateTime utc { get; set; }
    }

    public class Name
    {
        public string text { get; set; }
        public string html { get; set; }
    }

    public class RawEvent
    {
        public Name1 name { get; set; }
        public Description1 description { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public Start1 start { get; set; }
        public End1 end { get; set; }
        public DateTime created { get; set; }
        public DateTime changed { get; set; }
        public int capacity { get; set; }
        public bool capacity_is_custom { get; set; }
        public string status { get; set; }
        public string currency { get; set; }
        public bool listed { get; set; }
        public bool shareable { get; set; }
        public bool online_event { get; set; }
        public int tx_time_limit { get; set; }
        public bool hide_start_date { get; set; }
        public bool hide_end_date { get; set; }
        public string locale { get; set; }
        public bool is_locked { get; set; }
        public string privacy_setting { get; set; }
        public bool is_series { get; set; }
        public bool is_series_parent { get; set; }
        public bool is_reserved_seating { get; set; }
        public string source { get; set; }
        public bool is_free { get; set; }
        public string version { get; set; }
        public string logo_id { get; set; }
        public string organizer_id { get; set; }
        public string venue_id { get; set; }
        public string category_id { get; set; }
        public object subcategory_id { get; set; }
        public string format_id { get; set; }
        public string resource_uri { get; set; }
        public Logo1 logo { get; set; }
        public string series_id { get; set; }
    }

    public class Name1
    {
        public string text { get; set; }
        public string html { get; set; }
    }

    public class Description1
    {
        public string text { get; set; }
        public string html { get; set; }
    }

    public class Start1
    {
        public string timezone { get; set; }
        public DateTime local { get; set; }
        public DateTime utc { get; set; }
    }

    public class End1
    {
        public string timezone { get; set; }
        public DateTime local { get; set; }
        public DateTime utc { get; set; }
    }

    public class Logo1
    {
        public Crop_Mask1 crop_mask { get; set; }
        public Original1 original { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string aspect_ratio { get; set; }
        public string edge_color { get; set; }
        public bool edge_color_set { get; set; }
    }

    public class Crop_Mask1
    {
        public Top_Left1 top_left { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Top_Left1
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Original1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

}
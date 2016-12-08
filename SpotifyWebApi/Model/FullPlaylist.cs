﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Model
{
    public class FullPlaylist
    {
        [JsonProperty("collaborative")]
        public Boolean Collaborative { get; set; }

        [JsonProperty("description")]
        public String Description { get; set; }
        
        [JsonProperty("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; set; }

        [JsonProperty("followers")]
        public Followers Followers { get; set; }

        [JsonProperty("href")]
        public String Href { get; set; }

        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("owner")]
        public PublicUser Owner { get; set; }

        [JsonProperty("public")]
        public Boolean Public { get; set; }

        [JsonProperty("snapshot_id")]
        public String SnapshotId { get; set; }

        [JsonProperty("tracks")]
        public Paging<PlaylistTrack> Tracks { get; set; }

        [JsonProperty("type")]
        public String Type { get; set; }

        [JsonProperty("uri")]
        public String Uri { get; set; }

        public List<PlaylistTrack> TrackList { get; set; }
    }
}

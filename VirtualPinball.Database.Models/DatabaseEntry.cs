using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPinball.Database.Models
{
    public class DatabaseEntry
    {
        public DatabaseEntry()
        {
            ScreenshotUrls = new List<string>();
            Tags = new List<string>();
            RelatedEntries = new List<int>();
            AdditionalInfoUrls = new List<string>();
        }

        /// <summary>
        /// Unique File ID (Primary Key)
        /// </summary>
        public int Id { get; set; }
        public MajorCategory MajorCategory { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string ChangeLog { get; set; }
        public string Authors { get; set; }
        public string Version { get; set; }
        public string Features { get; set; }
        public string Manufacturer { get; set; }
        public int? Year { get; set; }
        public int? Players { get; set; }
        public string Theme { get; set; }
        public int? IpdbNumber { get; set; }
        public long? FileSizeBytes { get; set; }
        public int? DownloadCount { get; set; }
        public int? Rating { get; set; }
        public DateTime? LastModifiedDateUtc { get; set; }
        public List<string> AdditionalInfoUrls { get; set; }
        public List<string> Tags { get; set; }
        public List<string> ScreenshotUrls { get; set; }
        public List<int> RelatedEntries { get; set; }

        [JsonIgnore]
        public string TagsString
        {
            get
            {
                if (Tags != null)
                    return string.Join(", ", Tags.ToArray());
                return string.Empty;
            }
        }
    }
}

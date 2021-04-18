# Virtual Pinball Database Models [![Build status](https://ci.appveyor.com/api/projects/status/vxbnw7ooxh288u42/branch/main?svg=true)](https://ci.appveyor.com/project/xantari/virtualpinball-database-models/branch/main) [![NuGet tag](https://img.shields.io/badge/nuget-VirtualPinball.Database.Models-blue.svg)](https://www.nuget.org/packages?q=VirtualPinball.Database.Models)

Virtual Pinball Database Model database schema in C#

Defines a standard format for cataloging virtual pinball related content with ability to do cross item relationship linking in a small .json file format.

# Starter / Empty Database Example

```json
{
  "LastUpdateDateUtc": "2021-03-27T19:47:38.1024977Z",
  "DatabaseFormatVersion": 1,
  "Entries": [
  ]
}
```

# Example with related database entries

```json
{
    "LastUpdateDateUtc": "2021-03-26T09:00:34.0881981Z",
    "DatabaseFormatVersion": 1,
    "Entries": [
      {
        "Id": 1,
        "MajorCategory": "Table",
        "Url": "https://www.vpforums.org/index.php?app=downloads&showfile=14159#",
        "Title": "1-2-3... (Automaticos 1973)",
        "FileName": "1-2-3... (Automaticos 1973) 1.0.1",
        "Description": "Additional Details: B2S Included",
        "Authors": "JPSalas, Akiles50000, Loserman76, Kiwi",
        "Version": "1.0.1",
        "Manufacturer": "Automaticos",
        "Year": 1973,
        "Players": 1,
        "Theme": "TV Game Show",
        "IpdbNumber": 5247,
        "LastModifiedDateUtc": "2019-11-04T00:00:00",
        "Tags": [
          "VPX",
          "Visual Pinball"
        ],
        "RelatedEntries": [
          2,
          3
        ]
      },
      {
        "Id": 2,
        "MajorCategory": "POV",
        "Url": "http://bit.ly/POVs_RaJo",
        "Title": "Lots of files from Rajo Joey",
        "Authors": "Rajo Joey",
        "Version": "1.0",
        "LastModifiedDateUtc": "2019-07-15T00:00:00"
      },
      {
        "Id": 3,
        "MajorCategory": "Wheel",
        "Url": "https://vpinball.com/VPBdownloads/1-2-3-automaticos-1973-wheel/",
        "Title": "1-2-3... (Automaticos 1973)",
        "Authors": "Mkl66",
        "Version": "1.0",
        "LastModifiedDateUtc": "2021-02-21T00:00:00",
        "Tags": [
          "Transparent"
        ]
      }
    ]
}
```
   

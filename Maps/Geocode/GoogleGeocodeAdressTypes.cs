using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.Google.Maps.Geocode
{
    public enum GoogleGeocodeAdressTypes : long
    {
        Unknown = 0,
        StreetAddress = 1,                  // indicates a precise street address.
        Route = 2,                          // indicates a named route (such as "US 101").
        Intersection = 4,                   // indicates a major intersection, usually of two major roads.
        Political = 8,                      // indicates a political entity. Usually, this type indicates a polygon of some civil administration.
        Country = 16,                       // indicates the national political entity, and is typically the highest order type returned by the Geocoder.
        AdministrativeAreaLevel1 = 32,      // indicates a first-order civil entity below the country level. Within the United States, these administrative levels are states. Not all nations exhibit these administrative levels.
        AdministrativeAreaLevel2 = 64,      // indicates a second-order civil entity below the country level. Within the United States, these administrative levels are counties. Not all nations exhibit these administrative levels.
        AdministrativeAreaLevel3 = 128,     // indicates a third-order civil entity below the country level. This type indicates a minor civil division. Not all nations exhibit these administrative levels.
        AdministrativeAreaLevel4 = 256,     // indicates a fourth-order civil entity below the country level. This type indicates a minor civil division. Not all nations exhibit these administrative levels.
        AdministrativeAreaLevel5 = 512,     // indicates a fifth-order civil entity below the country level. This type indicates a minor civil division. Not all nations exhibit these administrative levels.
        Colloquial_Area = 1024,             // indicates a commonly-used alternative name for the entity.
        Locality = 2048,                    // indicates an incorporated city or town political entity.
        Ward = 4096,                        // indicates a specific type of Japanese locality, to facilitate distinction between multiple locality components within a Japanese address.
        Sublocality = 8192,                 // indicates a first-order civil entity below a locality. For some locations may receive one of the additional types: sublocality_level_1 to sublocality_level_5. Each sublocality level is a civil entity. Larger numbers indicate a smaller geographic area.
        SublocalityLevel1 = 16384,
        SublocalityLevel2 = 32768,
        SublocalityLevel3 = 65536,
        SublocalityLevel4 = 131072,
        SublocalityLevel5 = 262144,
        Neighborhood = 524288,              // indicates a named neighborhood
        Premise = 1048576,                  // indicates a named location, usually a building or collection of buildings with a common name
        Subpremise = 2097152,               // indicates a first-order entity below a named location, usually a singular building within a collection of buildings with a common name
        PostalCode = 4194304,               // indicates a postal code as used to address postal mail within the country.
        NaturalFeature = 8388608,           // indicates a prominent natural feature.
        Airport = 16777216,                 // indicates an airport.
        Park = 33554432,                    // indicates a named park.
        PointOfInterest = 67108864,         // indicates a named point of interest. Typically, these "POI"s are prominent local entities that don't easily fit in another category, such as "Empire State Building" or "Statue of Liberty."
        Floor = 134217728,                  // indicates the floor of a building address.
        Establishment = 268435456,          // typically indicates a place that has not yet been categorized.
        Parking = 536870912,                // indicates a parking lot or parking structure.
        PostBox = 1073741824,               // indicates a specific postal box.
        PostalTown = 2147483648,            // indicates a grouping of geographic areas, such as locality and sublocality, used for mailing addresses in some countries.
        Room = 4294967296,                  // indicates the room of a building address.
        StreetNumber = 8589934592,         // indicates the precise street number.
        BusStation = 17179869184,          // indicate the location of a bus, train or public transit stop.
        TrainStation = 34359738368,
        TransitStation = 68719476736
    }
}

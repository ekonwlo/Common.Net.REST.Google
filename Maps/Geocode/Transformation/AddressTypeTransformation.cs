using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.Google.Maps.Geocode.Transformation
{
    class AddressTypeTransformation
        : IRestTransformation<GoogleGeocodeAdressTypes, string[]>
    {
        public string[] Transform(GoogleGeocodeAdressTypes input)
        {
            throw new NotImplementedException();
        }

        public GoogleGeocodeAdressTypes Revert(string[] input)
        {
            GoogleGeocodeAdressTypes type = GoogleGeocodeAdressTypes.Unknown;

            foreach (string t in input)
            {
                switch (t)
                {
                    case "street_address":
                        type |= GoogleGeocodeAdressTypes.StreetAddress;
                        break;
                    case "route":
                        type |= GoogleGeocodeAdressTypes.Route;
                        break;
                    case "intersection":
                        type |= GoogleGeocodeAdressTypes.Intersection;
                        break;
                    case "political":
                        type |= GoogleGeocodeAdressTypes.Political;
                        break;
                    case "country":
                        type |= GoogleGeocodeAdressTypes.Country;
                        break;
                    case "administrative_area_level_1":
                        type |= GoogleGeocodeAdressTypes.AdministrativeAreaLevel1;
                        break;
                    case "administrative_area_level_2":
                        type |= GoogleGeocodeAdressTypes.AdministrativeAreaLevel2;
                        break;
                    case "administrative_area_level_3":
                        type |= GoogleGeocodeAdressTypes.AdministrativeAreaLevel3;
                        break;
                    case "administrative_area_level_4":
                        type |= GoogleGeocodeAdressTypes.AdministrativeAreaLevel4;
                        break;
                    case "administrative_area_level_5":
                        type |= GoogleGeocodeAdressTypes.AdministrativeAreaLevel5;
                        break;
                    case "colloquial_area":
                        type |= GoogleGeocodeAdressTypes.Colloquial_Area;
                        break;
                    case "locality":
                        type |= GoogleGeocodeAdressTypes.Locality;
                        break;
                    case "ward":
                        type |= GoogleGeocodeAdressTypes.Ward;
                        break;
                    case "sublocality":
                        type |= GoogleGeocodeAdressTypes.Sublocality;
                        break;
                    case "sublocality_level_1":
                        type |= GoogleGeocodeAdressTypes.SublocalityLevel1;
                        break;
                    case "sublocality_level_2":
                        type |= GoogleGeocodeAdressTypes.SublocalityLevel2;
                        break;
                    case "sublocality_level_3":
                        type |= GoogleGeocodeAdressTypes.SublocalityLevel3;
                        break;
                    case "sublocality_level_4":
                        type |= GoogleGeocodeAdressTypes.SublocalityLevel4;
                        break;
                    case "sublocality_level_5":
                        type |= GoogleGeocodeAdressTypes.SublocalityLevel5;
                        break;
                    case "neighborhood":
                        type |= GoogleGeocodeAdressTypes.Neighborhood;
                        break;
                    case "premise":
                        type |= GoogleGeocodeAdressTypes.Premise;
                        break;
                    case "subpremise":
                        type |= GoogleGeocodeAdressTypes.Subpremise;
                        break;
                    case "postal_code":
                        type |= GoogleGeocodeAdressTypes.PostalCode;
                        break;
                    case "natural_feature":
                        type |= GoogleGeocodeAdressTypes.NaturalFeature;
                        break;
                    case "airport":
                        type |= GoogleGeocodeAdressTypes.Airport;
                        break;
                    case "park":
                        type |= GoogleGeocodeAdressTypes.Park;
                        break;
                    case "point_of_interest":
                        type |= GoogleGeocodeAdressTypes.PointOfInterest;
                        break;
                    case "floor":
                        type |= GoogleGeocodeAdressTypes.Floor;
                        break;
                    case "establishment":
                        type |= GoogleGeocodeAdressTypes.Establishment;
                        break;
                    case "parking":
                        type |= GoogleGeocodeAdressTypes.Parking;
                        break;
                    case "post_box":
                        type |= GoogleGeocodeAdressTypes.PostBox;
                        break;
                    case "postal_town":
                        type |= GoogleGeocodeAdressTypes.PostalTown;
                        break;
                    case "room":
                        type |= GoogleGeocodeAdressTypes.Room;
                        break;
                    case "street_number":
                        type |= GoogleGeocodeAdressTypes.StreetNumber;
                        break;
                    case "bus_station":
                        type |= GoogleGeocodeAdressTypes.BusStation;
                        break;
                    case "train_station":
                        type |= GoogleGeocodeAdressTypes.TrainStation;
                        break;
                    case "transit_station":
                        type |= GoogleGeocodeAdressTypes.TransitStation;
                        break;
                }
            }
            return type;
        }
    }
}

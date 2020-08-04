using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Glamperio.Models
{
    public class CampRepository : ICampRepository
    {
        private readonly IDbConnection _conn;
        public CampRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Campgrounds> GetAllCampgrounds()
        {
            return _conn.Query<Campgrounds>("SELECT media_api_v1.description, campsites.campsitelongitude, campsites.CampsiteLatitude, campsites.CampsiteName, media_api_v1.Title, media_api_v1.URL FROM campsites INNER JOIN media_api_v1 ON media_api_v1.EntityID = campsites.FacilityID; ");
        }

        public Campgrounds GetCampgrounds(string CampsiteName)
        {
            return (Campgrounds)_conn.Query<Campgrounds>("SELECT media_api_v1.description, campsites.campsitelongitude, campsites.CampsiteLatitude, campsites.CampsiteName, media_api_v1.Title, media_api_v1.URL FROM campsites INNER JOIN media_api_v1 ON media_api_v1.EntityID = campsites.FacilityID WHERE CAMPSITENAME = @CampsiteName");
               

        }
    }
}

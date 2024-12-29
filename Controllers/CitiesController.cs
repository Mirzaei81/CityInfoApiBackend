
using CityInfoApi.Dtos;
using CityInfoApi.Models;
using CityInfoApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class CitiesController: ControllerBase
    {

        private readonly iCityInfoReposit _iCityInfoReposit;
      
        public CitiesController(iCityInfoReposit iCityInfoReposit)
        {
            _iCityInfoReposit = iCityInfoReposit;
        }

        [HttpGet("kalas")]
        public async Task< ActionResult<IEnumerable<Kala>>> GetKalas()
        {
            return Ok(await _iCityInfoReposit.GetKalasAsync());

        }

        [HttpGet("groups/{gid}")]
        [ProducesResponseType(typeof(Kala),200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<IEnumerable<Kala>>> GetKalaByGroup(int gid)
        {
            IEnumerable<Kala> kalas = await _iCityInfoReposit.GetKalaByGroupAsync(gid);
            if (kalas == null || kalas.Count()==0)
            {
                return NotFound();  
            }
            return Ok(kalas);
        }
        [HttpGet("groups")]
        public async Task<ActionResult<IEnumerable<categoryDTO>>> GetCategories()
        {
            IEnumerable<categoryDTO?> groups = await _iCityInfoReposit.GetCategoriesAsync();
            if(groups==null || groups.Count()==0)
            {
                return NotFound();
            }
            return Ok(groups);  
        }
        [HttpGet("moshtaris")]
        public async Task<ActionResult<IEnumerable<Moshtari>>> GetCities2()
        {
            var cities = await _iCityInfoReposit.GetMoshtarisAsync();


            return Ok(new MoshtariListResponse { Moshtaris = cities });
        }
        public class MoshtariListResponse
        {
            public IEnumerable<Moshtari>? Moshtaris { get; set; }
        }


        [HttpGet("factor1")]
        public async Task<ActionResult<IEnumerable<Factor1>>> GetCities3()
        {
            var cities = await _iCityInfoReposit.GetFactor1sAsync();
            return Ok(cities);
        }

        [HttpGet("fmoshtari/{id}")]
        public async Task<ActionResult<IEnumerable<Factor1>>> GetFactor1sWithFactor2Async(int id)
        {
            var factor1sWithFactor2 = await _iCityInfoReposit.GetFactor1sWithFactor2Async(id);

            if (factor1sWithFactor2 == null)
            {
                return NotFound();
            }
            /*if (factor1sWithFactor2 == null || factor1sWithFactor2.Count == 0)
            {
                return NotFound();
            }
*/
            return Ok(factor1sWithFactor2);
        }

      /*  https://localhost:44355/api/acc_HsbPrsnsKoli?dateTo=1401%2F12%2F29&dateFrom=1401%2F01%2F01&codeM=10001&mrkaz=1&mandDate=0&kind=A*/

        [HttpGet("acc_HsbPrsnsKoli")]
        public async Task<ActionResult<IEnumerable<HsbPrsnsKoli>>> GetSomeDataAsync(string? dateTo, string? dateFrom, int codeM, int mrkaz, int mandDate, char kind)
        {
            var queryResult = await _iCityInfoReposit.GetHsbPrsnsKoliAsync(dateTo, dateFrom, codeM, mrkaz, mandDate, kind);

            if (queryResult == null || queryResult.Count()==0 )
            {
                return NotFound();
            }


            return Ok(new HsbPrsnsKoliListResponse { HsbPrsnsKoli = queryResult });
        }

        public class HsbPrsnsKoliListResponse
        {
            public IEnumerable<HsbPrsnsKoli>? HsbPrsnsKoli { get; set; }
        }
        /*@F_No int, @F_Date char(10), @F_Markz int, @F_User int, @F_Kind tinyint, @F_Anbar tinyint, @F_Moshtari int,
            @F_Serial int, @F_Anbar2 tinyint, @F_DateTahvil char(10), @F_DateA char(10), @F_Mab float, @F_MabKol float,
        @F_Kosor Float, @F_Ezafat Float,
            @F_Porsant int, @F_MabPorsant float, @F_FixPorsant bit, @F_Kdarsad bit, @F_AccAnbar varchar(8),
        @F_Maliat Float, @F_Avarez Float, @F_DriverName nvarchar(100) AS
        */
   
/*
        [HttpGet("Ins2Factor")]
        public async Task<ActionResult<IEnumerable<Ins2Factor>>> GetQueryResult(int F_No,
                        string F_Date, int F_Markz,
                        int F_User,
                        short F_Kind,
                        short F_Anbar,
                        int F_Moshtari,
                        float F_Mab,
                        float F_MabKol)
        {
            var queryResult = await _iCityInfoReposit.GetQueryResult(F_No,
                F_Date,
                F_Markz,
                F_User,
                F_Kind,
                F_Anbar,
                F_Moshtari,F_Mab,
                F_MabKol);

            if (queryResult == null)
            {
                return NotFound();
            }


            return Ok(queryResult);
        }*/

        [HttpGet("Ins2Factor")]
        public async Task<ActionResult<IEnumerable<Ins2Factor>>> GetQueryResult(int F_No,
                   string F_Date, int F_Markz,
                   int F_User,
                   short F_Kind,
                   short F_Anbar,
                   int F_Moshtari,
                   int F_Serial,
                   short F_Anbar2,
                   string F_DateTahvil,
                   string F_DateA,
                   float F_Mab,
                   float F_MabKol,
                   float F_Kosor,
                   float F_Ezafat,
                   int F_Porsant,
                   float F_MabPorsant,
                   byte F_FixPorsant, byte F_Kdarsad,
                   string F_AccAnbar,
                   float F_Maliat, float F_Avarez,
                   string F_DriverName)
        {
            var queryResult = await _iCityInfoReposit.GetQueryResult(F_No,
                F_Date,
                F_Markz,
                F_User,
                F_Kind,
                F_Anbar,
                F_Moshtari,
                F_Serial,
                F_Anbar2,
                F_DateTahvil,
                F_DateA,
                F_Mab,
                F_MabKol,
                F_Kosor,
                F_Ezafat,
                F_Porsant,
                F_MabPorsant,
                F_FixPorsant,
                F_Kdarsad,
                F_AccAnbar,
                F_Maliat,
                F_Avarez,
                F_DriverName);

            if (queryResult == null)
            {
                return NotFound();
            }


            return Ok(queryResult);
        }
        [HttpGet("Fac/{FK_NO}")]
        public async Task<ActionResult<IEnumerable<FactorDetail>>> getFactorDetail(int FK_NO)
        {
            IEnumerable<FactorDetail>? factor =await _iCityInfoReposit.GetFactorDetailsAsync(FK_NO);
            if (factor == null)
            {
                return NotFound();
            }
            return Ok(factor);
        }


        [HttpGet("sanad")]
        public async Task<ActionResult<IEnumerable<Sanad1400>>> GetSanadwAsync(int code, string date1)
        {
            var queryResult = await _iCityInfoReposit.Getacc_SelectSanadsAsync(code,date1);

            if (queryResult == null)
            {
                return NotFound();
            }


            return Ok(queryResult);
        }


    }




}




/*ALTER PROCEDURE[dbo].[str_Ins2FactorITM] @F_Factor int, @Radif int,@Kala int, @Sharh nvarchar(80), @Num float, @NumKoli int, @Tol float, 
	@Arze float, @V tinyint, @Tdad smallint, @Mab Float, @KindArz tinyint, @Arz float, @Modat bit, @DateModat char(10), @Anbar int, @Anbar2 int, @Kdarsad Float, @Avarez float, @Maliat float AS*/

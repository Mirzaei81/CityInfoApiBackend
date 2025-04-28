using CityInfoApi.Dtos;
using CityInfoApi.Models;
using CityInfoApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Text.Json;

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
        public async Task<ActionResult<MoshtariListResponse>> GetCities2()
        {
            var cities = await _iCityInfoReposit.GetMoshtarisAsync();
            var  gorohs = await _iCityInfoReposit.GetGorohMsAsync();
            var moshtariListResponse = new MoshtariListResponse { Moshtaris = cities, gorohMs = gorohs };
            try
            {
                string body = JsonSerializer.Serialize(moshtariListResponse);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return Ok(moshtariListResponse);
        }

        [HttpPost("moshtaris")]
        public async Task<ActionResult<IEnumerable<Moshtari>>> CreateMoshtari([FromBody] MoshtariDto moshtariDto)
        {
            var cities = await _iCityInfoReposit.CreateMoshtariAsync(moshtariDto);
            return Ok(cities);
        }
        public class MoshtariListResponse
        {
            public IEnumerable<Moshtari>? Moshtaris { get; set; }
            public IEnumerable<GorohM> gorohMs { get; set; }
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

        [HttpPost("SubmitFactor")]
        public async Task<ActionResult> PostFactor([FromBody] FactorSubmit factorDetails)
        {
            try
            {
                int F_No =await  _iCityInfoReposit.SubmitFactorAsync(factorDetails);
                string FacUri = $"api/Fac/{F_No}";
                return  Created(FacUri,new {Uri=FacUri, id = F_No });
            }catch(SqlException exception)
            {
                return BadRequest(exception.ToString());
            }
        }
        [HttpGet("Anbar")]
        public async Task<ActionResult<IEnumerable<Anbar>>> getAnbars()
        {
            IEnumerable<Anbar> anabrs = await _iCityInfoReposit.GetAnbarsAsync();
            if (anabrs.Count() == 0)
            {
                return NotFound();
            }
            return Ok(anabrs);
        }
        [HttpGet("Fac/{id}")]
        [ActionName(nameof(getFactorDetail))]
        public async Task<ActionResult<IEnumerable<FactorDetail>>> getFactorDetail(int id)
        {
            IEnumerable<FactorDetail>? factor =await _iCityInfoReposit.GetFactorDetailsAsync(id);
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


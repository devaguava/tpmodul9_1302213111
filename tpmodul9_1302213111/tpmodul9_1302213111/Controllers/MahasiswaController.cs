using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302213111.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Deva Angela Felisitas Toding", "1302213111"),
            new Mahasiswa("Alif Taufiqurrahman", "1302213011"),
            new Mahasiswa("Iqro Banyuanto", "1302213061"),
            new Mahasiswa("Regy Renanda Rahman", "1302213117"),
            new Mahasiswa("Rahma Sakti Rahardian", "1302210095")
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa newMahasiswa)
        {
            dataMahasiswa.Add(newMahasiswa);
        }

        //// PUT api/<MahasiswaController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Mahasiswa updatedMahasiswa)
        //{
        //    dataMahasiswa[id] = updatedMahasiswa;
        //}

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}

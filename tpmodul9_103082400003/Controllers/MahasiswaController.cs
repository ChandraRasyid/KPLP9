using Microsoft.AspNetCore.Mvc;
using tpmodul9_103082400003.Model;

namespace tpmodul9_103082400003.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Rasyid Isnain Chandra", "103082400003"),
            new Mahasiswa("LeBron James", "1302000001"),
            new Mahasiswa("Stephen Curry", "1302000002")
        };

        // Mengambil semua data 
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return daftarMahasiswa;
        }

        // Mengambil satu data berdasarkan index 
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return daftarMahasiswa[id];
        }

        // Menambah data mahasiswa baru 
        [HttpPost]
        public void Post([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
        }

        // Menghapus data berdasarkan index 
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            daftarMahasiswa.RemoveAt(id);
        }
    }
}

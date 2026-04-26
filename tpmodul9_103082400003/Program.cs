var builder = WebApplication.CreateBuilder(args);

// 1. TAMBAHKAN SERVICE CONTROLLER
// Ini wajib agar aplikasi bisa mengenali MahasiswaController yang Anda buat
builder.Services.AddControllers();

// 2. AKTIVASI SWAGGER (OPENAPI)
// Pastikan ini ada agar Anda bisa mengerjakan Nomor 4 dengan mudah di browser
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 3. KONFIGURASI HTTP REQUEST PIPELINE
// Swagger hanya muncul di mode Development agar aman
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// 4. MAPPING CONTROLLER
// Perintah ini menghubungkan route URL (api/mahasiswa) ke logic di controller Anda
app.MapControllers();

app.Run();
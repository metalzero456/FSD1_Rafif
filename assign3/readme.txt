============================================================
Nama		: Rafif Taqiuddin
Kode Peserta	: FSDO001ONL022
Asssingment	: 3
------------------------------------------------------------

Cara Menggunakan Testing Api dan JWT Movie Database.

1. Buka folder MovieDatabaseApp lalu import file database movie.sql ke dalam DBMS PHPMyAdmin.

2. Buka file appsettings.json, ganti Uid dan Pwd pada DefaultConnection sesuai dengan kredensial PHPMyAdmin anda.

3. Lalu jalankan CLI pada folder MovieDatabaseApp.

2. Pastikan .Net 5.0 sudah terinstall, lalu jalankan dotnet run.

3. Buka browser kesayangan, lalu ketikan alamat https://localhost/swagger

4. Akan terlihat tampilan Swagger UI, pertama-tama buat kredensial anda terlebih dahulu dengan menekan tombol Post /api/AuthManagement/Register lalu 'Try it out'

5. Masukan username, email, dan password yang anda inginkan pada string json yang ada

6. Tekan execute

7. Setelah kredensial terbuat, tekan tombol Post /api/AuthManagement/Login lalu 'Try it out'

8. Isikan email dan password yang anda buat sebelumnya.

9. Tekan execute

10. Akan muncul token pada server response Details, copy token ini.

11. Tekan tombol Authorize pada bagian atas lalu paste token yang di copy sebelumnya lalu tekan authorize.

12. Close authorize 

13. Sekarang anda bebas menguji api pada database Movies yang ada.

Get : berfungsi menampilkan semua entri database movies.

Get(id) : berfungsi menampilkan entri database movies sesuai id yang diinput.

Post : berfungsi insert entri baru ke database movies.

Put : berfungsi update entri database movies sesuai id yang diinput.

Delete : berfungsi delete entri database movies sesuai id yang diinput.

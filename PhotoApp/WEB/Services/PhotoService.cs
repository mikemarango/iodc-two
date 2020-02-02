using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WEB.Services
{
    public class PhotoService
    {
        public PhotoService(HttpClient client)
        {
            Client = client;
        }

        public HttpClient Client { get; }

        public async Task<List<Photo>> GetPhotosAsync()
        {
            var stream = await Client.GetStreamAsync("api/photos");
            if (stream is null) return null;
            return await JsonSerializer.DeserializeAsync<List<Photo>>(stream);
        }

        public async Task<PhotoDto> GetPhotoAsync(int id)
        {
            var stream = await Client.GetStreamAsync($"api/photos/{id}");
            if (stream is null) return null;
            return await JsonSerializer.DeserializeAsync<PhotoDto>(stream);
        }

        public async Task UpdatePhotoAsync(int id, PhotoUpdateDto photoUpdateDto)
        {
            var photoAsString = JsonSerializer.Serialize(photoUpdateDto);
            var response = await Client.PutAsync($"api/photos/{id}",
                new StringContent(photoAsString, Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task<PhotoDto> AddPhotoAsync(PhotoCreateDto photoCreateDto)
        {
            var photoAsString = JsonSerializer.Serialize(photoCreateDto);
            var response = await Client.PostAsync($"api/photos",
                new StringContent(photoAsString, Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
            var stream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<PhotoDto>(stream);
        }

        public async Task DeletePhotoAsync(int id)
        {
            var response = await Client.DeleteAsync($"photos/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}

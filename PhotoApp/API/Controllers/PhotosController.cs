using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using AutoMapper;
using DATA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        public ApplicationContext Context { get; }
        public IMapper Mapper { get; }

        public PhotosController(ApplicationContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }
        // GET: api/Photos
        [HttpGet]
        public async Task<IEnumerable<PhotoDto>> Get()
        {
            var photos = await Context.Photos.ToListAsync();
            var photoDtos = Mapper.Map<IEnumerable<PhotoDto>>(photos);
            return photoDtos;

        }

        // GET: api/Photos/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<PhotoDto>> Get(int id)
        {
            if (id.Equals(null)) return BadRequest();
            var photo = await Context.Photos.FindAsync(id);
            if (photo.Equals(null)) return NotFound();
            var photoDto = Mapper.Map<PhotoDto>(photo);
            return photoDto;
        }

        // POST: api/Photos
        [HttpPost]
        public async Task<ActionResult<PhotoDto>> Post([FromBody] PhotoCreateDto photoCreateDto)
        {
            if (photoCreateDto is null) return BadRequest();
            var photo = Mapper.Map<Photo>(photoCreateDto);
            var filename = $"{Guid.NewGuid().ToString()}.jpg";
            await System.IO.File.WriteAllBytesAsync($@"photos\{filename}", photoCreateDto.Bytes);
            photo.Filename = filename;
            Context.Photos.Add(photo);
            await Context.SaveChangesAsync();
            var photoDto = Mapper.Map<PhotoDto>(photo);
            return photoDto;
        }

        // PUT: api/Photos/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PhotoUpdateDto photoUpdateDto)
        {
            if (photoUpdateDto is null) return BadRequest();
            var photo = await Context.Photos.FindAsync(id);
            if (photo is null) return BadRequest();
            Mapper.Map(photoUpdateDto, photo);
            Context.Photos.Update(photo);
            await Context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();
            var photo = await Context.Photos.FindAsync(id.Value);
            if (photo is null) return NotFound();
            Context.Photos.Remove(photo);
            await Context.SaveChangesAsync();
            return NoContent();
        }
    }
}

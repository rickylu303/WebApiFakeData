using FakeDataEntities.Production;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiFakeData.BLL.Interfaces.Production;

namespace WebApiFakeData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsiteCommentsController : ControllerBase
    {
        private readonly IWebsiteCommentBLL _bll;
        public WebsiteCommentsController(IWebsiteCommentBLL categoryBll)
        {
            _bll = categoryBll;
        }
        /// <summary>
        /// Retorna listado de cateogrías
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<WebsiteComments>> Get()
        {
            return await _bll.GetAll();
        }

        /// <summary>
        /// Obtiene una categoría que tiene como id el valor especificado
        /// </summary>
        /// <param name="id">Identificador de la categoría</param>
        /// <returns><see cref="ProductCategory"/></returns>
        [HttpGet("{id}")]
        public async Task<WebsiteComments> Get(int id)
        {
            return await _bll.GetById(id);
        }

        /// <summary>
        /// Crear una nueva categorìa
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<int> Post(string categoryName)
        {
            return await _bll.Create(categoryName);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

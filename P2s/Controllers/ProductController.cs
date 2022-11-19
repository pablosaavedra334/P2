using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P2s.Data.Entity;
using P2s.Data.Helper;
using P2s.Data.Repository;

namespace P2s.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IUserHelper userHelper;
        public ProductController(IProductRepository productRepository, IUserHelper userHelper) //repository foquito / campo
        {
            this.productRepository = productRepository;
            this.userHelper = userHelper;
        }

        public IActionResult Index() //Index/agregar vista/vista razor / (index/list/Product..p2../)
        {

            return View(this.productRepository.GetAll());
        }

        public IActionResult Details(int? Id) //Index/agregar vista/vista razor / (index/Details/Product..p2../)
        {

            if (Id == null)
            {
                return NotFound();

            }

            var product = this.productRepository.GetByIdAsync(Id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);



        }

        [HttpGet]   //se agraga a la base de datos al apretar create
        public IActionResult Create()  //Index/agregar vista/vista razor / (index/create/Product..p2../)
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(Product product) //solo product
        {
            if(ModelState.IsValid)
            {
                //TODO: pendiente el cambio de: This.User:identity.Name

                product.User = await this.userHelper.GetUserByEmailAsync("pablosaavedra334@gmail.com");
                await this.productRepository.CreateAync(product);
                return RedirectToAction(nameof(Index));
            }

            return View(product);

        }

        //ultima clase para el 2do examen

        //Editar

        public async Task< IActionResult> Edit (int? Id)  //interrogracion *copiar de la parte de arriba //Crear la visa reizor
        {
            if (Id == null) // Id = Id de la tabla proudcto
            {
                return NotFound();

            }

            var product = await this.productRepository.GetByIdAsync(Id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (Product product)
        {

            if(ModelState.IsValid)
            {
                try
                {

                    //TODO: pendiente el cambio de: This.User:identity.Name

                    product.User = await this.userHelper.GetUserByEmailAsync("pablosaavedra334@gmail.com");

                    await this.productRepository.UpdateAsync(product);


                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.productRepository.ExistAscync(product.Id))
                    {
                        return NotFound();

                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));

            }

            return View(product);

        }

        //Funcion Detele    

        [HttpGet]

        public async Task< IActionResult> Delete(int? Id) //crear la vista delete
        {

            if (Id == null) // Copiamos de nuevo de la partde Id
            {
                return NotFound();

            }

            var product = await this.productRepository.GetByIdAsync(Id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);

        }

        [HttpPost, ActionName("Delete")] // Le esta dando nombre   DeleteConfirmed = delete
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>DeleteConfirmed(int Id)
        {

            var product = await this.productRepository.GetByIdAsync(Id);
            await this.productRepository.DeleteAsync(product);
           
            return RedirectToAction(nameof(Index));
        }

    }

}


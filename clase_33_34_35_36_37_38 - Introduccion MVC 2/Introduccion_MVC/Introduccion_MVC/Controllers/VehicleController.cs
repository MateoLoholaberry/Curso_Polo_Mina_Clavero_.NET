using Introduccion_MVC.Data;
using Introduccion_MVC.Data.Entities;
using Introduccion_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Introduccion_MVC.Controllers
{
    public class VehicleController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public VehicleController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Vista lista
        public IActionResult Index()
        {

            var vehiculos = _dbContext.Vehiculos.ToList();

            //var model = new VehicleListViewModel
            //{
            //    Vehiculos = new List<VehicleListModel>()
            //};

            //foreach (var vehicle in vehiculos)
            //{
            //    model.Vehiculos.Add(new VehicleListModel
            //    {
            //        Id = vehicle.Id,
            //        Dominio = vehicle.Dominio,
            //        AnioFabricacion = vehicle.AnioFabricacion,
            //    });
            //}



            var vehicles = vehiculos
                .Select(x => new VehicleListModel
                {
                    Id = x.Id,
                    Dominio = x.Dominio,
                    AnioFabricacion = x.AnioFabricacion,
                })
                .ToList();

            ViewData["miTitulo"] = "My vehicles";

            // ViewData["Vehicles"] = vehicles;


            ViewBag.Vehicles = vehicles;

            return View("List");
        }



        //Vista editar
        public IActionResult Edit(int id)
        {
            if (_dbContext.Vehiculos.Any(x => x.Id == id))
            {
                VehicleModel model = _dbContext.Vehiculos.Select(v => new VehicleModel
                {
                    Id = v.Id,
                    Dominio = v.Dominio,
                    NumeroChasis = v.NumeroChasis,
                    Propietario = v.Propietario,
                    AnioFabricacion = v.AnioFabricacion
                }).First(x => x.Id == id);

                return View(model);
            }

            return RedirectToAction("Error", "Home");

        }


        //Update
        [HttpPost]
        public async Task<IActionResult> Update(VehicleModel vehiculoModelo)
        {
            try
            {
                if (_dbContext.Vehiculos.Any(x => x.Id == vehiculoModelo.Id))
                {
                    Vehiculo vehiculoUpdate = _dbContext.Vehiculos.Select(v => new Vehiculo
                    {
                        Id = v.Id,
                        Dominio = vehiculoModelo.Dominio,
                        NumeroChasis = vehiculoModelo.NumeroChasis,
                        Propietario = vehiculoModelo.Propietario,
                        AnioFabricacion = vehiculoModelo.AnioFabricacion
                    }).First(x => x.Id == vehiculoModelo.Id);

                    _dbContext.Update(vehiculoUpdate);
                    await _dbContext.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }

                return RedirectToAction("Error", "Home");
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
                // throw;
            }
        }



        //Vista nuevo
        public IActionResult New()
        {
            return View();
        }


        //Post
        [HttpPost]
        public async Task<IActionResult> Create(VehicleModel vehiculo)
        {
            if(!ModelState.IsValid)
            {
                return View("New", vehiculo);
            }

            try
            {
                Vehiculo v = new()
                {
                    Dominio = vehiculo.Dominio,
                    AnioFabricacion = vehiculo.AnioFabricacion,
                    Propietario = vehiculo.Propietario,
                    NumeroChasis = vehiculo.NumeroChasis
                };

                _dbContext.Add(v);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
                // throw;
            }
        }



        //Vista eliminar
        public IActionResult Remove(int id)
        {
            if (_dbContext.Vehiculos.Any(x => x.Id == id))
            {
                VehicleModel model = _dbContext.Vehiculos.Select(v => new VehicleModel
                {
                    Id = v.Id,
                    Dominio = v.Dominio,
                    NumeroChasis = v.NumeroChasis,
                    Propietario = v.Propietario,
                    AnioFabricacion = v.AnioFabricacion
                }).First(x => x.Id == id);

                return View(model);
            }

            return RedirectToAction("Error", "Home");

        }


        //Delete
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (_dbContext.Vehiculos.Any(x => x.Id == id))
                {
                    Vehiculo VehiculoDelete = _dbContext.Vehiculos.First(x => x.Id == id);
                    _dbContext.Remove(VehiculoDelete);
                    await _dbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                return RedirectToAction("Error", "Home");


            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
                // throw;
            }
        }


        //Vista Detalle
        public IActionResult Detail(int id)
        {
            if (_dbContext.Vehiculos.Any(x => x.Id == id))
            {
                VehicleModel model = _dbContext.Vehiculos.Select(v => new VehicleModel
                {
                    Id = v.Id,
                    Dominio = v.Dominio,
                    NumeroChasis = v.NumeroChasis,
                    Propietario = v.Propietario,
                    AnioFabricacion = v.AnioFabricacion
                }).First(x => x.Id == id);

                return View(model);
            }

            return RedirectToAction("Error", "Home");

        }


    }
}

using Azure.Identity;
using ConsoleTables;
using Microsoft.Extensions.DependencyInjection;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Entidades.Enums;
using MpDeportes.TP1.Ioc;
using MpDeportes.TP1.Servicios.Interfaces;
using MpDeportes.TP1.Servicios.Servicios;
using MpDeportes.TP1.Shared;
using System.Numerics;


internal class Program
{
    private static IServiceProvider? servicioProvider;
    static int pageSize = 15;
    private static void Main(string[] args)
    {
        servicioProvider = DI.ConfigurarServicios();
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Listar Shoes");
            Console.WriteLine("2. Agregar un Shoes");
            Console.WriteLine("3. Borrar un Shoes");
            Console.WriteLine("4. Editar un Shoes");
            Console.WriteLine("===============================");
            Console.WriteLine("5. Listado de Brand ");
            Console.WriteLine("6. Agregar un Brand");
            Console.WriteLine("7. Borrar un Brand");
            Console.WriteLine("8. Editar un Brand");
            Console.WriteLine("===============================");
            Console.WriteLine("9.  Listado de Sport");
            Console.WriteLine("10. Agregar un Sport");
            Console.WriteLine("11. Borrar un Sport");
            Console.WriteLine("12. Editar un Sport");
            Console.WriteLine("===============================");
            Console.WriteLine("13. Listado de Colors");
            Console.WriteLine("14. Agregar un Color");
            Console.WriteLine("15. Borrar un Color");
            Console.WriteLine("16. Editar un Color");
            Console.WriteLine("===============================");
            Console.WriteLine("17. Listado de Genre");
            Console.WriteLine("18. Agregar un Genre");
            Console.WriteLine("19. Borrar un Genre");
            Console.WriteLine("20. Editar un Genre");
            Console.WriteLine("===============================");
            Console.WriteLine("21. Listado de Talles");
            Console.WriteLine("22. Agregar un Talle");
            Console.WriteLine("23. Borrar un Talle");
            Console.WriteLine("24. Editar un Talle");
            Console.WriteLine("===============================");
            Console.WriteLine("25.Listar Shoes Paginado");
            Console.WriteLine("26.Listar Shoes Paginado y Ordenado");
            Console.WriteLine("===============================");
            Console.WriteLine("27.Listar Shoes Por MARCA");
            Console.WriteLine("28.Listar Shoes Por GENERO");
            Console.WriteLine("29.Listar Shoes Por DEPORTE");
            Console.WriteLine("34.Listar Shoes Por COLOR");
            Console.WriteLine("===============================");
            Console.WriteLine("30. Listado de Brand PAGINADO ");
            Console.WriteLine("31. Listado de Sport PAGINADO ");
            Console.WriteLine("32. Listado de Colors PAGINADO ");
            Console.WriteLine("33. Listado de Genres PAGINADO ");
            Console.WriteLine("35. Listado de Sizes PAGINADO ");
            Console.WriteLine("===============================");
            Console.WriteLine("36. Listado de SHOES FILTRADO (Brand y 2 precios)");//me parecieron
            Console.WriteLine("37. Listado de SHOES FILTRADO (Genre y 2 precios)");//los mas importante
            Console.WriteLine("===============================");
            Console.WriteLine("38. Listado de SHOES FILTRADO (Brand,Genre,Sport)");
            Console.WriteLine("===============================");
            Console.WriteLine("40. Listado de SHOES en un TALLE");
            Console.WriteLine("41. Listado de TALLES en un SHOES");
            Console.WriteLine("44. Listado de SHOES con TALLES");
            Console.WriteLine("42. Agregar TALLE a un SHOES");
            Console.WriteLine("43. Editar TALLE a un SHOES");
            Console.WriteLine("");
            Console.WriteLine("x. Salir");

            Console.Write("Por favor, seleccione una opción: ");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    ListarShoes();
                    break;
                case "44":
                    Console.Clear();
                    ListadoSHOESconTalles();
                    break;
                case "40":
                    Console.Clear();
                    ListadoShoesPorTalle();
                    break;
                case "43":
                    Console.Clear();
                    EditarTalleAlZapato();
                    break;
                case "41":
                    Console.Clear();
                    ListadoTallesPorShoe();
                    break;
                case "42":
                    Console.Clear();
                    AgregarTalleAZapatos();
                    break;
                case "38":
                    Console.Clear();
                    ListadoShoesFiltroBrandGenreSport();
                    break;
                case "36":
                    Console.Clear();
                    ListadoDeBrandsEntreDosPrecios();
                    break;
                case "37":
                    Console.Clear();
                    ListadoDeGenresEntreDosPrecios();
                    break;
                case "21":
                    Console.Clear();
                    ListarTalles();
                    break;
                case "22":
                    Console.Clear();
                    AgregarTalle();
                    break;
                case "23":
                    Console.Clear();
                    BorrarTalle();
                    break;
                case "24":
                    Console.Clear();
                    EditarTalle();
                    break;
                case "25":
                    Console.Clear();
                    ListarShoesPaginado();
                    break;
                case "26":
                    Console.Clear();
                    ListarShoesPaginadoyOrdenado();
                    break;
                case "27":
                    Console.Clear();
                    ListarShoesPorBrands();
                    break;
                case "28":
                    Console.Clear();
                    ListarShoesPorGenre();
                    break;
                case "29":
                    Console.Clear();
                    ListarShoesPorSport();
                    break;
                case "2":
                    AgregarUnShoes();
                    break;
                case "3":
                    BorrarUnShoes();
                    break;
                case "4":
                    EditarUnShoes();
                    break;
                case "5":
                    ListarBrands();
                    break;
                case "30":
                    ListarBrandsPaginado();
                    break;
                case "6":
                    AgregarUnBrands();
                    break;
                case "7":
                    BorrarUnBrands();
                    break;
                case "8":
                    EditarUnBrands();
                    break;
                case "9":
                    ListarSport();
                    break;
                case "31":
                    ListarSportPaginado();
                    break;
                case "10":
                    AgregarUnSport();
                    break;
                case "11":
                    BorrarUnSport();
                    break;
                case "12":
                    EditarUnSport();
                    break;
                case "13":
                    ListarColors();
                    break;
                case "32":
                    ListarColorsPaginado();
                    break;
                case "14":
                    AgregarUnColor();
                    break;
                case "15":
                    BorrarUnColor();
                    break;
                case "16":
                    EditarUnColor();
                    break;
                case "17":
                    ListarGenres();
                    break;
                case "33":
                    ListarGenresPaginado();
                    break;
                case "18":
                    AgregarUnGenre();
                    break;
                case "19":
                    BorrarUnGenre();
                    break;
                case "20":
                    EditarUnGenre();
                    break;
                case "34":
                    ListarShoesPorColor();
                    break;
                case "35":
                    ListarSizesPaginado();
                    break;
                case "x":
                    exit = true;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void ListadoSHOESconTalles()
    {
        Console.Clear();
        var zapatosService = servicioProvider?.GetService<IServicioShoe>();
        var zapatosConTalles = zapatosService?.GetShoesConTalles();
        if (zapatosConTalles?.Count>0)
        {
            MostrarShoesConTalles(zapatosConTalles);
        }
        else
        {
            Console.WriteLine("No hay zapatos con talles asignados!");
        }
        
    }

    private static void EditarTalleAlZapato()
    {
        Console.Clear();
        var zapatosService = servicioProvider?.GetService<IServicioShoe>();
        var tallesService = servicioProvider?.GetService<IServicioSize>();
        if (zapatosService == null || tallesService == null) return;

        var zapatosConTalles = zapatosService.GetShoesConTalles();

        if (zapatosConTalles?.Count > 0)
        {
            MostrarShoesConTalles(zapatosConTalles);
            var idZapatoTalleEditar = ConsoleExtensions.ReadInt("Ingrese el ID del zapato-talle a editar: ");
            var zapatoTalleEnDB = zapatosConTalles.FirstOrDefault(z => z.ShoeSizeId == idZapatoTalleEditar);

            if (zapatoTalleEnDB != null)
            {
                Console.WriteLine("Listado de talles disponibles...");
                Console.WriteLine();
                ListarTalles();
                var talleEnDB = zapatoTalleEnDB.Size;
                Console.WriteLine($"Talle anterior: {talleEnDB.SizeNumber}.");
                var idTalleNuevo = ConsoleExtensions.ReadInt("Ingrese el id del nuevo talle: ");
                var nuevoTalle = tallesService.GetSizesPorId(idTalleNuevo);
                if (nuevoTalle == null) return;
                talleEnDB.SizeNumber = nuevoTalle.SizeNumber;
                Console.WriteLine($"Talle nuevo: {talleEnDB.SizeNumber} para el zapato {zapatoTalleEnDB.ShoeId}");

                zapatosService.AsignarTalleAZapato(zapatoTalleEnDB.Shoe,
                    nuevoTalle, zapatoTalleEnDB.QuantityInStock);
                Console.WriteLine("Talle editado!!!");
            }
            else
            {
                Console.WriteLine("Zapato-talle inexistente!!!");
            }
        }
        else
        {
            Console.WriteLine("No hay zapatos con talles asignados.");
        }

        Console.ReadLine();
    } //NO LOGRADO :(

    private static void MostrarShoesConTalles(List<ShoeSize> zapatosConTalles)
    {
        Console.WriteLine("Listado de Zapatos con talles...");
        Console.WriteLine("");
        ConsoleTable tabla = new ConsoleTable("ID", "Marca", "Genero", "Color", "Sport", "Talle");
        if (zapatosConTalles != null)
        {
            foreach (var zapatoTalle in zapatosConTalles)
            {
                var shoe = zapatoTalle.Shoe;
                var talle = zapatoTalle.Size;
                tabla.AddRow(
                    zapatoTalle.ShoeSizeId,
                    shoe.Brand?.BrandName ?? "N/A",
                    shoe.Genre?.GenreName ?? "N/A",
                    shoe.Color?.ColorName ?? "N/A",
                    shoe.Sport?.SportName ?? "N/A",
                    talle.SizeNumber
                );
            }
        }
        tabla.Options.EnableCount = false;
        tabla.Write();
        Console.WriteLine($"Cantidad de registros: {zapatosConTalles?.Count ?? 0}");
        ConsoleExtensions.EsperaEnter();
    }

    private static void ListadoShoesPorTalle()
    {
        var servicio = servicioProvider?.GetService<IServicioSize>();
        var servicioShoe = servicioProvider?.GetService<IServicioShoe>();
        Console.Clear();
        ListarTalles();
        var listaChar = servicio?.GetLista().Select(x => x.SizeId.ToString()).ToList();
        var sizeId = ConsoleExtensions.GetValidOptions("Seleccione ID de tamaño:", listaChar);
        Size? size = servicio?.GetSizesPorId(Convert.ToInt32(sizeId));
        if (size == null) return;
        Console.Clear();
        List<Shoe>? shoes = servicioShoe?.GetZapatosPorTalle(size.SizeId);
        if (shoes != null && shoes.Count > 0) //no me trae los zapatos en un talle.
        {
            Console.WriteLine("ZAPATOS");
            var tabla = new ConsoleTable("Brand", "Genre", "Color", "Sport", "Precio","Stock","TAMAÑO");
            foreach (var ss in shoes)
            {
                var shoe = servicioShoe?.GetShoePorId(ss.ShoeId);
                tabla.AddRow(shoe?.Brand?.BrandName,shoe?.Genre?.GenreName,
                    shoe?.Color?.ColorName,shoe?.Sport?.SportName,shoe?.Price,
                    servicioShoe?.GetStockShoeSize(shoe,size),size.SizeNumber);
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
        }
        Console.WriteLine("Fin del listado");
        ConsoleExtensions.EsperaEnter();
    }

    private static void ListadoTallesPorShoe()
    {
        var servicio = servicioProvider?.GetService<IServicioShoe>();
        ListarShoes();
        var shoeId = ConsoleExtensions.ReadInt("Ingrese el ID del zapato: ");
        Shoe? shoe = servicio?.GetShoePorId(shoeId);
        if (shoe != null)
        {
            Console.Clear();
            Console.WriteLine("ZAPATO SELECCIONADO: ");

            var tabla1 = new ConsoleTable("ID", "MARCA", "DEPORTE", "GENERO", "COLOR","PRECIO");
            tabla1.AddRow(shoe.ShoeId,shoe?.Brand?.BrandName,shoe?.Sport?.SportName,
            shoe?.Genre?.GenreName,shoe?.Color?.ColorName,shoe?.Price);
            tabla1.Options.EnableCount = false;
            tabla1.Write();
            if (shoe == null) return;
            List<Size>? sizes = servicio?.GetTallesPorZapato(shoe.ShoeId);
            if (sizes != null && sizes.Count() > 0)
            {
                Console.WriteLine("TALLES DISPONIBLES");

                var tablaSizes = new ConsoleTable("TALLE", "STOCK");
                foreach (var s in sizes)
                {
                    tablaSizes.AddRow(s.SizeNumber, servicio?.GetStockShoeSize(shoe, s));
                }
                tablaSizes.Options.EnableCount = false;
                tablaSizes.Write();
            }
            else
            {
                Console.WriteLine("No hay talles disponibles para este zapato.");
                Console.WriteLine();
            }

        }
        else
        {
            Console.WriteLine("El ID que ha ingresado no corresponde a ningun zapato.");
        }
        ConsoleExtensions.EsperaEnter();
    }

    private static void AgregarTalleAZapatos()
    {
        var zapatosService = servicioProvider?.GetService<IServicioShoe>();
        var tallesService = servicioProvider?.GetService<IServicioSize>();
        if (zapatosService == null || tallesService == null) return;
        //var zapatosSinTalle = zapatosService.GetShoesSinTalles();
        var zapatosSinTalle = zapatosService.GetListaDto();
        if (zapatosSinTalle?.Count > 0)
        {
            MostrarListaShoe(zapatosSinTalle);
            var opcionZapato = ConsoleExtensions.GetValidOptions("Seleccione un zapato:",
                zapatosSinTalle.Select(x => x.ShoeId.ToString()).ToList());

            var zapatoSinTalle = zapatosService.GetShoePorId(Convert.ToInt32(opcionZapato));

            // Verificar si se encontró un zapato sin talle
            if (zapatoSinTalle != null)
            {
                // Mostrar el zapato sin talle
                Console.WriteLine("Zapato:");
                Console.WriteLine($"ID: {zapatoSinTalle.ShoeId}");
                Console.WriteLine($"Modelo: {zapatoSinTalle.Model}");
                Console.WriteLine($"Marca: {zapatoSinTalle.Brand}");
                Console.WriteLine($"Deporte: {zapatoSinTalle.Sport}");
                Console.WriteLine($"Género: {zapatoSinTalle.Genre}");
                Console.WriteLine($"Color: {zapatoSinTalle.Color}");
                Console.WriteLine($"Precio: {zapatoSinTalle.Price}");
                Console.WriteLine();

                // Obtener la lista de talles
                var listaTalles = tallesService.GetLista();

                // Mostrar la lista de talles
                Console.WriteLine("Lista de talles:");
                foreach (var talle in listaTalles)
                {
                    Console.WriteLine($"ID: {talle.SizeId}, Talle: {talle.SizeNumber}");
                }
                Console.WriteLine();

                // Solicitar al usuario seleccionar un talle existente
                var opcion = ConsoleExtensions.GetValidOptions("Seleccione un talle:",
                    listaTalles.Select(x => x.SizeId.ToString()).ToList());

                // Obtener el talle seleccionado
                var talleSeleccionado = listaTalles.FirstOrDefault(x => x.SizeId.ToString() == opcion);
                if (talleSeleccionado == null) return;
                var stock = ConsoleExtensions.ReadInt("Por favor ingrese la cantidad de stock: ");
                // Asignar el talle existente al zapato
                zapatosService.AsignarTalleAZapato(zapatoSinTalle, talleSeleccionado,stock);
                Console.WriteLine("Talle asignado!!!!! alfinnnnnnnnnnnnnnnnn");
            }
            else
            {
                Console.WriteLine("No se encontraron zapatos sin talle.");
            }
        }
        else
        {
            Console.WriteLine("No hay zapatos sin talle!!!");
        }
        ConsoleExtensions.EsperaEnter();
    }

    private static void ListadoShoesFiltroBrandGenreSport()
    {
        var servicioSports = servicioProvider?.GetService<IServicioSport>();
        var servicioBrands = servicioProvider?.GetService<IServicioBrand>();
        var servicioGenres = servicioProvider?.GetService<IServicioGenre>();
        var servicioShoes = servicioProvider?.GetService<IServicioShoe>();
        ListarBrands();
        var brandId = ConsoleExtensions.ReadInt("Ingrese el ID de la marca: ");
        ListarGenres();
        var genreId = ConsoleExtensions.ReadInt("Ingrese el ID del genero: ");
        ListarSport();
        var sportId = ConsoleExtensions.ReadInt("Ingrese el ID del deporte: ");
        Genre? genre = servicioGenres?.GetGenrePorId(genreId);
        Sport? sport = servicioSports?.GetSportPorId(sportId);
        Brand? brand=servicioBrands?.GetBrandPorId(brandId);
        if (genre == null || brand==null || sport==null) return;
        var shoes = servicioShoes?.GetListaOrdenadaFiltradaEntreRangoPrecios(Orden.MenorPrecio,
            brand, sport, genre, null, null, null);
        MostrarShoesTienda(shoes);
    }

    private static void ListadoDeGenresEntreDosPrecios()
    {
        var servicioGenres = servicioProvider?.GetService<IServicioGenre>();
        var servicioShoes = servicioProvider?.GetService<IServicioShoe>();
        ListarGenres();
        var genreId = ConsoleExtensions.ReadInt("Ingrese el ID del genero: ");
        var minimo = ConsoleExtensions.ReadDecimal("Ingrese el precio Minimo:");
        var maximo = ConsoleExtensions.ReadDecimal("Ingrese el precio Maximo:");
        Genre? genre = servicioGenres?.GetGenrePorId(genreId);
        if (genre == null) return;
        var shoes = servicioShoes?.GetListaOrdenadaFiltradaEntreRangoPrecios(Orden.MenorPrecio,
            null, null, genre, null, maximo, minimo);
        MostrarShoesTienda(shoes);
    }

    private static void ListadoDeBrandsEntreDosPrecios()
    {
        var servicioBrands = servicioProvider?.GetService<IServicioBrand>();
        var servicioShoes = servicioProvider?.GetService<IServicioShoe>();
        ListarBrands();
        var brandId = ConsoleExtensions.ReadInt("Ingrese el ID de la marca: ");
        var minimo = ConsoleExtensions.ReadDecimal("Ingrese el precio Minimo:");
        var maximo = ConsoleExtensions.ReadDecimal("Ingrese el precio Maximo:");
        Brand? brand = servicioBrands?.GetBrandPorId(brandId);
        if (brand == null) return;
        var shoes = servicioShoes?.GetListaOrdenadaFiltradaEntreRangoPrecios(Orden.MenorPrecio,
            brand,null,null,null,maximo,minimo);
        MostrarShoesTienda(shoes);
    }

    private static void ListarSizesPaginado()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioSize>();
        pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 2, 10);
        var recordCount = servicio?.GetCantidad() ?? 0;
        var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

        for (int page = 0; page < pageCount; page++)
        {
            Console.Clear();
            Console.WriteLine("Listado Paginado");
            Console.WriteLine($"Página: {page + 1}");
            var lista = servicio?
                .GetListaPaginadaOrdenada(page, pageSize, Orden.AZ);
            PaginadoSizes(servicio,lista);
        }
        Console.WriteLine("Fin del Listado");
    }

    private static void ListarShoesPorColor()
    {
        Console.Clear();
        ListarColors();
        var servicioColor = servicioProvider?.GetService<IServicioColor>();
        Color? color;var listaChar = servicioColor?.GetLista().Select(x => x.ColorId.ToString()).ToList();
        var colorId = ConsoleExtensions.GetValidOptions("Seleccione el tipo de Color:", listaChar);
        color = servicioColor?.GetColorPorId(Convert.ToInt32(colorId));
        List<Shoe>? lista = servicioColor?.GetShoes(color);
        Console.WriteLine("Listado de Shoes");
        MostrarShoesTienda(lista);
        Console.WriteLine("Fin del Listado");
    }

    private static void EditarTalle()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioSize>();
        Console.WriteLine("Editar Size");
        ListarTalles();
        var idSizeEditar = ConsoleExtensions.ReadInt("Ingrese el ID a editar: ");
        var sizeEnDB = servicio?.GetSizesPorId(idSizeEditar);
        if (sizeEnDB != null)
        {
            Console.WriteLine($"Size anterior: {sizeEnDB.SizeNumber}.");
            var nuevoTalle = ConsoleExtensions.ReadDecimal("Ingrese el nuevo Talle: ");
            sizeEnDB.SizeNumber = nuevoTalle;
            if (servicio!=null)
            {
                if (!servicio.Existe(sizeEnDB))
                {
                    servicio?.Guardar(sizeEnDB);
                    Console.WriteLine("Talle editado!!!");
                }
                else
                {
                    Console.WriteLine("Registro existente SE CANCELA LA EDICION!!!");
                }
            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }
        }
        else
        {
            Console.WriteLine("Talle inexistente!!!");
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void BorrarTalle()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioSize>();
        Console.WriteLine("Eliminar Size");
        ListarTalles();
        var sizeIdDelete = ConsoleExtensions.ReadInt("Ingrese ID a borrar: ");
        try
        {
            var size = servicio?.GetSizesPorId(sizeIdDelete);
            if (size != null)
            {
                if (servicio != null)
                {
                    if (!servicio.EstaRelacionado(size))
                    {
                        servicio.Borrar(size);
                        Console.WriteLine("Registro borrado correctamente!!");
                    }
                    else
                    {
                        Console.WriteLine("Registro relacionado, no se pudo borrar!!");
                    }
                }
                else
                {
                    Console.WriteLine("Servicio no disponible!!");
                }
            }
            else
            {
                Console.WriteLine("Registro inexistente!!");
            }
        }
        catch (Exception)
        {

            throw;
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void AgregarTalle()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioSize>();
        Console.WriteLine("Ingreso de un nuevo Talle");
        var nuevoSizeNumber = ConsoleExtensions.ReadDecimal("Ingrese un nuevo Size: ");
        Size size = new Size()
        {
            SizeNumber = nuevoSizeNumber
        };
        try
        {
            if (servicio != null)
            {
                if (!servicio.Existe(size))
                {
                    servicio.Guardar(size);
                    Console.WriteLine("Registro agregado correctamente!!");
                }
                else
                {
                    Console.WriteLine("Registro existente!!!");
                }
            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }
        }
        catch (Exception)
        {

            throw;
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void ListarTalles()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioSize>();
        var lista = servicio?.GetLista();
        PaginadoSizes(servicio, lista);
    }

    private static void PaginadoSizes(IServicioSize? servicio, List<Size>? lista)
    {
        Console.WriteLine("Listado de Talles en la tienda");
        ConsoleTable tabla = new ConsoleTable("ID", "SizeNumber");
        if (lista != null)
        {
            foreach (var size in lista)
            {
                tabla.AddRow(size.SizeId, size.SizeNumber);
            }
        }
        tabla.Options.EnableCount = false;
        tabla.Write();
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        ConsoleExtensions.EsperaEnter();
    }

    private static void ListarSportPaginado()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioSport>();
        pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 2, 10);
        var recordCount = servicio?.GetCantidad() ?? 0;
        var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

        for (int page = 0; page < pageCount; page++)
        {
            Console.Clear();
            Console.WriteLine("Listado Paginado");
            Console.WriteLine($"Página: {page + 1} de {pageCount}");
            var lista = servicio?
                .GetListaPaginadaOrdenada(page, pageSize, Orden.AZ);
            PaginadoSports(servicio, lista);
        }
        Console.WriteLine("Fin del Listado");
    }

    private static void PaginadoSports(IServicioSport? servicio, List<Sport>? lista)
    {
        Console.WriteLine("Listado de Sports en la tienda");
        ConsoleTable tabla = new ConsoleTable("ID", "SportName");
        if (lista != null)
        {
            foreach (var sport in lista)
            {
                tabla.AddRow(sport.SportId, sport.SportName);
            }
        }
        tabla.Options.EnableCount = false;
        tabla.Write();
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        ConsoleExtensions.EsperaEnter();
    }

    private static void ListarGenresPaginado()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioGenre>();
        pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 2, 10);
        var recordCount = servicio?.GetCantidad() ?? 0;
        var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

        for (int page = 0; page < pageCount; page++)
        {
            Console.Clear();
            Console.WriteLine("Listado Paginado");
            Console.WriteLine($"Página: {page + 1} de {pageCount}");
            var lista = servicio?
                .GetListaPaginadaOrdenada(page, pageSize, Orden.AZ);
            PaginadoGenres(servicio, lista);
        }
        Console.WriteLine("Fin del Listado");
    }

    private static void PaginadoGenres(IServicioGenre? servicio, List<Genre>? lista)
    {
        Console.WriteLine("Listado de Genres en la tienda");
        ConsoleTable tabla = new ConsoleTable("ID", "GenreName");
        if (lista != null)
        {
            foreach (var genre in lista)
            {
                tabla.AddRow(genre.GenreId, genre.GenreName);
            }
        }
        tabla.Options.EnableCount = false;
        tabla.Write();
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        ConsoleExtensions.EsperaEnter();
    }

    private static void ListarColorsPaginado()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioColor>();
        pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 2, 10);
        var recordCount = servicio?.GetCantidad() ?? 0;
        var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

        for (int page = 0; page < pageCount; page++)
        {
            Console.Clear();
            Console.WriteLine("Listado Paginado");
            Console.WriteLine($"Página: {page + 1} de {pageCount}");
            var lista = servicio?
                .GetListaPaginadaOrdenada(page, pageSize, Orden.AZ);
            PaginadoColors(servicio, lista);
        }
        Console.WriteLine("Fin del Listado");
    }

    private static void PaginadoColors(IServicioColor? servicio, List<Color>? lista)
    {
        Console.WriteLine("Listado de Colors en la tienda");
        ConsoleTable tabla = new ConsoleTable("ID", "ColorName");
        if (lista != null)
        {
            foreach (var color in lista)
            {
                tabla.AddRow(color.ColorId, color.ColorName);
            }
        }
        tabla.Options.EnableCount = false;
        tabla.Write();
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        ConsoleExtensions.EsperaEnter();
    }

    private static void ListarBrandsPaginado()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioBrand>();
        pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 2, 10);
        var recordCount = servicio?.GetCantidad() ?? 0;
        var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

        for (int page = 0; page < pageCount; page++)
        {
            Console.Clear();
            Console.WriteLine("Listado Paginado");
            Console.WriteLine($"Página: {page + 1} de {pageCount}");
            var lista = servicio?
                .GetListaPaginadaOrdenada(page, pageSize, Orden.AZ);
            PaginadoBrands(servicio,lista);
        }
        Console.WriteLine("Fin del Listado");
    }

    private static void ListarShoesPorSport()
    {
        Console.Clear();
        ListarSport();
        var servicioSports = servicioProvider?.GetService<IServicioSport>();
        Sport? sport;
        var listaChar = servicioSports? .GetLista().Select(x => x.SportId.ToString()).ToList();
        var sportId = ConsoleExtensions.GetValidOptions("Seleccione el tipo de Sport:", listaChar);
        sport = servicioSports?.GetSportPorId(Convert.ToInt32(sportId));
        List<Shoe>? lista = servicioSports?.GetShoes(sport);
        Console.WriteLine("Listado de Shoes");
        MostrarShoesTienda(lista);
        Console.WriteLine("Fin del Listado");
    }

    private static void ListarShoesPorGenre()
    {
        Console.Clear();
        ListarGenres();
        var servicioGenres = servicioProvider?.GetService<IServicioGenre>();
        Genre? genre;
        var listaChar = servicioGenres?.GetLista().Select(x => x.GenreId.ToString()).ToList();
        var genreId = ConsoleExtensions .GetValidOptions("Seleccione el tipo de Genre:", listaChar);
        genre = servicioGenres?.GetGenrePorId(Convert.ToInt32(genreId));
        List<Shoe>? lista = servicioGenres?.GetShoes(genre);
        Console.WriteLine("Listado de Shoes");
        MostrarShoesTienda(lista);
        Console.WriteLine("Fin del Listado");
    }

    private static void ListarShoesPorBrands()
    {
        Console.Clear();
        ListarBrands();
        var servicioBrands = servicioProvider?.GetService<IServicioBrand>();
        Brand? brand;
        var listaChar = servicioBrands?.GetLista() .Select(x => x.BrandId.ToString()).ToList();
        var brandId = ConsoleExtensions.GetValidOptions("Seleccione el tipo de Brand:", listaChar);
        brand = servicioBrands?.GetBrandPorId(Convert.ToInt32(brandId));
        List<Shoe>? lista = servicioBrands?.GetShoes(brand);
        MostrarShoesTienda(lista);
        Console.WriteLine("Fin del Listado");
    }

    private static void MostrarShoesTienda(List<Shoe>? lista)
    {
        Console.Clear();
        Console.WriteLine("Listado de Shoes");
        ConsoleTable tabla = new ConsoleTable("ID", "Brand", "Sport","Genre", "Color","Price");
        if (lista != null)
        {
            foreach (var shoe in lista)
            {
                tabla.AddRow(shoe.ShoeId, shoe.Brand?.BrandName, shoe.Sport?.SportName,
                    shoe.Genre?.GenreName, shoe.Color?.ColorName, shoe.Price);
            }
        }
        tabla.Options.EnableCount = false;
        tabla.Write();
        ConsoleExtensions.EsperaEnter();
    }

    private static void ListarShoesPaginadoyOrdenado()
    {
        Console.Clear();
        Console.WriteLine("Listado de Shoes Ordenada. Elija...");
        var orden = ConsoleExtensions.GetValidOptions("(A)Z (Z)A (1)2 (2)1:", new List<string> { "A", "Z", "1", "2" });
        var servicio = servicioProvider?.GetService<IServicioShoe>();
        pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 2, 10);
        var recordCount = servicio?.GetCantidad() ?? 0;
        var pageCount = CalcularCantidadPaginas(recordCount, pageSize);
        
        for (int page = 0; page < pageCount; page++)
        {
            Console.Clear();
            Console.WriteLine($"Total de {recordCount} registros");
            Console.WriteLine($"Pagina {page+1} de {pageCount}");
            switch (orden)
            {
                case "A":
                    MostrarListaShoe(servicio?.GetListaPaginadaOrdenada(page, pageSize, Orden.AZ));
                    break;
                case "Z":
                    MostrarListaShoe(servicio?.GetListaPaginadaOrdenada(page, pageSize, Orden.ZA));
                    break;
                case "1":
                    MostrarListaShoe(servicio?.GetListaPaginadaOrdenada(page, pageSize, Orden.MenorPrecio));
                    break;
                default:
                    MostrarListaShoe(servicio?.GetListaPaginadaOrdenada(page, pageSize, Orden.MayorPrecio));
                    break;
            }

        }
    }

    private static void ListarShoesPaginado()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioShoe>();
        pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 2, 10);
        var recordCount = servicio?.GetCantidad() ?? 0;
        var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

        for (int page = 0; page < pageCount; page++)
        {
            Console.Clear();
            Console.WriteLine($"Listado Paginado.. {recordCount} registros");
            Console.WriteLine($"Página: {page + 1} de {pageCount}");
            var listaPaginada = servicio?.GetListaPaginadaOrdenada(page, pageSize);
            MostrarListaShoe(listaPaginada);
        }
        Console.WriteLine("Fin del Listado");
    }

    private static void MostrarListaShoe(List<ShoeListDto>? listaPaginada)
    {
        Console.WriteLine("Listado de Shoes en la tienda");
        ConsoleTable tabla = new ConsoleTable("ID", "Brand", "Sport",
            "Genre", "Color", "Price", "Descripcion");
        if (listaPaginada != null)
        {
            foreach (var shoe in listaPaginada)
            {
                tabla.AddRow(shoe.ShoeId, shoe.Brand, shoe.Sport,
                shoe.Genre, shoe.Color,shoe.Price,shoe.Description);
            }
        }
        tabla.Options.EnableCount = false;
        tabla.Write();
        ConsoleExtensions.EsperaEnter();
    }

    private static int CalcularCantidadPaginas(int cantidadRegistros,
            int cantidadPorPagina)
    {
        if (cantidadRegistros < cantidadPorPagina)
        {
            return 1;
        }
        else if (cantidadRegistros % cantidadPorPagina == 0)
        {
            return cantidadRegistros / cantidadPorPagina;
        }
        else
        {
            return cantidadRegistros / cantidadPorPagina + 1;
        }
    }

    private static void EditarUnGenre()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioGenre>();
        Console.WriteLine("Editar Genre");
        ListarGenres();
        var idGenreEditar = ConsoleExtensions.ReadInt("Ingrese el ID a editar: ");
        var genreEnDB = servicio?.GetGenrePorId(idGenreEditar);
        if (genreEnDB != null)
        {
            Console.WriteLine($"Genre anterior: {genreEnDB.GenreName}.");
            var nuevoName = ConsoleExtensions.ReadString("Ingrese el nuevo Genero: ");
            genreEnDB.GenreName = nuevoName;
            servicio?.Guardar(genreEnDB);
            Console.WriteLine("Genero editado!!!");
        }
        else
        {
            Console.WriteLine("Genero inexistente!!!");
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void BorrarUnGenre()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioGenre>();
        Console.WriteLine("Eliminar Genre");
        ListarGenres();
        var genreIdDelete = ConsoleExtensions.ReadInt("Ingrese ID a borrar: ");
        try
        {
            var genre = servicio?.GetGenrePorId(genreIdDelete);
            if (genre != null)
            {
                if (servicio != null)
                {
                    if (!servicio.EstaRelacionado(genre))
                    {
                        servicio.Borrar(genre);
                        Console.WriteLine("Registro borrado correctamente!!");
                    }
                    else
                    {
                        Console.WriteLine("Registro relacionado, no se pudo borrar!!");
                    }
                }
                else
                {
                    Console.WriteLine("Servicio no disponible!!");
                }
            }
            else
            {
                Console.WriteLine("Registro inexistente!!");
            }
        }
        catch (Exception)
        {

            throw;
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void AgregarUnGenre()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioGenre>();
        Console.WriteLine("Ingreso de un nuevo Genre");
        var nuevoGenreName = ConsoleExtensions.ReadString("Ingrese un nuevo Genre: ");
        Genre genre = new Genre()
        {
            GenreName = nuevoGenreName
        };
        try
        {
            if (servicio != null)
            {
                if (!servicio.Existe(genre))
                {
                    servicio.Guardar(genre);
                    Console.WriteLine("Registro agregado correctamente!!");
                }
                else
                {
                    Console.WriteLine("Registro existente!!!");
                }
            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }
        }
        catch (Exception)
        {

            throw;
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void ListarGenres()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioGenre>();
        var lista = servicio?.GetLista();

        Console.WriteLine("Listado de Genre en la tienda");
        ConsoleTable tabla = new ConsoleTable("ID", "GenreName");
        if (lista != null)
        {
            foreach (var genre in lista)
            {
                tabla.AddRow(genre.GenreId, genre.GenreName);
            }
        }
        tabla.Options.EnableCount = false;
        tabla.Write();
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void EditarUnColor()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioColor>();
        Console.WriteLine("Editar Color");
        ListarColors();
        var idColorEditar = ConsoleExtensions.ReadInt("Ingrese el ID a editar: ");
        var colorEnDB = servicio?.GetColorPorId(idColorEditar);
        if (colorEnDB != null)
        {
            Console.WriteLine($"Color anterior: {colorEnDB.ColorName}.");
            var nuevoName = ConsoleExtensions.ReadString("Ingrese el nuevo color: ");
            colorEnDB.ColorName = nuevoName;
            servicio?.Guardar(colorEnDB);
            Console.WriteLine("Color editado!!!");
        }
        else
        {
            Console.WriteLine("Color inexistente!!!");
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void BorrarUnColor()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioColor>();
        Console.WriteLine("Eliminar Color");
        ListarColors();
        var colorIdDelete = ConsoleExtensions.ReadInt("Ingrese ID a borrar: ");
        try
        {
            var color = servicio?.GetColorPorId(colorIdDelete);
            if (color != null)
            {
                if (servicio != null)
                {
                    if (!servicio.EstaRelacionado(color))
                    {
                        servicio.Borrar(color);
                        Console.WriteLine("Registro borrado correctamente!!");
                    }
                    else
                    {
                        Console.WriteLine("Registro relacionado, no se pudo borrar!!");
                    }
                }
                else
                {
                    Console.WriteLine("Servicio no disponible!!");
                }
            }
            else
            {
                Console.WriteLine("Registro inexistente!!");
            }
        }
        catch (Exception)
        {

            throw;
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void AgregarUnColor()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioColor>();
        Console.WriteLine("Ingreso de un nuevo Color");
        var nuevoColorName = ConsoleExtensions.ReadString("Ingrese un nuevo Color: ");
        Color color = new Color()
        {
            ColorName = nuevoColorName
        };
        try
        {
            if (servicio != null)
            {
                if (!servicio.Existe(color))
                {
                    servicio.Guardar(color);
                    Console.WriteLine("Registro agregado correctamente!!");
                }
                else
                {
                    Console.WriteLine("Registro existente!!!");
                }
            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }
        }
        catch (Exception)
        {

            throw;
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void ListarColors()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioColor>();
        var lista = servicio?.GetLista();

        Console.WriteLine("Listado de Colors en la tienda");
        ConsoleTable tabla = new ConsoleTable("ID", "ColorName");
        if (lista != null)
        {
            foreach (var color in lista)
            {
                tabla.AddRow(color.ColorId, color.ColorName);
            }
        }
        tabla.Options.EnableCount = false;
        tabla.Write();
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void EditarUnSport()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioSport>();
        Console.WriteLine("Editar Sport");
        ListarSport();
        var idSportEditar = ConsoleExtensions.ReadInt("Ingrese el ID a editar: ");
        var sportEnDB = servicio?.GetSportPorId(idSportEditar);
        if (sportEnDB != null)
        {
            Console.WriteLine($"Sport anterior: {sportEnDB.SportName}.");
            var nuevoName = ConsoleExtensions.ReadString("Ingrese el nuevo deporte: ");
            sportEnDB.SportName = nuevoName;
            servicio?.Guardar(sportEnDB);
            Console.WriteLine("Sport editado!!!");
        }
        else
        {
            Console.WriteLine("Deporte inexistente!!!");
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void BorrarUnSport()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioSport>();
        Console.WriteLine("Eliminar Sport");
        ListarSport();
        var sportIdDelete = ConsoleExtensions.ReadInt("Ingrese ID a borrar: ");
        try
        {
            var sport = servicio?.GetSportPorId(sportIdDelete);
            if (sport != null)
            {
                if (servicio != null)
                {
                    if (!servicio.EstaRelacionado(sport))
                    {
                        servicio.Borrar(sport);
                        Console.WriteLine("Registro borrado correctamente!!");
                    }
                    else
                    {
                        Console.WriteLine("Registro relacionado, no se pudo borrar!!");
                    }
                }
                else
                {
                    Console.WriteLine("Servicio no disponible!!");
                }
            }
            else
            {
                Console.WriteLine("Registro inexistente!!");
            }
        }
        catch (Exception)
        {

            throw;
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void AgregarUnSport()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioSport>();
        Console.WriteLine("Ingreso de un nuevo Sport");
        var nuevoSporName = ConsoleExtensions.ReadString("Ingrese un nuevo Sport: ");
        Sport sport = new Sport()
        {
            SportName = nuevoSporName
        };
        try
        {
            if (servicio != null)
            {
                if (!servicio.Existe(sport))
                {
                    servicio.Guardar(sport);
                    Console.WriteLine("Registro agregado correctamente!!");
                }
                else
                {
                    Console.WriteLine("Registro existente!!!");
                }
            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }
        }
        catch (Exception)
        {

            throw;
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void ListarSport()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioSport>();
        var lista = servicio?.GetLista();

        Console.WriteLine("Listado de Sports en la tienda");
        ConsoleTable tabla = new ConsoleTable("ID", "SportName");
        if (lista != null)
        {
            foreach (var sport in lista)
            {
                tabla.AddRow(sport.SportId, sport.SportName);
            }
        }
        tabla.Options.EnableCount = false;
        tabla.Write();
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void EditarUnBrands()
    {
        Console.Clear();
        var servicio=servicioProvider?.GetService<IServicioBrand>();
        Console.WriteLine("Editar Brand");
        ListarBrands();
        var idBrandEditar = ConsoleExtensions.ReadInt("Ingrese el ID a editar: ");
        var brandEnDB=servicio?.GetBrandPorId(idBrandEditar);
        if (brandEnDB!=null)
        {
            Console.WriteLine($"Brand anterior: {brandEnDB.BrandName}.");
            var nuevoName = ConsoleExtensions.ReadString("Ingrese la nueva marca: ");
            brandEnDB.BrandName=nuevoName;
            servicio?.Guardar(brandEnDB);
            Console.WriteLine("Brand editado!!!");
        }
        else
        {
            Console.WriteLine("Marca inexistente!!!");
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void BorrarUnBrands()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioBrand>();
        Console.WriteLine("Eliminar Brand");
        ListarBrands();
        var brandIdDelete = ConsoleExtensions.ReadInt("Ingrese ID a borrar: ");
        try
        {
            var brand=servicio?.GetBrandPorId(brandIdDelete);
            if (brand!=null)
            {
                if (servicio!=null)
                {
                    if (!servicio.EstaRelacionado(brand))
                    {
                        servicio.Borrar(brand);
                        Console.WriteLine("Registro borrado correctamente!!");
                    }
                    else
                    {
                        Console.WriteLine("Registro relacionado, no se pudo borrar!!");
                    }
                }
                else
                {
                    Console.WriteLine("Servicio no disponible!!");
                }
            }
            else
            {
                Console.WriteLine("Registro inexistente!!");
            }
        }
        catch (Exception)
        {

            throw;
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void AgregarUnBrands()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioBrand>();
        Console.WriteLine("Ingreso de un nuevo Brands");
        var nuevoBrandName = ConsoleExtensions.ReadString("Ingrese un nuevo Brand: ");
        Brand brand = new Brand()
        {
            BrandName = nuevoBrandName
        };
        try
        {
            if (servicio !=null)
            {
                if (!servicio.Existe(brand))
                {
                    servicio.Guardar(brand);
                    Console.WriteLine("Registro agregado correctamente!!");
                }
                else
                {
                    Console.WriteLine("Registro existente!!!");
                }
            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }
        }
        catch (Exception)
        {

            throw;
        }
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        Console.ReadLine();
    }

    private static void ListarBrands()
    {
        Console.Clear();
        var servicio = servicioProvider?.GetService<IServicioBrand>();
        var lista = servicio?.GetLista();
        PaginadoBrands(servicio, lista);
    }

    private static void PaginadoBrands(IServicioBrand? servicio, List<Brand>? lista)
    {
        Console.WriteLine("Listado de Brands en la tienda");
        ConsoleTable tabla = new ConsoleTable("ID", "BrandName");
        if (lista != null)
        {
            foreach (var brand in lista)
            {
                tabla.AddRow(brand.BrandId, brand.BrandName);
            }
        }
        tabla.Options.EnableCount = false;
        tabla.Write();
        Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
        ConsoleExtensions.EsperaEnter();
    }

    private static void EditarUnShoes()
    {
        var servicio = servicioProvider?.GetService<IServicioShoe>();
        Console.Clear();
        Console.WriteLine("Ingreso Shoe a borrar");
        ListarShoes();
        var shoeId = ConsoleExtensions.ReadInt("Ingrese el ID del shoe a editar:");
        var shoe = servicio?.GetShoePorId(shoeId);
        if (shoe == null)
        {
            Console.WriteLine("Shoe no encontrada.");
            return;
        }
        Console.WriteLine("Shoe seleccionado...");
        Console.WriteLine($"ShoeId: {shoe.ShoeId}");
        Console.WriteLine($"Brand: {shoe.Brand?.BrandName}");
        Console.WriteLine($"Color: {shoe.Color?.ColorName}");
        Console.WriteLine($"Genre: {shoe.Genre?.GenreName}");
        Console.WriteLine($"Sport: {shoe.Sport?.SportName}");
        Console.WriteLine($"Modelo: {shoe.Model}");
        Console.WriteLine($"Descripcion: {shoe.Description}");
        Console.WriteLine($"Precio: {shoe.Price}");

        Console.WriteLine("A continuacion editaremos....");
        shoe.Model = ConsoleExtensions.ReadString("Ingrese el nuevo Model: ");
        shoe.Description = ConsoleExtensions.ReadString("Ingrese el nuevo Descripcion: ");
        shoe.Price = ConsoleExtensions.ReadDecimal("Ingrese el nuevo Price: ");

        //falta preguntar si existe.

        if (servicio != null)
        {
            if (!servicio.Existe(shoe))
            {
                servicio.Guardar(shoe);
                Console.WriteLine("Shoe editado correctamente!!!");
            }
            else
            {
                Console.WriteLine("Registro Duplicado!!!");
            }
        }
        else
        {
            Console.WriteLine("Error: El servicio de plantas es nulo.");
        }
        Console.ReadLine();



        //try
        //{
        //    servicio?.Guardar(shoe);
        //    Console.WriteLine("Registro editado correctamente!!!!");
        //}
        //catch (Exception)
        //{
        //    Console.WriteLine("Error!");
        //}
    }

    private static void BorrarUnShoes()
    {
        var servicio = servicioProvider?.GetService<IServicioShoe>();
        Console.Clear();
        Console.WriteLine("Ingreso Shoe a borrar");
        ListarShoes();
        var listaChar = servicio?.GetLista().Select(x => x.ShoeId.ToString()).ToList();
        var shoeId = ConsoleExtensions.GetValidOptions("Ingrese un ID del Shoe:", listaChar);
        try
        {
            var shoe = servicio?.GetShoePorId(Convert.ToInt32(shoeId));
            if (shoe != null)
            {
                if (servicio != null)
                {
                    servicio.Borrar(shoe);
                    Console.WriteLine("Registro borrado!!!");
                }
                else
                {
                    throw new Exception("Servicio no disponible");
                }
            }
            else
            {
                Console.WriteLine("Shoe inexistente!!!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); ;
        }
        Console.ReadLine();
    }

    private static void AgregarUnShoes()
    {
        Console.Clear();
        var servicioBrand = servicioProvider?.GetService<IServicioBrand>();
        var servicioColor = servicioProvider?.GetService<IServicioColor>();
        var servicioGenre = servicioProvider?.GetService<IServicioGenre>();
        var servicioSport = servicioProvider?.GetService<IServicioSport>();
        var servicioShoes = servicioProvider?.GetService<IServicioShoe>();
        Brand? brand;
        Color? color;
        Genre? genre;
        Sport? sport;
        ListarShoes();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Agregar nuevo Shoe");
        Console.Clear();
        Console.WriteLine("Brands en la tienda");
        ListarBrands();
        var listaBrandsChar = servicioBrand?.GetLista().Select(x => x.BrandId.ToString()).ToList();
        var brandId = ConsoleExtensions.GetValidOptions("Seleccione Brand (N para nuevo):", listaBrandsChar);
        if (brandId.ToUpper() == "N")
        {
            brandId = "0";
            Console.WriteLine("Ingreso de nuevo Brand");
            var nuevoBrandName = ConsoleExtensions.ReadString("Ingrese un nuevo brandName:");
            brand = new Brand() {BrandId = 0,BrandName = nuevoBrandName};
        }
        else
        {
            brand = servicioBrand?.GetBrandPorId(Convert.ToInt32(brandId));
        }
        Console.Clear();
        Console.WriteLine("Colors en la tienda");
        ListarColors();
        var listaColorsChar = servicioColor?.GetLista().Select(x => x.ColorId.ToString()).ToList();
        var colorId = ConsoleExtensions.GetValidOptions("Seleccione Color (N para nuevo):", listaColorsChar);
        if (colorId.ToUpper() == "N")
        {
            colorId = "0";
            Console.WriteLine("Ingreso de nuevo Color");
            var nuevoColorName = ConsoleExtensions.ReadString("Ingrese un nuevo colorName:");
            color = new Color() { ColorId = 0, ColorName = nuevoColorName };
        }
        else
        {
            color = servicioColor?.GetColorPorId(Convert.ToInt32(colorId));
        }
        Console.Clear();
        Console.WriteLine("Generos en la tienda");
        ListarGenres();
        var listaGenresChar = servicioGenre?.GetLista().Select(x => x.GenreId.ToString()).ToList();
        var genreId = ConsoleExtensions.GetValidOptions("Seleccione Genre (N para nuevo):", listaGenresChar);
        if (genreId.ToUpper() == "N")
        {
            genreId = "0";
            Console.WriteLine("Ingreso de nuevo Genre");
            var nuevoGenreName = ConsoleExtensions.ReadString("Ingrese un nuevo genreName:");
            genre = new Genre() { GenreId = 0, GenreName = nuevoGenreName };
        }
        else
        {
            genre = servicioGenre?.GetGenrePorId(Convert.ToInt32(genreId));
        }
        Console.Clear();
        Console.WriteLine("Sports en la tienda");
        ListarSport();
        var listaSportsChar = servicioSport?.GetLista().Select(x => x.SportId.ToString()).ToList();
        var sportId = ConsoleExtensions.GetValidOptions("Seleccione Sport (N para nuevo):", listaSportsChar);
        if (sportId.ToUpper() == "N")
        {
            sportId = "0";
            Console.WriteLine("Ingreso de nuevo Sport");
            var nuevoSportName = ConsoleExtensions.ReadString("Ingrese un nuevo SportName:");
            sport = new Sport() { SportId = 0, SportName = nuevoSportName };
        }
        else
        {
            sport = servicioSport?.GetSportPorId(Convert.ToInt32(sportId));
        }
        Console.Clear();
        ListarShoes();
        Console.WriteLine("Por ahora vas ingresando los siguientes datos");
        Console.WriteLine($"Brand: {brand?.BrandName}");
        Console.WriteLine($"Color: {color?.ColorName}");
        Console.WriteLine($"Genre: {genre?.GenreName}");
        Console.WriteLine($"Sport: {sport?.SportName}");
        Console.WriteLine("Ingrese los proximos datos de los Shoe:");
        var descripcion = ConsoleExtensions.ReadString("Descripción:");
        var modelo = ConsoleExtensions.ReadString("Modelo:");
        var precio = ConsoleExtensions.ReadDecimal("Precio:");

        var shoe = new Shoe
        {
            Model = modelo,
            Description=descripcion,
            Price=precio,
            BrandId= Convert.ToInt32(brandId),
            ColorId = Convert.ToInt32(colorId),
            GenreId = Convert.ToInt32(genreId),
            SportId = Convert.ToInt32(sportId),
            Brand=brand,
            Color=color,
            Genre=genre,
            Sport=sport
        };
        if (servicioShoes != null)
        {
            if (!servicioShoes.Existe(shoe))
            {
                servicioShoes.Guardar(shoe);
                Console.WriteLine("Shoe agregado correctamente!!!");
            }
            else
            {
                Console.WriteLine("Registro Duplicado!!!");
            }
        }
        else
        {
            Console.WriteLine("Error: El servicio de plantas es nulo.");
        }
        Console.ReadLine();
    }

    private static void ListarShoes()
    {
        Console.Clear();
        var servicio=servicioProvider?.GetService<IServicioShoe>();
        var lista = servicio?.GetListaDto();
        Console.WriteLine("Listado de Shoes en la tienda");
        ConsoleTable tabla = new ConsoleTable("ID", "Brand", "Sport",
            "Genre", "Color", "Modelo", "Price", "Descripcion");
        if (lista!=null)
        {
            foreach (var shoe in lista)
            {
                tabla.AddRow(shoe.ShoeId, shoe.Brand, shoe.Sport,
                    shoe.Genre, shoe.Color, shoe.Model, shoe.Price,
                    shoe.Description);
            }
        }
        tabla.Options.EnableCount = false;
        tabla.Write();
        Console.ReadLine();
    }


}
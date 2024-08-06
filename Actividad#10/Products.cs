using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Actividad_10
{
    public class Products
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Products(string name, string type)
        {
            Name = name;
            Type = type;

        }
        public static void AddProduct(ref List<Products> productsList)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el Nombre del Producto");
            string name = Console.ReadLine();
            int optionAP = MenuAddProduct();
            string type = "";
            switch (optionAP)
            {
                case 1:
                    type = "Teléfono";
                    productsList.Add(new Phones(name, type));
                    Console.WriteLine("\nProducto Agregado con Éxito");
                    Console.ReadKey();
                    break;
                case 2:
                    type = "Ordenador";
                    productsList.Add(new Computers(name, type));
                    Console.WriteLine("\nProducto Agregado con Éxito");
                    Console.ReadKey();
                    break;
                case 3:
                    type = "Tablet";
                    productsList.Add(new Tablets(name, type));
                    Console.WriteLine("\nProducto Agregado con Éxito");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("\nIngrese una Opción Válida (1 - 3)");
                    Console.ReadKey();
                    break;
            }
        }
        public static int MenuAddProduct()
        {
            Console.WriteLine("\n¿Qué Tipo de Producto es?");
            Console.WriteLine("1. Teléfono");
            Console.WriteLine("2. Ordenador");
            Console.WriteLine("3. Tablet");
            Console.WriteLine("Seleccione una Opción Válida");
            int optionMAP = int.Parse(Console.ReadLine());
            return optionMAP;
        }
        public static void ListProduct(ref List<Products> productsList)
        {
            if (productsList.Count == 0)
            {
                Console.WriteLine("\nNo Existen Productos Registrados");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("La Lista de los Productos Registrados es:");
                foreach (Products product in productsList)
                {
                    Console.WriteLine($"\nNombre: {product.Name}");
                    Console.WriteLine($"\nTipo: {product.Type}");
                    Console.WriteLine("\n-------------------");
                }
                Console.ReadKey();
            }
        }
        public static void SearchProduct(ref List<Products> productsList)
        {
            if (productsList.Count == 0)
            {
                Console.WriteLine("\nNo Existen Productos Registrados");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ingrese el Nombre del Producto a Buscar");
                string name = Console.ReadLine();
                Products searchProduct = productsList.Find(p => p.Name == name);
                if (searchProduct != null)
                {
                    Console.WriteLine("\nProducto Encontrado");
                    foreach (Products product in productsList)
                    {
                        if (product.Name == name)
                        {
                            Console.WriteLine($"\nNombre: {product.Name}");
                            Console.WriteLine($"\nTipo: {product.Type}");
                            Console.ReadKey();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nEl Producto No Existe");
                    Console.ReadKey();
                }
            }
        }
    }
}
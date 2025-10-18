using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatronesU2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulación de procesos industriales automatizados - Materiales Reciclables");

            var pool = new PoolMateriales();
            var control = ControlMaestroProduccion.Instancia;

            var listaMateriales = new List<string>
            {
                "Plastico", "Papel", "Tela", "Metal", "Carton"
            };

            var materialesProcesados = new List<Material>();

            foreach (var nombre in listaMateriales )
            {
                var material = pool.Obtener();
                material.Nombre = nombre;
                material.EsReciclable = control.EsReciclable(nombre);

                materialesProcesados.Add(material);
            }

            Console.WriteLine("Materiales presentados");
            foreach(var m in materialesProcesados)
            {
                Console.WriteLine($"- {m.Nombre}");
            }
            Console.WriteLine("");
            Console.WriteLine("Estado de los materiales");
            foreach(var m in materialesProcesados)
            {
                string estado;
                if(m.EsReciclable)
                {
                    estado = "Reciclable";                  
                }
                else
                {
                    estado = "No reciclable";
                }
                Console.WriteLine($"- {m.Nombre}: {estado}");
            }
            Console.WriteLine("Proceso finalizado");
            Console.ReadKey();
        }
    }
}

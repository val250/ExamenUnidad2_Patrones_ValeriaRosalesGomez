﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatronesU2
{
    public class PoolMateriales
    {
        private readonly Stack<Material> _materialesDisponibles = new Stack<Material>();

        public Material Obtener()
        {
            if (_materialesDisponibles.Count > 0)
            {
                return _materialesDisponibles.Pop();
            }
            else
            {
                return new Material();
            }
        }

        public void Devolver(Material material)
        {
            material.Iniciar();
            _materialesDisponibles.Push(material);
        }
    }
}

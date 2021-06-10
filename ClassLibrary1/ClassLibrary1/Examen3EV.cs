namespace Examen3EV_NS
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Clase <see cref="EstadisticasNotasARA2021" /> que se utiliza para calcular las estadisticas de un conjunto de notas.
    /// </summary>
    public class EstadisticasNotasARA2021  // esta clase nos calcula las estadísticas de un conjunto de notas 
    {
        /// <summary>
        /// Número que corresponde al total de notas que son suspensas.
        /// </summary>
        private int suspensos;

        /// <summary>
        /// Númere que corresponde al total de notas que son aprobados.
        /// </summary>
        private int aprobados;

        /// <summary>
        /// Número que define al total de notas que son notables.
        /// </summary>
        private int notables;

        /// <summary>
        /// Número que define al total de notas que son sobresalientes.
        /// </summary>
        private int sobresalientes;

        /// <summary>
        /// Número que define a la media del conjunto de notas.
        /// </summary>
        private double media;

        /// <summary>
        /// Obtiene o asigna los Suspensos.
        /// </summary>
        public int Suspensos { get => suspensos; set => suspensos = value; }

        /// <summary>
        /// Obtiene o asigna los Aprobados.
        /// </summary>
        public int Aprobados { get => aprobados; set => aprobados = value; }

        /// <summary>
        /// Obtiene o asigna los Notables.
        /// </summary>
        public int Notables { get => notables; set => notables = value; }

        /// <summary>
        /// Obtiene o asigna los Sobresalientes.
        /// </summary>
        public int Sobresalientes { get => sobresalientes; set => sobresalientes = value; }

        /// <summary>
        /// Obtiene o asigna la Media.
        /// </summary>
        public double Media { get => media; set => media = value; }

        
        /// <summary>
        /// Inicia una nueva instancia de la clase <see cref="EstadisticasNotasARA2021"/> que está vacía.
        /// </summary>
        public EstadisticasNotasARA2021()
        {
            Suspensos = 0; 
            Aprobados = 0; 
            Notables = 0; 
            Sobresalientes = 0;
            Media = 0.0;
        }

        // Constructor a partir de un array, calcula las estadísticas al crear el objeto
        /// <summary>
        /// Inicia una nueva instancia de la clase <see cref="EstadisticasNotasARA2021"/> que recibe una lista.
        /// </summary>
        /// <param name="ListaNotas"> Lista que contiene las notas. <see cref="List{int}"/>.</param>
        public EstadisticasNotasARA2021(List<int> ListaNotas)
        {
            CalcularEstadisticasARA2021(ListaNotas);
        }

        /// <summary>
        /// <para>Método que se utiliza para comprobar que los valores de una lista de notas sean correctos y asignar valores a las propiedades de la clase.</para>
        /// <para> El método calcula:
        /// <list type="bullet"> 
        ///     <item> 
        ///         <description> <see cref="Suspensos"/> </description>
        ///     </item>
        ///      <item> 
        ///         <description> <see cref="Aprobados"/> </description>
        ///     </item>
        ///      <item> 
        ///         <description> <see cref="Notables"/> </description>
        ///     </item>
        ///      <item> 
        ///         <description> <see cref="Sobresalientes"/> </description>
        ///     </item>
        ///      <item> 
        ///         <description> <see cref="Media"/> </description>
        ///     </item>
        /// </list> 
        /// </para>
        /// </summary>
        /// <param name="listnot"> Lista de notas de la cual se calculan sus estadisticas. <see cref="List{int}"/>.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"> Lanza una excepcion si la lista está vacia o si alguna nota no es correcta. </exception>
        public void CalcularEstadisticasARA2021(List<int> ListNotas)
        {
            double media = 0.0;

            // Si la lista no contiene elementos, devolvemos un error
            if (ListNotas.Count <= 0)  
            {
                throw new ArgumentOutOfRangeException();
            }

            // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
            for (int i = 0; i < ListNotas.Count; i++)
            {
                if (ListNotas[i] < 0 || ListNotas[i] > 10)      
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            for (int i = 0; i < ListNotas.Count; i++)
            { 
                // Por debajo de 5 suspenso
                if (ListNotas[i] < 5)
                {
                    Suspensos++;             
                }
                // Nota para aprobar: 5
                else if (ListNotas[i] >= 5 && ListNotas[i] < 7)
                {
                    Aprobados++;
                }
                // Nota para notable: 7
                else if (ListNotas[i] >= 7 && ListNotas[i] < 9)
                {
                    Notables++;
                }
                // Nota para sobresaliente: 9
                else if (ListNotas[i] >= 9)
                {
                    Sobresalientes++;         
                }

                media = media + ListNotas[i];
            }

            Media = media / ListNotas.Count;
        }
    }
}

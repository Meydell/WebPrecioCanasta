using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrecioCanasta
{
    public class Global
    {
        //Clase de Año
        #region
        public class Years
        {
            private int id;
            private int year;

            public int Id { get => id; set => id = value; }
            public int Year { get => year; set => year = value; }

            public Years(int id, int year)
            {
                this.Id = id;
                this.Year = year;
            }
        }

        public static List<Years> ListYears = new List<Years>()
        {
            new Years(1,2005),
            new Years(2,2006),
            new Years(3,2007),
            new Years(3,2008),
        };
        #endregion


        //Clase de Mes
        #region
        public class Meses
        {
            int id;
            string name;

            public Meses(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
        }
        public static List<Meses> ListMeses = new List<Meses>()
        {
            new Meses(1,"Enero"),
            new Meses(2,"Febrero"),
            new Meses(3,"Marzo"),
            new Meses(4,"Abril"),
            new Meses(5,"Mayo"),
            new Meses(6,"Junio"),
            new Meses(7,"Julio"),
            new Meses(8,"Agosto"),
            new Meses(9,"Septiembre"),
            new Meses(10,"Octubre"),
            new Meses(11,"Noviembre"),
            new Meses(12,"Diciembre"),
        };
        #endregion


        //Clase Categoria_Monto
        #region
        public class Categoria
        {
            int id;
            string name;

            public Categoria(int id, string name)
            {
                this.Id = id;
                this.Name = name;


            }

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
        }

        public static List<Categoria> ListCategoria = new List<Categoria>()
        {
            new Categoria(1,"Alimentos"),
            new Categoria(2,"Uso del Hogar"),
            new Categoria(3,"Vestuario"),
            new Categoria(4,"Total")
        };
        #endregion

        #region
        public class MontosMensuales
        {
            int idMonto;
            int idCategoria;
            int idMes;
            int idYear;
            double monto;

            public MontosMensuales(int idMonto, int idCategoria, int idMes, int idYear, double monto)
            {
                this.IdMonto = idMonto;
                this.IdCategoria = idCategoria;
                this.IdMes = idMes;
                this.IdYear = idYear;
                this.Monto = monto;
            }
            
            public int IdMonto { get => idMonto; set => idMonto = value; }
            public int IdCategoria { get => idCategoria; set => idCategoria = value; }
            public int IdMes { get => idMes; set => idMes = value; }
            public int IdYear { get => idYear; set => idYear = value; }
            public double Monto { get => monto; set => monto = value; }
        }

        public static List<MontosMensuales> ListMontosMensuales = new List<MontosMensuales>()
        {
            new MontosMensuales(1,1,1,1,1.50410),
            new MontosMensuales(2,2,1,1,916.9),
            new MontosMensuales(3,3,1,1,142.8),
            new MontosMensuales(4,4,1,1,2.56370),
            new MontosMensuales(5,1,2,1,1.50880),
            new MontosMensuales(6,2,2,1,913),
            new MontosMensuales(7,3,2,1,143.8),
            new MontosMensuales(8,4,2,1,2.56560),
            new MontosMensuales(9,1,3,1,1.51450),
            new MontosMensuales(10,2,3,1,919.3),
            new MontosMensuales(11,3,3,1,144.3),
            new MontosMensuales(12,4,3,1,2.57820),
            new MontosMensuales(13,1,4,1,1.55630),
            new MontosMensuales(14,2,4,1,1.00390),
            new MontosMensuales(15,3,4,1,1462),
            new MontosMensuales(16,4,4,1,2.70640),
            new MontosMensuales(17,1,5,1,1.59260),
            new MontosMensuales(18,2,5,1,9271),
            new MontosMensuales(19,3,5,1,1466),
            new MontosMensuales(20,4,5,1,2.66630),
            new MontosMensuales(21,1,6,1,1.59700),
            new MontosMensuales(22,2,6,1,9254),
            new MontosMensuales(23,3,6,1,1471),
            new MontosMensuales(24,4,6,1,2.66950),
            new MontosMensuales(25,1,7,1,1.61110),
            new MontosMensuales(26,2,7,1,9318),
            new MontosMensuales(27,3,7,1,1479),
            new MontosMensuales(28,4,7,1,2.69080),
            new MontosMensuales(29,1,8,1,1.60520),
            new MontosMensuales(30,2,8,1,946),
            new MontosMensuales(31,3,8,1,1482),
            new MontosMensuales(32,4,8,1,2.69940),
            new MontosMensuales(32,4,8,1,2.69940),
            new MontosMensuales(33,1,9,1,1.60870),
            new MontosMensuales(34,2,9,1,952),
            new MontosMensuales(35,3,9,1,1487),
            new MontosMensuales(36,4,9,1,2.70930),
            new MontosMensuales(37,1,10,1,1.63120),
            new MontosMensuales(38,2,10,1,9692),
            new MontosMensuales(39,3,10,1,1492),
            new MontosMensuales(40,4,10,1,2.74960),
            new MontosMensuales(41,1,11,1,1.68080),
            new MontosMensuales(42,2,11,1,9681),
            new MontosMensuales(42,3,11,1,1493),
            new MontosMensuales(43,4,11,1,2.79820),
            new MontosMensuales(44,1,12,1,1.67930),
            new MontosMensuales(45,2,12,1,9641),
            new MontosMensuales(46,3,12,1,1514),
            new MontosMensuales(47,4,12,1,2.79480),
        };
        #endregion
    }
}
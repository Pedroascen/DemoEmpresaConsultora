using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmpresaEstadistica
{
    public class Datos{
        static public string usuarioInsert;
        static public int CidRubroInsert;
    }

    public class Cliente {
         public int[] CidCliente = { 1, 2, 3, 4, 5 };
         public string[] usuario = {"Alexis","Ascencio","Alejandro","Samanta","Daniela"};
         public string[] clave = {"1234","1234", "1234", "1234", "1234"};
        public int[] CidRubro = {1,2,3,2,1};
    }

    public class Rubro {
        public int[] idRubro = {1,2,3};
        public string[] nombre = { "Programas de televisión", "Libros de lectura", "Lenguajes de programacion"};
    }

    public class Descripcion {
        public int[] DidRubro = {1,1,1,2,2,2,3,3,3};
        public int[] idDescripcion = { 1,2,3,4,5,6,7,8,9 };
        public string[] clasificacion = { "Clasificación A", "Clasificación B", "Clasificación C", 
                                          "Novelas Románticas" , "Cómics", "Libros sociedad", 
                                          "Programación Web", "Programación Mobile" , "Programación de Aprendizaje Automático (Machine Learning)" };
        
        public string[] detalle = { "Pueden transmitirse en cualquier horario. Los programas bajo esta clasificación son aptos para todo público. Los niños pueden verlos sin la supervisión de adultos.",
                                    "Son programas aptos para adolescentes y adultos, los cuales se transmiten a partir de las 20 y hasta las 5:00 horas.",
                                    "Programas aptos para mayores de 18 años, los cuales podrán transmitirse a partir de las 22 y hasta las 5:00 horas.",
                                    
                                    "Las novelas románticas cuentan historias maravillosas de amor, pasión y a veces también, desamor. Descubre libros románticos fantásticos de gran cantidad de autores, desde John Fante, hasta Elísabet Benavent. No te lo pienses más y descubre las mejores novelas románticas en Leer para Pensar.",
                                    "Los Cómics cuentan distintas historias con texto e imágenes dibujadas. Descubre grandes historias con grandes protagonistas, que ya forman parte de la historia de la literatura. Cómics con grandes premios como el Premio Pulitzer, que ganó Maus: Relato de un superviviente y muchos más, los podrás descubrir en Leer para Pensar …esperemos que os gusten!",
                                    "Libros sociedad son libros de actualidad y de la situación que vive actualmente el mundo. " + " Son libros que ponen en duda, agitan y remueven los cimientos de una sociedad, cada vez más podrida.Los libros intentan que el lector pueda tener un punto de vista distinto al que habitualmente está acostumbrado a recibir. Los medios de comunicación tradicionales forman opiniones distorsionadas de la realidad. " + " Forma una nueva actitud frente a los problemas de la sociedad capitalista actual.",

                                    "Cuando hablamos de la web, nos referimos a todo aquello que puede funcionar sobre un navegador (Chrome, Firefox, Internet Explorer, Edge, Safari). En este punto, conviene separar lo que son los sitios web de las aplicaciones web.",
                                    "Se refiere al desarrollo de aplicaciones para teléfonos celulares. Existen dos grandes ramas ‒de nuevo con las divisiones‒ que dependen del sistema operativo del celular: IOS de Apple y Android de Google.",
                                    "La cantidad de datos que generamos y almacenamos es cada vez mayor, y crece día a día ‒todo lo que hacemos en internet queda registrado y almacenado‒. De aquí surge el término «Big Data», para referirse al gran volumen de datos que existe en la actualidad. Este concepto se encuentra relacionado con otro termino llamado: ciencia de datos, ya que la fuente para el análisis proviene, justamente, de las grandes cantidades de datos que existen dispersos y desconectados hoy en día."};
    }
    
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Casa los_de_la_abuela0= new Casa();
            Fabrica los_de_la_abuela1= new Fabrica();
            Colegio los_de_la_abuela2= new Colegio();
            Aeropuerto los_de_la_abuela3= new Aeropuerto();
            //los_de_la_abuela[3]= new Casa();
            
            los_de_la_abuela0.tipo();
            los_de_la_abuela0.introducirDatos();
            Console.WriteLine($"El costo es de: {los_de_la_abuela0.calcularCosto()} Bs");

            los_de_la_abuela1.tipo();
            los_de_la_abuela1.introducirDatos();
            Console.WriteLine($"El costo es de: {los_de_la_abuela1.calcularCosto()} Bs");

            los_de_la_abuela2.tipo();
            los_de_la_abuela2.introducirDatos();
            Console.WriteLine($"El costo es de: {los_de_la_abuela2.calcularCosto()} Bs");

            los_de_la_abuela3.tipo();
            los_de_la_abuela3.introducirDatos();
            Console.WriteLine($"El costo es de: {los_de_la_abuela3.calcularCosto()} Bs");
            


        }
    }
    public abstract class Terreno{
        protected int area;
        public abstract int calcularCosto();
        public virtual void introducirDatos(){
            Console.WriteLine("introduzca el Area del terreno en metros cuadrados");
            area = Int32.Parse(Console.ReadLine());
        }
        public virtual void tipo(){
            Console.WriteLine("Es un Terreno");
        }

    }
    public class Casa : Terreno
    {
        public int cantPisos;
        public override int calcularCosto()
        {
            return ((cantPisos * 50) + (area * 15));
        }
        public override void introducirDatos()
        {
            base.introducirDatos();
            Console.WriteLine("introduzca la cantidad de pisos que tiene la casa");
            cantPisos = Int32.Parse(Console.ReadLine());
        }
        public override void tipo(){
            Console.WriteLine("Es un Casa");
        }
    }

    public class Fabrica : Terreno
    {
        public int cantMaquinaria;
        public override int calcularCosto()
        {
            return ((cantMaquinaria * 50) + (area * 15));
        }
        public override void introducirDatos()
        {
            base.introducirDatos();
            Console.WriteLine("introduzca la cantidad de maquinaria que tiene la Empresa");
            cantMaquinaria = Int32.Parse(Console.ReadLine());
        }
        public override void tipo(){
            Console.WriteLine("Es un Fabrica");
        }
    }

    public class  Colegio : Terreno
    {
        public int cantAulas;
        public int cantCanchas;
        public override int calcularCosto()
        {
            return ((cantAulas * 25) + (cantCanchas * 20) + (area * 15));
        }
        public override void introducirDatos()
        {
            base.introducirDatos();
            Console.WriteLine("introduzca la cantidad de aulas que tiene el Colegio");
            cantAulas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("introduzca la cantidad de canchas que tiene el Colegio");
            cantCanchas = Int32.Parse(Console.ReadLine());
        }
        public override void tipo(){
            Console.WriteLine("Es un Colegio");
        }
    }


    public class  Aeropuerto : Terreno
    {
        public int cantAviones;
        public override int calcularCosto()
        {
            return ((cantAviones * 2500)  + (area * 15));
        }
        public override void introducirDatos()
        {
            base.introducirDatos();
            Console.WriteLine("introduzca la cantidad de aviones que tiene el Aeropuerto");
            cantAviones = Int32.Parse(Console.ReadLine());
        }
        public override void tipo(){
            Console.WriteLine("Es un Aeropuerto");
        }
    }
}

# Polimorfismo #
El polimorfismo es la habilidad que poseen los objetos para reaccionar de manera distinta ante los mismos mensajes

## Conceptos basicos del polimorfismo ##
 ### 1. Sobrecarga ### 
        Diferentes maneras de realizar una misma accion. Usamos el mismo nombre pero con diferentes firmas

    miEmpleado.Contratar("Juan", "Ventas", 2500);
    miEmpleado.Contratar("Juan");
    miEmpleado.Contratar("Juan", 2500);

 ### 2. Override ###
       La clase "B" hereda el metodo de la clase "A" pero la clase "B" re-define las caracteristicas heredadas de "A" 

    Public class Articulo
    {
        void Abrir()
        {
            Console.WriteLine("Abrir articulo");
        }
    }

    Public class Libro : Articulo
    {
        void Abrir()
        {
            Console.WriteLine("Abrir Libro");
        }
    }

 ### 3.Metodos virtuales ###
        Son métodos en la clase base pensados para ser sobrescritos por subclases

        Para declarar, se utiliza la palabra reservada "Virtual" y para sobrescribirlos en la subclase, se utiliza la palabra "Override".

    class ClaseBase
    {
        public virtual void Metodo()
        {

        }
    }

    class ClaseDerivada : ClaseBase
    {
        public override void Metodo()
        {

        }
    }

        Si se agrega la palaba clave SEALED  a un metodo override impide la sobrescritura de este método

 ### 4.Ocultar métodos heredados
        Sirve paara ocultar un método heredado e introducir uno nuevo a la jerarquía de clases. El metodo heredado es reemplazado por otro nuevo.

    class Vehiculo
    {
        public void Arrancar()
        {
            Console.WriteLine("Hago brum brum");
        }
    }

    class Camion : vehiculo
    {
        public new void Arrancar()
        {
            Console.WriteLine("Hago moc moc");
        }
    }
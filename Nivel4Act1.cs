using System;

public class Empleado() {
	public String nombre = "Nombre";
	
	public Empleado(Sting nombre) {
	this.nombre = nombre;
	mostrar();
	}
	private String nombre {
		get { return nombre; }
		set { nombre = value; }
	}
}
	public mostrar() {
	Console.WriteLine("Nombre: " + get.nombre);
	}
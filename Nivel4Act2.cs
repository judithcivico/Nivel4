using System;

public class Alumne() {
	public String nombre;
	public String apellido;
	public String DNI;
	public String cicloFormativo;
	public String curso;
	
public Constructor(String nombre, String apellido, String DNI, String cicloFormativo, String curso) {
	this.nombre = nombre;
	this.apellido = apellido;
	this.DNI = DNI;
	this.cicloFormativo = cicloFormativo;
	this.curso = curso;
}
	private String nombre {
		get { return nombre; }
		set { nombre = value; }
	}
	
	private String apellido {
		get { return apellido; }
		set { apellido = value; }
	}
	
	private String DNI {
		get { return DNI; }
		set { DNI = value; }
	}
	
	private String cicloFormativo {
		get { return cicloFormativo; }
		set { cicloFormativo = value; }
	}
	
	private String curso {
		get { return curso; }
		set { curso = value; }
	}
public toString() {
	Console.WriteLine("Alumno: " + get.nombre + get.apellido);
	Console.WriteLine("DNI: " + get.DNI);
	Console.WriteLine("Ciclo formativo: " + get.cicloFormativo);
	Console.WriteLine("Curso: " + get.curso);
}
public equals() {
	if (get.nombre = get.nombre && get.apellido = get.apellido && get.DNI = get.DNI) {
		
}
}
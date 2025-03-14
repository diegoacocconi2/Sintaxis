package sintaxis.alumnos.interfaz;

public class Alumno {
	// ATRIBUTOS
	int legajo;
	String nombre;
	String apellido;

	// MÉTODOS
	// Constructor por defecto
	public Alumno () {
		this.legajo = 0;
		this.nombre = "";
		this.apellido = "";
	}
	
	// Constructor
	public Alumno (int legajo, String nombre, String apellido) {
		this.legajo = legajo;
		this.nombre = nombre;
		this.apellido = apellido;
	}
	
	// Cambia el legajo
	public void setLegajo (int legajo) {
		this.legajo = legajo;
	}

	// Obtiene el legajo
	public int getLegajo () {
		return legajo;
	}

	// Cambia el nombre
	public void setNombre (String nombre) {
		this.nombre = nombre;
	}

	// Obtiene el nombre
	public String getNombre () {
		return nombre;
	}

	// Cambia el apellido
	public void setApellido (String apellido) {
		this.apellido = apellido;
	}

	// Obtiene el apellido
	public String getApellido () {
		return apellido;
	}
}

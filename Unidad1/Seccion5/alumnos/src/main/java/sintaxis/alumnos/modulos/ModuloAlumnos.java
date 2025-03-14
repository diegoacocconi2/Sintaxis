package sintaxis.alumnos.modulos;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Controller;

import sintaxis.alumnos.interfaz.Alumno;
import sintaxis.alumnos.interfaz.InterfazAlumnos;

@Controller
public class ModuloAlumnos implements InterfazAlumnos {
	List <Alumno> listaAlumnos = new ArrayList <> ();

	@Override
	public boolean alumnoExiste (int legajo) {
		if (legajo > 0) {
			for (Alumno alumno : listaAlumnos) {
				if (alumno.getLegajo () == legajo)
					return true;
			}
		}

		return false;
	}

	@Override
	public boolean nuevoAlumno (int legajo, String nombre, String apellido) {
		if (legajo > 0 && nombre.length () > 0 && apellido.length () > 0) {
			if (!alumnoExiste (legajo)) {
				Alumno alumno = new Alumno (legajo, nombre, apellido);
				
				listaAlumnos.add (alumno);
				
				return true;
			}
		}

		return false;
	}

	@Override
	public Alumno alumno (int legajo) {
		if (legajo > 0) {
			for (Alumno alumno : listaAlumnos) {
				if (alumno.getLegajo () == legajo)
					return alumno;
			}
		}

		return null;
	}

	@Override
	public List <Alumno> alumnos () {
		return listaAlumnos;
	}
}

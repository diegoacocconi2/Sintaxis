package sintaxis.alumnos.interfaz;

import java.util.List;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;

public interface InterfazAlumnos {
	// http://host:puerto/alumno/existe?legajo=...
	@RequestMapping (value = "/alumno/existe", method = RequestMethod.GET, produces = "application/json")
	@ResponseBody
	boolean alumnoExiste (@RequestParam int legajo);
	
	// http://host:puerto/alumno/nuevo?legajo=...&nombre=...&apellido=...
	@RequestMapping (value = "/alumno/nuevo", method = RequestMethod.GET, produces = "application/json")
	@ResponseBody
	boolean nuevoAlumno (@RequestParam int legajo,
						  @RequestParam String nombre,
						  @RequestParam String apellido);

	// http://host:puerto/alumno/...
	@GetMapping (value = "/alumno/{legajo}", produces = "application/json")
	@ResponseBody
	Alumno alumno (@PathVariable int legajo);
	
	// http://host:puerto/alumno/lista
	@GetMapping (value = "/alumno/lista", produces = "application/json")
	@ResponseBody
	List <Alumno> alumnos ();
}

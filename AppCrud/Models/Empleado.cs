namespace AppCrud.Models
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public string nombreCompleto { get; set; }
        public Departamento refDepartamento { get; set; }
        public int sueldo { get; set; }
        public string fechaContrato { get; set; }
    }
}

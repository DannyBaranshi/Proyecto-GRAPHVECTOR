using System;
using System.Collections.Generic;

namespace VECTORGRAPH.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public string? Correo { get; set; }

    public string? Contraseña { get; set; }

    public string? InstitucionEducativa { get; set; }
}

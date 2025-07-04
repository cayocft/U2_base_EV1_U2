﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;

namespace U1_evaluacion_sumativa.Models;

public partial class DetalleProyecto
{
    [ValidateNever] 
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int ProyectoId { get; set; }

    [ValidateNever] 
    public virtual Proyecto Proyecto { get; set; } = null!;
}

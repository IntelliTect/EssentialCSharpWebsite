﻿using IntelliTect.Coalesce;
using IntelliTect.Coalesce.DataAnnotations;
using IntelliTect.Coalesce.Models;
using IntellitectTerminal.Data.Models;

namespace IntellitectTerminal.Web;

[Coalesce, Service]
public interface ICommandService
{
    Challenge RequestCommand(Guid? userId);
}
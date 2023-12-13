using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();

exportHelper.ExportGeneric(studentRepository.GetAll());

Console.WriteLine("Proceso Completado");
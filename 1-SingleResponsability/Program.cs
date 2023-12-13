using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();

exportHelper.Export(studentRepository.GetAll());

Console.WriteLine("Proceso Completado");
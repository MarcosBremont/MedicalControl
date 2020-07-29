CREATE DATABASE MedicalControl
	Use MedicalControl

	Create table Paciente
	(
	IDPaciente int PRIMARY KEY IDENTITY (1,1),
	NombreP VARCHAR (30),
	ApellidoP VARCHAR (30),
	EdadP INT,
	CedulaP VARCHAR (30),
	DireccionP VARCHAR (30),
	TelefonoP VARCHAR(15),
	TelefonoEP VARCHAR(20),
	Alergias VARCHAR(30)
	)

	Create table CitaMedica
	(
	IDCitaMedica int PRIMARY KEY IDENTITY (1,1),
	HoraCM time,
	FechaCM date
	)



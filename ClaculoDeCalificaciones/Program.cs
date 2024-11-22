// See https://aka.ms/new-console-template for more information

int numeroExamenes = 5;

int[] alumno1Calificaciones = new int[] { 52, 56, 98, 76, 95, 100, 96 };
int[] alumno2Calificaciones = new int[] { 62, 69, 37, 88, 99, 100, 100 };
int[] alumno3Calificaciones = new int[] { 66, 88, 54, 85, 95, 100 };
int[] alumno4Calificaciones = new int[] { 96, 65, 64, 85, 75, 92, 96 };
int[] alumno5Calificaciones = new int[] { 86, 74, 96, 52, 83, 89, 93 };

string[] alumnos = new string[] { "alumno1", "alumno2", "alumno3", "alumno4", "alumno5" };

int[] calificacionesAlumnos = new int[10];
string calificacionConLetra = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (string nameAlumnos in alumnos)
{
   if (nameAlumnos == "alumno1") 
    {
        calificacionesAlumnos = alumno1Calificaciones;
    }
   else if (nameAlumnos == "alumno2")
    {
        calificacionesAlumnos = alumno2Calificaciones;
    }
   else if (nameAlumnos == "alumno3")
    {
        calificacionesAlumnos = alumno3Calificaciones;
    }
   else if (nameAlumnos == "alumno4")
    {
        calificacionesAlumnos = alumno4Calificaciones;
    }
   else if (nameAlumnos == "alumno5")
    {
        calificacionesAlumnos = alumno5Calificaciones;
    }

    int sumaCalificaciones = 0;
    int creditosAdicionales = 0;
   foreach (int calificaciones in calificacionesAlumnos)
    {
        creditosAdicionales++;
        if (creditosAdicionales > numeroExamenes)
        {
            sumaCalificaciones += calificaciones / 10;
        }
        else
        {
            sumaCalificaciones += calificaciones;
        }
    }

    decimal notaMedia = (decimal)sumaCalificaciones / numeroExamenes;
    if (notaMedia >= 97)
    {
        calificacionConLetra = "A+";
    }
    else if (notaMedia >= 93)
    {
        calificacionConLetra = "A";
    }
    else if (notaMedia >= 90)
    {
        calificacionConLetra = "A-";
    }
    else if (notaMedia >= 87)
    {
        calificacionConLetra = "B+";
    }
    else if (notaMedia >= 83)
    {
        calificacionConLetra = "B";
    }
    else if (notaMedia >= 80)
    {
        calificacionConLetra = "B-";
    }
    else if (notaMedia >= 77)
    {
        calificacionConLetra = "C+";
    }
    else if (notaMedia >= 73)
    {
        calificacionConLetra = "C";
    }
    else if (notaMedia >= 70)
    {
        calificacionConLetra = "C-";
    }
    else if (notaMedia >= 67)
    {
        calificacionConLetra = "D+";
    }
    else if (notaMedia >= 63)
    {
        calificacionConLetra = "D";
    }
    else if (notaMedia >= 60)
    {
        calificacionConLetra = "D-";
    }
    else
        calificacionConLetra = "F";

    Console.WriteLine($"{nameAlumnos}\t\t{notaMedia}\t\t{calificacionConLetra} ");
        
}
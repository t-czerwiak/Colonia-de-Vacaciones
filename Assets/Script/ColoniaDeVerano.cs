using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoniaDeVerano : MonoBehaviour
{
    public int inscriptosInfantiles;
    public int inscriptosJuveniles;
    int profesoresInfantiles;
    int profesoresJuveniles;
    int coordinadores;
    int profesoresJ = 0;
    int profesoresI= 0;
    int profesoresTotales;
    int cantidadInfantilPorProfesor = 10;
    int cantidadJuvenilPorProfesor = 20;
    int cantidadProfesorPorCoordinador = 5;
    int listaDeEspera;
    void Start()
    {
        if (inscriptosInfantiles < 0 | inscriptosJuveniles < 0)
        {
            Debug.Log("Error, la cantidad de inscriptos no puede ser negativa");
            return;
        }

        else if (inscriptosInfantiles > 100 | inscriptosJuveniles > 100)
        {
            Debug.Log("Error, hay un limite de 100 inscriptos por categoria");
            return;
        }

        profesoresJ = inscriptosJuveniles / cantidadJuvenilPorProfesor;
        profesoresI = inscriptosInfantiles / cantidadInfantilPorProfesor;
        profesoresTotales = profesoresI + profesoresJ;
        coordinadores = profesoresTotales / cantidadProfesorPorCoordinador;
        listaDeEspera = (inscriptosInfantiles % 10) + (inscriptosJuveniles % 20);

        if (profesoresTotales % cantidadProfesorPorCoordinador != 0)
        {
            coordinadores++;
        }

        Debug.Log("Se necesitan " + profesoresI + " profesores para los inscriptos infantiles");
        Debug.Log("Se necesitan " + profesoresJ + " profesores para los inscriptos juveniles");
        Debug.Log("Se necesitan " + coordinadores + " coordinadores para los profesores totales");

        if (listaDeEspera > 0)
        {
            Debug.Log("La lista de espera tiene " + listaDeEspera + " inscriptos");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

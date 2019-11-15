package com.example.joc;

import java.util.ArrayList;
import java.util.List;

class Pregunta {
    private String pregunta;
    private ArrayList<Respuesta> respuestas;
    private boolean dificultad;

    public String getPregunta() {
        return pregunta;
    }


    public List<Respuesta> getRespuestas() {
        return respuestas;
    }


    public boolean isDificultad() {
        return dificultad;
    }


}

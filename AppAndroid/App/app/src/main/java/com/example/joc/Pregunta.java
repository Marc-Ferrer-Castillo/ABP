package com.example.joc;

import java.util.List;

class Pregunta {
    private String pregunta;
    private List<Respuesta> respuestas;
    private boolean dificultad;

    public String getPregunta() {
        return pregunta;
    }

    public void setPregunta(String pregunta) {
        this.pregunta = pregunta;
    }

    public List<Respuesta> getRespuestas() {
        return respuestas;
    }

    public void setRespuestas(List<Respuesta> respuestas) {
        this.respuestas = respuestas;
    }

    public boolean isDificultad() {
        return dificultad;
    }

    public void setDificultad(boolean dificultad) {
        this.dificultad = dificultad;
    }
}

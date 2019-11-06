package com.example.joc;

import java.util.List;

public class Planeta {
    private byte id;
    private String contenido;
    private List<Pregunta> preguntas;
    private byte idioma;

    public byte getId() {
        return id;
    }

    public void setId(byte id) {
        this.id = id;
    }

    public String getContenido() {
        return contenido;
    }

    public void setContenido(String contenido) {
        this.contenido = contenido;
    }

    public List<Pregunta> getPreguntas() {
        return preguntas;
    }

    public void setPreguntas(List<Pregunta> preguntas) {
        this.preguntas = preguntas;
    }

    public byte getIdioma() {
        return idioma;
    }

    public void setIdioma(byte idioma) {
        this.idioma = idioma;
    }
}

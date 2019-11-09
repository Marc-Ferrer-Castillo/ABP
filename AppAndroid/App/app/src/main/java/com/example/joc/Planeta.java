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

    public String getContenido() {
        return contenido;
    }

    public List<Pregunta> getPreguntas() {
        return preguntas;
    }

    public byte getIdioma() {
        return idioma;
    }
}

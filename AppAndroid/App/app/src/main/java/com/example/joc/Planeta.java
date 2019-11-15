package com.example.joc;

import java.util.ArrayList;
import java.util.List;

public class Planeta {

    private byte id;
    private String contenido;
    private ArrayList<Pregunta> preguntas;
    private byte idioma;

    public byte getId() {
        return id;
    }

    public String getContenido() {
        return contenido;
    }

    public ArrayList<Pregunta> getPreguntas() {
        return  preguntas;
    }

}

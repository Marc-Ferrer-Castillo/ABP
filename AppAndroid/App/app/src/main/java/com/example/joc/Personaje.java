package com.example.joc;

public class Personaje {
    private String nom;
    private String frase;
    private static String rutaImagen1;
    private static String rutaImagen2;
    private static String rutaImagen3;


    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getFrase() {
        return frase;
    }

    public void setFrase(String frase) {
        this.frase = frase;
    }

    public static String getRutaImagen1() {
        return rutaImagen1;
    }

    public static void setRutaImagen1(String rutaImagen1) {
        Personaje.rutaImagen1 = rutaImagen1;
    }

    public static String getRutaImagen2() {
        return rutaImagen2;
    }

    public static void setRutaImagen2(String rutaImagen2) {
        Personaje.rutaImagen2 = rutaImagen2;
    }

    public static String getRutaImagen3() {
        return rutaImagen3;
    }

    public static void setRutaImagen3(String rutaImagen3) {
        Personaje.rutaImagen3 = rutaImagen3;
    }
}

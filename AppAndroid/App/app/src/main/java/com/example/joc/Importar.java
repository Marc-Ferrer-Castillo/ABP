package com.example.joc;

import android.os.Environment;
import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class Importar {

    /*RUTAS A LOS FICHEROS JSON E IMAGENES*/
    public static final String SEPARADOR             = File.separator;
    public static final String DIRECTORIO_CONTENIDO_ = Environment.getExternalStorageDirectory() + SEPARADOR + "contingut del joc";
    public static final String RUTA_PLANETAS         = DIRECTORIO_CONTENIDO_ + SEPARADOR + "planetas" + SEPARADOR + "planetas.JSON";
    public static final String RUTA_PJS              = DIRECTORIO_CONTENIDO_ + SEPARADOR + "personatges" + SEPARADOR + "personatges.JSON";
    public static final String DIRECTORIO_IMAGENES   = DIRECTORIO_CONTENIDO_ + SEPARADOR + "personatges"+ SEPARADOR + "imatges";

    // Lee y deserializa los planeta.JSON y devuelve una lista de planetas
    public static List<Planeta> planetas(){

        Gson gson = new Gson();
        // Lista de planetas
        List<Planeta> planetas = new ArrayList<Planeta>();


        try {
            BufferedReader lectorPlanetas = new BufferedReader(new FileReader(RUTA_PLANETAS));

            planetas = gson.fromJson(lectorPlanetas, new TypeToken<List<Planeta>>(){}.getType());


        } catch (IOException e) {

        }
        return planetas;
    }

    // Lee, deserializa los personajes.JSON y devuelve una lista de personajes
    public static List<Personaje> personajes(){

        Gson gson = new Gson();

        // Lista de personajes
        List<Personaje> personajes = new ArrayList<Personaje>();

        try {
            BufferedReader lectorPjs = new BufferedReader(new FileReader(RUTA_PJS));

            personajes = gson.fromJson(lectorPjs, new TypeToken<List<Personaje>>(){}.getType());


        } catch (IOException e) {

        }
        return personajes;
    }
}

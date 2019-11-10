package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.GridLayout;
import android.widget.GridView;

import java.util.ArrayList;
import java.util.List;

public class juego extends AppCompatActivity {

    public static List<Respuesta> respuesta = new ArrayList<Respuesta>();
    public static List<Pregunta> pregunta = new ArrayList<Pregunta>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_juego);

        GridLayout respuestas = findViewById(R.id.respuestas);





    }

}

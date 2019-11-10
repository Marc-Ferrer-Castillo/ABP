package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.GridLayout;
import android.widget.GridView;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class Juego extends AppCompatActivity {

    //Iterador de preguntas
    public static int numPregunta = 0;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_juego);

        // Objeto GridView donde iran las respuestas
        ListView gridRespuestas = findViewById(R.id.gridRespuestas);

        // Objeto Textview donde ira la pregunta
        TextView preguntaView = findViewById(R.id.pregunta);

        // Contiene el string con la pregunta numPregunta de planetaMostrado
        String pregunta = MainActivity.planetas.get(MainActivity.planetaMostrado).
                getPreguntas().get(numPregunta).getPregunta();

        // coloca la pregunta en el textView
        preguntaView.setText(pregunta);


        // Lista de respuestas de la pregunta
        final List<Respuesta> respuestas = MainActivity.planetas.get(MainActivity.planetaMostrado).
                getPreguntas().get(numPregunta).getRespuestas();

        RespuestaAdapter adaptador = new RespuestaAdapter(this, respuestas);

        gridRespuestas.setAdapter(adaptador);

    }

}

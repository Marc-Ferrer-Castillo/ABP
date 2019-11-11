package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.GridView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.IllegalFormatCodePointException;
import java.util.List;

public class Juego extends AppCompatActivity {

    //Iterador de preguntas
    public static int numPregunta = 0;
    protected List<Respuesta> respuestas =  new ArrayList<Respuesta>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_juego);

        // Objeto GridView donde iran las respuestas
        final GridView gridRespuestas = findViewById(R.id.listRespuestas);

        // Objeto Textview donde ira la pregunta
        TextView preguntaView = findViewById(R.id.pregunta);


        // Contiene el string con la pregunta numPregunta de planetaMostrado
        List<Pregunta> preguntas = MainActivity.planetas.get(MainActivity.planetaMostrado).getPreguntas();


        // Guarda las preguntas según la dificultad seleccionada
        List<Pregunta> preguntasFiltradas = new ArrayList<Pregunta>();


        //Si el modo es facil
        if (Dificultad.dificultadSeleccionada){

            for (int i = 0 ; i < preguntas.size() ; i++){

                if (preguntas.get(i).isDificultad()){

                    preguntasFiltradas.add(preguntas.get(i) );
                }
            }
        }
        else{

            for (int i = 0 ; i <  preguntas.size() ; i++){

                if (preguntas.get(i).isDificultad() == false ){

                    preguntasFiltradas.add(preguntas.get(i) );
                }
            }
        }


        if(!(preguntasFiltradas.size() == 0)) {
            // coloca la pregunta en el textView
            preguntaView.setText(preguntasFiltradas.get(numPregunta).getPregunta());

            // Lista de respuestas de la pregunta
            respuestas = preguntasFiltradas.get(numPregunta).getRespuestas();

            // Instancia nuestro adaptador personalizado
            RespuestaAdapter adaptador = new RespuestaAdapter(this, respuestas);

            // La grid usa ahora este adaptador personalizado
            gridRespuestas.setAdapter(adaptador);
        }
        else{
            pasarPlaneta();
        }



        // Al pulsar sobre una respuesta
        gridRespuestas.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                // El maximo de preguntas será igual al numero de preguntas que contenga el planeta
                int maxPreguntas = MainActivity.planetas.get(MainActivity.planetaMostrado).
                        getPreguntas().size();


                Integer respuestaSeleccionada = (Integer)view.getTag();

                // Si la respuesta es correcta
                if (respuestas.get(respuestaSeleccionada).isEsCorrecta() ){

                    Resultado.aciertos++;

                    Toast.makeText(Juego.this, "ACIERTO",
                            Toast.LENGTH_LONG).show();
                }

                // Si quedan mas preguntas en el planeta
                if (numPregunta < maxPreguntas-1){

                    // Incrementamos 1 para mostrar la siguiente
                    numPregunta++;

                    // recarga la actividad
                    recreate();
                }

                //Si no quedan mas preguntas en el planeta
                else{
                    pasarPlaneta();
                }



            }
        });

    }

    private void pasarPlaneta(){

        Intent intent = new Intent(Juego.this, Contenido.class);
        Intent intentResultado = new Intent(Juego.this, Resultado.class);

        // El maximo de preguntas será igual al numero de preguntas que contenga el planeta
        int maxPreguntas = MainActivity.planetas.get(MainActivity.planetaMostrado).
                getPreguntas().size();



        //Si no quedan mas preguntas en el planeta
        if(!(numPregunta < maxPreguntas-1)){
            // Si no es el último planeta
            if (MainActivity.planetaMostrado < MainActivity.ultimoPlaneta ){

                // Incrementamos 1 para mostrar el siguiente
                MainActivity.planetaMostrado++;

                // Reiniciamos el iterador de preguntas para que muestre la priemera en el siguiente planeta
                numPregunta = 0;

                // Vuelve para mostrar el contenido
                startActivity(intent);
            }
            else{
                startActivity(intentResultado);
            }


    }
}}

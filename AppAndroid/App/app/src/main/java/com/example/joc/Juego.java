package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.GridView;
import android.widget.TextView;
import android.widget.Toast;
import java.util.ArrayList;
import java.util.List;

public class Juego extends AppCompatActivity {

    //Iterador de preguntas
    private static int numPregunta = 0;
    // Lista de respuestas de una pregunta
    private List<Respuesta> respuestas =  new ArrayList<Respuesta>();
    // Contiene las preguntas del planetaMostrado
    private List<Pregunta> preguntas = MainActivity.planetas.get(MainActivity.planetaMostrado).getPreguntas();
    // Guarda las preguntas según la dificultad seleccionada
    private List<Pregunta> preguntasFiltradas = new ArrayList<Pregunta>();
    // Objeto GridView donde iran las respuestas
    private GridView gridRespuestas = findViewById(R.id.listRespuestas);



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_juego);


        // Filtra las preguntas por dificultad seleccionada
        filtrarPreguntas();


        // Si tras filtrar las preguntas la lista no queda vacía
        if(!(preguntasFiltradas.size() == 0)) {

            // Carga la pregunta y las respuestas
            cargarContenido();
        }
        // Si tras filtrar las preguntas la lista quedase vacía
        else{
            // Pasa al siguiente planeta
            avanzarPlaneta();
        }



        // Al pulsar sobre una respuesta
        gridRespuestas.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                // El maximo de preguntas será igual al numero de preguntas que contenga el planeta
                int maxPreguntas = MainActivity.planetas.get(MainActivity.planetaMostrado).
                        getPreguntas().size();

                // Guarda la respuesta pulsada por el usuario
                Integer respuestaSeleccionada = (Integer)view.getTag();



                // Suma un acierto si la respuesta es correcta
                puntuarPregunta(respuestaSeleccionada);


                // Si quedan mas preguntas en el planeta
                if (numPregunta < maxPreguntas-1){

                    // Incrementamos 1 para mostrar la siguiente
                    numPregunta++;

                    // recarga la actividad
                    recreate();
                }

                //Si no quedan mas preguntas en el planeta
                else{
                    avanzarPlaneta();
                }



            }
        });

    }

    private void puntuarPregunta(int respuestaSeleccionada) {
        // Si la respuesta es correcta
        if (respuestas.get(respuestaSeleccionada).isEsCorrecta() ){

            // Suma un acierto
            Resultado.aciertos++;

            /*ELEMENTO PROVISIONAL*/
            Toast.makeText(Juego.this, "ACIERTO",
                    Toast.LENGTH_LONG).show();
        }
    }

    // Carga el la pregunta en el textView y sus respuestas en la grid mediante el adaptador
    private void cargarContenido() {
        // Objeto Textview donde ira la pregunta
        TextView preguntaView = findViewById(R.id.pregunta);

        // coloca la pregunta en el textView
        preguntaView.setText(preguntasFiltradas.get(numPregunta).getPregunta());

        // Lista de respuestas de la pregunta
        respuestas = preguntasFiltradas.get(numPregunta).getRespuestas();

        // Instancia nuestro adaptador personalizado con el contexto y las respuestas
        RespuestaAdapter adaptador = new RespuestaAdapter(this, respuestas);

        // La grid usa ahora este adaptador personalizado
        gridRespuestas.setAdapter(adaptador);
    }

    // Guarda las preguntas en una nueva lista seleccionando aquellas iguales a la dificultad seleccionada
    private void filtrarPreguntas() {
        // MODO FACIL SELECCIONADO
        if (Dificultad.dificultadSeleccionada){

            // Recorre todas las preguntas del planeta
            for (int i = 0 ; i < preguntas.size() ; i++){

                // Si la pregunta (i) es facil
                if (preguntas.get(i).isDificultad()){

                    // La añade a la lista de preguntas filtradas
                    preguntasFiltradas.add(preguntas.get(i) );
                }
            }
        }
        // MODO DIFICIL SELECCIONADO
        else{

            // Recorre todas las preguntas del planeta
            for (int i = 0 ; i <  preguntas.size() ; i++){

                // Si la pregunta (i) es dificil
                if ( ! (preguntas.get(i).isDificultad() ) ){

                    // La añade a la lista de preguntas filtradas
                    preguntasFiltradas.add(preguntas.get(i) );
                }
            }
        }
    }

    // Pasa al siguiente planeta, o en caso de ser el último, a la pantalla Resultado
    private void avanzarPlaneta(){

        // Intents
        Intent intent = new Intent(Juego.this, Contenido.class);
        Intent intentResultado = new Intent(Juego.this, Resultado.class);

        // El maximo de preguntas será igual al numero de preguntas que contenga el planeta
        int maxPreguntas = MainActivity.planetas.get(MainActivity.planetaMostrado).
                getPreguntas().size();


        // Si no es el último planeta
        if (MainActivity.planetaMostrado < MainActivity.ultimoPlaneta ){

            // Incrementamos 1 para mostrar el siguiente planeta
            MainActivity.planetaMostrado++;

            // Reiniciamos el iterador de preguntas para que muestre la priemera en el siguiente planeta
            numPregunta = 0;

            // Vuelve para mostrar el contenido
            startActivity(intent);
        }
        // Si es el último planeta
        else{
            // Salta al activity Resultado
            startActivity(intentResultado);
        }
    }
}

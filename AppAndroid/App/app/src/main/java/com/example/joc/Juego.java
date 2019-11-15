package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.GridView;
import android.widget.ImageView;
import android.widget.TextView;
import java.util.ArrayList;
import java.util.List;

public class Juego extends AppCompatActivity {
/*

 1. Recibimos la primera pregunta a mostrar con las variables:
    MainActivity.getPlanetaMostrado() y preguntaMostrada

 2. Filtrar las preguntas y guardarlas en una lista nueva

 3. Rellenar(); <-- Muestra la pregunta en el textview y sus respuestas en la gridview

 4. OnClick respuesta:
    4.1 Si hay más preguntas se muestra la siguiente y llamamos a rellenar()
    4.2 Si no hay más preguntas pasamos de planeta (si quedan)
*/
    private static int preguntaMostrada = 0;

    static List<Pregunta> preguntasFiltradas = new ArrayList<Pregunta>();

    public int getPreguntaMostrada() {
        return preguntaMostrada;
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_juego);


        // Lista de planetas
        final List<Planeta> planetas = Importar.getPlanetas();

        filtrarPreguntas( planetas.get(MainActivity.getPlanetaMostrado()).getPreguntas() );

        cargarContenido();

        // Imagen Salir
        ImageView salir = findViewById(R.id.inicio);

        // Click en salir
        salir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                // Devuelve RESULT OK a la clase Contenido
                setResult(Contenido.RESULT_OK);

                // Cierra esta actividad
                finish();
            }
        });

        GridView gridRespuestas = findViewById(R.id.gridRespuestas);
        // Al pulsar sobre un item del grid
        gridRespuestas.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                if ( preguntaMostrada < preguntasFiltradas.size() ){

                    preguntaMostrada++;
                    cargarContenido();
                }
                else{
                    int planetaMostrado = MainActivity.getPlanetaMostrado();
                    planetaMostrado++;

                    if ( planetaMostrado < MainActivity.getUltimoPlaneta() ){

                        // Devuelve RESULT OK a la clase Dificultad
                        //setResult(Contenido.RESULT_FIRST_USER);

                        //Cierra esta actividad
                        finish();
                    }
                }


            }
        });




    }


    private void cargarContenido() {
        List<Respuesta> respuestas = preguntasFiltradas.get(preguntaMostrada).getRespuestas();

        TextView viewPregunta = findViewById(R.id.pregunta);
        GridView gridRespuestas = findViewById(R.id.gridRespuestas);

        viewPregunta.setText(preguntasFiltradas.get(preguntaMostrada).getPregunta());

        //Instancia nuestro adaptador personalizado
        Adaptador adaptador = new Adaptador(this, respuestas);

        gridRespuestas.setAdapter(adaptador);
    }

    private void filtrarPreguntas(List<Pregunta> preguntas) {

        // Dificultad de juego: Facil
        if (!Dificultad.dificultadSeleccionada){

            // Recorre la lista de preguntas
            for (int i = 0 ; i < preguntas.size() ; i++){

                // Si la pregunta es facil
                if (preguntas.get(i).isDificultad()){

                    // Se añade a la lista de preguntas filtradas
                    preguntasFiltradas.add( preguntas.get(i) );
                }
            }
        }
        //Dificultad de juego: Dificil
        else{

            // Recorre la lista de preguntas
            for (int i = 0 ; i <  preguntas.size() ; i++){

                // Si la pregunta es dificil
                if ( ! preguntas.get(i).isDificultad() ){

                    // Se añade a la lista de preguntas filtradas
                    preguntasFiltradas.add(preguntas.get(i) );
                }
            }
        }


    }


}

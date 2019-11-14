package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.GridView;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;
import java.util.ArrayList;
import java.util.List;

public class Juego extends AppCompatActivity {

    // Iterador de preguntas
    public static int numPregunta = 0;

    // Lista con las respuestas sin filtrar por dificultad
    private List<Respuesta> respuestas =  new ArrayList<Respuesta>();

    private static final byte RESULTADO_ACTIVITY = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_juego);

        // Guarda en planetas la lista de planetas del json
        final List<Planeta> planetas = Importar.planetas;

        // Objeto GridView donde iran las respuestas
        final GridView gridRespuestas = findViewById(R.id.listRespuestas);

        // Objeto Textview donde ira la pregunta
        TextView preguntaView = findViewById(R.id.pregunta);

        // Contiene las preguntas
        List<Pregunta> preguntas = planetas.get(MainActivity.planetaMostrado).getPreguntas();

        // Guarda las preguntas según la dificultad seleccionada
        List<Pregunta> preguntasFiltradas = new ArrayList<Pregunta>();

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

        // Dificultad de juego: Facil
        if (Dificultad.dificultadSeleccionada){

            // Recorre la lista de preguntas
            for (int i = 0 ; i < preguntas.size() ; i++){

                // Si la pregunta es facil
                if (preguntas.get(i).isDificultad()){

                    // Se añade a la lista de preguntas filtradas
                    preguntasFiltradas.add(preguntas.get(i) );
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

        // Si tras filtrar las preguntas por dificultad hay más de 0
        if(!(preguntasFiltradas.size() == 0)) {

            // Se carga la pregunta y sus respuestas
            cargarContenido( preguntaView, preguntasFiltradas, gridRespuestas );
        }
        // Si el planeta no contiene preguntas con la dificultad
        else{
            // Se pasa al siguiente planeta
            pasarPlaneta(planetas);
        }


        // Al pulsar sobre una respuesta
        gridRespuestas.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                // El maximo de preguntas será igual al numero de preguntas que contenga el planeta
                int maxPreguntas = planetas.get(MainActivity.planetaMostrado).
                        getPreguntas().size();

                // Guarda la respuesta seleccionada por el usuario
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

                    // Recarga la actividad
                    recreate();
                }
                // Si no quedan mas preguntas en el planeta
                else{
                    pasarPlaneta(planetas);
                }
            }
        });
    }

    // Carga la pregunta en el textview y sus respuestas en el gridview
    private void cargarContenido(TextView preguntaView, List<Pregunta> preguntasFiltradas, GridView gridRespuestas) {

        // coloca la pregunta en el textView
        preguntaView.setText(preguntasFiltradas.get(numPregunta).getPregunta());

        // Vacía todas las respuestas
        respuestas.clear();

        // Lista de respuestas de la pregunta
        respuestas = preguntasFiltradas.get(numPregunta).getRespuestas();

        // Instancia nuestro adaptador personalizado
        RespuestaAdapter adaptador = new RespuestaAdapter(this, respuestas);

        // La grid usa ahora este adaptador personalizado
        gridRespuestas.setAdapter(adaptador);
    }

    // Pasa al siguiente planeta. Si es el último, abre la activity Resultado
    private void pasarPlaneta(List<Planeta> planetas){

        // Intents
        Intent Resultado = new Intent(Juego.this, Resultado.class);

        // El máximo de preguntas será igual al número de preguntas que contenga el planeta
        int maxPreguntas = planetas.get(MainActivity.planetaMostrado).getPreguntas().size();

        // Si no es el último planeta
        if (MainActivity.planetaMostrado < MainActivity.ultimoPlaneta ){

            // Incrementamos 1 para mostrar el siguiente
            MainActivity.planetaMostrado++;

            // Reiniciamos el iterador de preguntas para que muestre la priemera del siguiente planeta
            numPregunta = 0;

            // Vuelve a la activity contenido
            setResult(Juego.RESULT_FIRST_USER);
            finish();
        }
        // Si es el último planeta
        else{
            // Abre la activity Resultado
            startActivityForResult(Resultado, RESULTADO_ACTIVITY);
        }
    }

    // Resultado de startActivityForResult
    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        // Si la actividad de la que volvemos
        if (requestCode == RESULTADO_ACTIVITY) {

            // Y devuelve RESULT_OK
            if (resultCode == RESULT_OK) {

                // Devuelve RESULT OK a la clase Resultado
                setResult(Juego.RESULT_OK);

                // Cerramos esta actividad también
                finish();
            }

        }
    }
}
